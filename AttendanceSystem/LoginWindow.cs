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
        private string _fieldError = null; // tracks errors in name and password fields
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            User testedUser = new User();
            testedUser.OriginalPassword = passwordTextBox.Text.Trim();
            testedUser.Name = userNameTextBox.Text.Trim(); 

            if(_ValidateUserData(testedUser))
            {
                this.DialogResult = DialogResult.OK; 
                this.Close();    
            }
            else
            {
                MessageBox.Show(_fieldError,"Info");
            }

        }

        //
        private bool  _ValidateUserData(User testedUser)
        {
            if(_IsNameValid(testedUser))
            {
                User userFromDb = SqlConnector.GetUserByName(testedUser.Name); 

                if(_IsPasswordValid(userFromDb, testedUser))
                {
                    return true;
                }
            }

            return false; 
            
        }
        private bool _IsPasswordValid(User userFromDb, User testedUser  )
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
        private bool _IsNameValid(User testedUser)
        {
            if (SqlConnector.UserExists(testedUser.Name))
            {
                return true;
            }
            else
            {
                _fieldError = "There is no user with this name";
                return false; 
            }
        }
    }
}
