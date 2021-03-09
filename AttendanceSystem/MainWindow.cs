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

        private Teacher _loggedTeacher = null; // teached logged into the system

        private DataTable _lessonAttendanceTable = new DataTable(); // table for lesson`s attandance
        private DataTable _allTimeAttendanceTable = new DataTable(); //table for attandance for all lessons

        private ContextMenu _appearanceChoisesMenu = new ContextMenu(); // menu with choises for a student appearance
        private CellPosition _clickedCell = new CellPosition(); // a cell which mouse was pressed in
        

    //
        public MainWindow()
        {
            InitializeComponent();

            _SetupLessonAttendanceDataTable(_lessonAttendanceTable);
            _SetupLessonAttendanceDataGrid(_lessonAttendanceTable);

            _InitComboBoxesTab1();
            _InitComboBoxesTab2();

            _InitAppearanceChoisesMenu(); 
          
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
        private void lessonAttendanceGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 1)
            {
                _clickedCell.Column = e.ColumnIndex;
                _clickedCell.Row = e.RowIndex;

                Point pos = this.PointToClient(Cursor.Position); // get current cursor position in the client area
                _appearanceChoisesMenu.Show(this, pos, LeftRightAlignment.Right);
            }
        }
        private void appearanceChoisesMenu_Clicked(object sender, EventArgs args)
        {
            _lessonAttendanceTable.Rows[_clickedCell.Row].SetField(_clickedCell.Column, ((MenuItem)sender).Text);
        }


    //
        private void _SetupLessonAttendanceDataTable(DataTable lessonAttendanceTable)
        {
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
            column.ReadOnly = true;
        }
        private void _UpdateLessonAttendanceDataTable(DataTable lessonAttendanceTable)
        {
            if (lessonAttendanceTable.Rows.Count > 0) lessonAttendanceTable.Clear(); 
            
            Student[] students = SqlConnector.GetStudensByGroup(groupComboBox_tab2.Text);
            foreach(Student student in students)
            {
                lessonAttendanceTable.Rows.Add(new object[] { student.FullName.Trim(), null }); 
            }
        }
        private void _InitComboBoxesTab1()
        {
            groupComboBox_tab1.DataSource = _existingGroups;
            groupComboBox_tab1.DisplayMember = "Name";

            lessonComboBox_tab1.DataSource = _existingLessons;
            lessonComboBox_tab1.DisplayMember = "Name";
        }
        private void _InitComboBoxesTab2()
        {
            groupComboBox_tab2.DataSource = _existingGroups;
            groupComboBox_tab2.DisplayMember = "Name";

            lessonComboBox_tab2.DataSource = _existingLessons;
            lessonComboBox_tab2.DisplayMember = "Name";
        }
        private void _InitAppearanceChoisesMenu()
        {
            MenuItem menuAbsent = new MenuItem();
            MenuItem menuPresent = new MenuItem();
            
            menuAbsent.Text = "absent";
            menuPresent.Text = "present";

            menuAbsent.Click += appearanceChoisesMenu_Clicked;
            menuPresent.Click += appearanceChoisesMenu_Clicked;

            _appearanceChoisesMenu.MenuItems.Add(menuAbsent);
            _appearanceChoisesMenu.MenuItems.Add(menuPresent); 
        }

    }
}
