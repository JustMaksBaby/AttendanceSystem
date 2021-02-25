using System;
using System.Linq;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using AttendanceLibrary.Models;
using System.Collections.Generic;
using AttendanceLibrary.DataAccess;
using AttendanceLibrary.PasswordProcessing;

namespace AttendanceSystem
{
    public partial class AddTeacherWindow : Form
    {
        private string _fieldError = null; // tracks errors in name and password fields

        public AddTeacherWindow()
        {
            InitializeComponent();
            statusesComboBox.Items.Add("admin");
            statusesComboBox.Items.Add("limited"); 
        }

    //--    
        private void addButton_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            LoggedUser loginInfo = new LoggedUser();

            _CaptureLoginData(loginInfo);
            _CaptureTeacherData(teacher); 

            if(_ValidateLoginData(loginInfo)  && _ValidateTeacherData(teacher))
            {
                Password.CreateHashedPassword(loginInfo);
                SqlConnector.AddUser(loginInfo, teacher);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                patronymicTextBox.Text = "";
                loginTextBox.Text = ""; 
                passwordTextBox.Text = ""; 
            }
            else
            {
                MessageBox.Show(_fieldError,"Info");
                _fieldError = null;
            } 
        }

    //--
        /// <summary>
        /// Extracts data from fields with login information
        /// </summary>
        /// <param name="loginInfo"></param>
        private void _CaptureLoginData(LoggedUser loginInfo)
        {
            loginInfo.Login = loginTextBox.Text.Trim();
            loginInfo.OriginalPassword = passwordTextBox.Text.Trim();
        }

        /// <summary>
        /// Extracts data from fields with teacher`s personal information
        /// </summary>
        /// <param name="teacher"></param>
        private void _CaptureTeacherData(Teacher teacher)
        {
            teacher.FirstName = firstNameTextBox.Text.Trim();
            teacher.LastName = lastNameTextBox.Text.Trim();
            teacher.Patronymic = patronymicTextBox.Text.Trim();
            teacher.SystemStatus = statusesComboBox.Text; 
        }

    //----
        private bool _ValidateLoginData(LoggedUser loginInfo)
        {
            return _IsPasswordValid(loginInfo.OriginalPassword) && _IsLoginValid(loginInfo.Login);
        }
        private bool _IsPasswordValid(string password)
        {
            
            if (password.Length < 8 || password.Length > 15)
            {
                _fieldError = _fieldError??"Password has wrong length. It shoud be  8 <= password <= 15";
                return false;
            }
            else if (password.Split(' ').Length > 1)
            {
                _fieldError = _fieldError??"Password is separated by spaces"; 
                return false; 
            } 
            else return true;
        } 
        private bool _IsLoginValid(string login)
        {
      
            if (login.Length < 4 || login.Length > 20)
            {
                _fieldError = _fieldError??"Login has wrong length.It shoud be 4 <= name <= 20";
                return false;

            }
            else if (login.Split(' ').Length > 1)
            {
                _fieldError = _fieldError??"Login is separated by spaces"; 
                return false;
            } 
            else if(SqlConnector.UserExists(login))
            {
                _fieldError = _fieldError ?? "User with this login already exists";
                return false;
            }
            else return true;
        } 

        private bool _ValidateTeacherData(Teacher teacher)
        {
            return _IsFullNameValid(teacher.FirstName, teacher.LastName, teacher.Patronymic);
        }
        private bool _IsFullNameValid(string firstName, string lastName, string patronymic )
        {
            if(SqlConnector.TeacherExists(firstName, lastName) && patronymic == "")
            {
                _fieldError = _fieldError??"Teacher with these first and last name already exists.Please set patronymic";
                return false;
            }

            return true; 
        }

        
    }
}
