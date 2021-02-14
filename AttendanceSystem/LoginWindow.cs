using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceSystem.PasswordProcessing;

namespace AttendanceSystem
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.OriginalPassword = passwordTextBox.Text;
            Password.CreateHashedPassword(user);
        }

        private void addUserLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.Show(); 
        }
    }
}
