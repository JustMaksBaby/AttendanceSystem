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
using AttendanceLibrary.DataAccess; 

namespace AttendanceSystem
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        private Group[]  _existingGroups = SqlConnector.GetAllGroups();
        private Lesson[] _existingLessons = SqlConnector.GetAllLessons();
        private Teacher _loggedTeacher = null; 

    //
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();

            if (loginWindow.ShowDialog() != DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                _loggedTeacher = loginWindow.loggedTeacher; 


                groups1ComboBox.DataSource = _existingGroups;
                groups1ComboBox.DisplayMember = "Name";
                groups2ComboBox.DataSource = _existingGroups;
                groups2ComboBox.DisplayMember = "Name";

                lessonsComboBox.DataSource = _existingLessons;
                lessonsComboBox.DisplayMember = "Name"; 


                if(_loggedTeacher.SystemStatus == "limited")
                {
                    addTeacherLinkLabel.Hide();     
                    addStudentLinkLabel.Hide();     
                    addGroupLinkLabel.Hide();     
                    addLessonLinkLabel.Hide();     
                }
            }
        }

        private void addTeacherLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTeacherWindow addTeacherWindow = new AddTeacherWindow();
            addTeacherWindow.ShowDialog();
            addTeacherWindow.Dispose();
        }

        private void addStudentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddStudentWindow studentWindow = new AddStudentWindow();
            studentWindow.ShowDialog();
            studentWindow.Dispose(); 
        }

        private void addGroupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddGroupWindow groupWindow = new AddGroupWindow();
            groupWindow.ShowDialog();
            groupWindow.Dispose();

        }

        private void addLessonLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddLessonWindow lessonWindow = new AddLessonWindow();
            lessonWindow.ShowDialog();
            lessonWindow.Dispose(); 
        }
    }
}
