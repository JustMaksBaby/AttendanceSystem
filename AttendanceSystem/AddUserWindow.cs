using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceSystem.DataAccess;
using AttendanceSystem.PasswordProcessing;

namespace AttendanceSystem
{
    public partial class AddUserWindow : Form
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void userTextBox_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = userNameTextBox.Text;
            user.OriginalPassword = passwordTextBox.Text;
            
            if(SqlCon.UserExists(user))
            {
                MessageBox.Show("User with this name already exists", "Info");
                SqlCon.GetUser(user); 

            }
            else
            {
                Password.CreateHashedPassword(user);
                SqlCon.AddUser(user); 
            }
            
        }
    }
}
