using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceLibrary.Models; 

namespace AttendanceSystem
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //LoginWindow loginWindow = new LoginWindow();

            //if (loginWindow.ShowDialog() != DialogResult.OK)
            //{
            //    System.Windows.Forms.Application.Exit();
            //};

        }

        private void addTeacherLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTeacherWindow addTeacherWindow = new AddTeacherWindow();
            addTeacherWindow.ShowDialog();
            addTeacherWindow.Dispose();
        }

        private void addStudentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void addGroupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddGroupWindow groupWindow = new AddGroupWindow();
            groupWindow.ShowDialog();
            groupWindow.Dispose();

        }
    }
}
