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
    public partial class AddUserWindow : Form
    {
        private string _fieldError = null; // tracks errors in name and password fields

        public AddUserWindow()
        {
            InitializeComponent();
        }

        //    
        private void addButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = userNameTextBox.Text.Trim();
            user.OriginalPassword = passwordTextBox.Text.Trim();
            
            if(_ValidateUserData(user))
            {
                Password.CreateHashedPassword(user);

                if (!SqlConnector.AddUser(user))
                {
                    MessageBox.Show("User with this name already exists", "Info");
                }
                else
                {
                    userNameTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show(_fieldError,"Info");
                _fieldError = null;
            } 
        }

        //
        private bool _ValidateUserData(User user)
        {
            return _IsPasswordValid(user.OriginalPassword) && _IsNameValid(user.Name);
        }
        private bool _IsPasswordValid(string password)
        {
            
            if (password.Length < 8 || password.Length > 15)
            {
                _fieldError = "Password has wrong length. It shoud be  8 <= password <= 15";
                return false;
            }
            else if (password.Split(' ').Length > 1)
            {
                _fieldError = "Password is separated by spaces"; 
                return false; 
            } 
            else return true;
        } 
        private bool _IsNameValid(string name)
        {
      
            if (name.Length < 4 || name.Length > 20)
            {
                _fieldError = "Name has wrong length.It shoud be 4 <= name <= 20";
                return false;

            }
            else if (name.Split(' ').Length > 1)
            {
                _fieldError = "Name is separated by spaces"; 
                return false;
            } 
            else return true;
        }

    }
}
