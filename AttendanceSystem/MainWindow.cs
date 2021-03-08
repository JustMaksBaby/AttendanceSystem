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
        private Group[]  _existingGroups =  SqlConnector.GetAllGroups(); // all currently existing groups
        private Lesson[] _existingLessons = SqlConnector.GetAllLessons(); // // all currently existing lessons

        private Teacher _loggedTeacher = null;

        private DataTable _lessonAttendanceTable = new DataTable(); // table for lesson`s attandance
        private DataTable _allTimeAttendanceTable = new DataTable(); //table for attandance for all lessons
        

    //
        public MainWindow()
        {
            InitializeComponent();

            _SetupLessonAttendanceDataTable(_lessonAttendanceTable);
            _SetupLessonAttendanceDataGrid(_lessonAttendanceTable);
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //LoginWindow loginWindow = new LoginWindow();

            //if (loginWindow.ShowDialog() != DialogResult.OK)
            //{
            //    System.Windows.Forms.Application.Exit();
            //}
            //else
            //{
            //    _loggedTeacher = loginWindow.loggedTeacher; 


                groups1ComboBox.DataSource = _existingGroups;
                groups1ComboBox.DisplayMember = "Name";
                groups2ComboBox.DataSource = _existingGroups;
                groups2ComboBox.DisplayMember = "Name";

                lessons1ComboBox.DataSource = _existingLessons;
                lessons1ComboBox.DisplayMember = "Name";
                lessons2ComboBox.DataSource = _existingLessons;
                lessons2ComboBox.DisplayMember = "Name";


           


            //    if(_loggedTeacher.SystemStatus == "limited")
            //    {
            //        addTeacherLinkLabel.Hide();     
            //        addStudentLinkLabel.Hide();     
            //        addGroupLinkLabel.Hide();     
            //        addLessonLinkLabel.Hide();     
            //    }
            //}    
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
        private void groups2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UpdateLessonAttendanceDataTable(_lessonAttendanceTable);
        }

    //
        private void _SetupLessonAttendanceDataTable(DataTable lessonAttendanceTable)
        {
            lessonAttendanceTable.TableName = "LessonAttendance";
            lessonAttendanceTable.Columns.Add("Students",typeof(string));
            lessonAttendanceTable.Columns.Add("Attendance", typeof(string));
        }
        private void _SetupLessonAttendanceDataGrid(DataTable lessonAttendanceTable)
        {
            lessonAttendanceGridView.AllowUserToAddRows = false;

            lessonAttendanceGridView.DataSource = lessonAttendanceTable;

            DataGridViewColumn column = lessonAttendanceGridView.Columns[0]; 

            //setting for 'Students'  column
            column.Width = 250; // width in pixels
            column.ReadOnly = true;

            //setting for 'Attendance' column
            column = lessonAttendanceGridView.Columns[1];
            column.Width = 150; // width in pixels
        }
        private void _UpdateLessonAttendanceDataTable(DataTable lessonAttendanceTable)
        {
            if (lessonAttendanceTable.Rows.Count > 0) lessonAttendanceTable.Clear(); 
            
            Student[] students = SqlConnector.GetStudensByGroup(groups2ComboBox.Text);
            foreach(Student student in students)
            {
                lessonAttendanceTable.Rows.Add(new object[] { student.FullName.Trim(), null }); 
            }
        }

       
    }
}
