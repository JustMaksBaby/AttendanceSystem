using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using AttendanceLibrary.Models;
using System.Collections.Generic;
using AttendanceLibrary.DataAccess;
using AttendanceLibrary.PasswordProcessing;

namespace AttendanceSystem
{
    public partial class LoginWindow : Form
    {
        private string _fieldError = null; // tracks errors in teacher information fields
        public Teacher loggedTeacher = null; 
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoggedUser testedUser = new LoggedUser();
            testedUser.OriginalPassword = passwordTextBox.Text.Trim();
            testedUser.Login = userNameTextBox.Text.Trim(); 

            if(_ValidateLoginData(testedUser))
            {
                loggedTeacher = SqlConnector.GetTeacherByLogin(testedUser.Login);   

                this.DialogResult = DialogResult.OK; 
                
                this.Close();    
            }
            else
            {
                MessageBox.Show(_fieldError,"Info");
                _fieldError = null;  
            }

        }

    //
        private bool  _ValidateLoginData(ILoginInfo testedUser)
        {
            if(_IsLoginValid(testedUser))
            {
                ILoginInfo userFromDb = SqlConnector.GetLoginInfo(testedUser.Login); 

                if(_IsPasswordValid(userFromDb, testedUser))
                {
                    return true;
                }
            }

            return false; 
            
        }
        private bool _IsPasswordValid(ILoginInfo userFromDb, ILoginInfo testedUser  )
        {
            if (Password.AreEquil(userFromDb, testedUser))
            {
                return true;
            }
            else
            {
                _fieldError = "The password is wrong";
                return false;
            }

        }
        private bool _IsLoginValid(ILoginInfo testedUser)
        {
            if (SqlConnector.UserExists(testedUser.Login))
            {
                return true;
            }
            else
            {
                _fieldError = "There is no user with this login";
                return false; 
            }
        }
    }
}
