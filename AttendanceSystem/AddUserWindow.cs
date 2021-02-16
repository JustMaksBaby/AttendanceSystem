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
  
        public AddUserWindow()
        {
            InitializeComponent();
        }

        //
        private void userTextBox_Click(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!_ValidateFields())
            {
                MessageBox.Show("Password or user name is empty or not long enough.", "Info");
            }
            else
            {
                User user = new User();
                user.Name = userNameTextBox.Text;
                user.OriginalPassword = passwordTextBox.Text;
                Password.CreateHashedPassword(user);

                if (!SqlConnector.AddUser(user))
                {
                    MessageBox.Show("User with this name already exists", "Info");                     
                }

                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
            } 
        }

        //
        private bool _ValidateFields()
        {
            return _IsPasswordLongEnough() && _IsNameValid();
        }
        private bool _IsPasswordLongEnough()
        {
            if (passwordTextBox.Text.Trim().Length < 8) return false;
            else return true; 
        } 
        private bool _IsNameValid()
        {
            if (userNameTextBox.Text.Trim().Length < 4) return false;
            else return true;
        }
    }
}
