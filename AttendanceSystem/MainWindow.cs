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
        private Teacher _loggedTeacher = null; // teached logged into the system

        private Group[]  _existingGroups;// all currently existing groups
        private Lesson[] _existingLessons; // // all currently existing lessons

        private DataTable _lessonAttendanceTable = new DataTable(); // table for lesson`s attandance
        private DataTable _allTimeAttendanceTable = new DataTable(); //table for attandance for all lessons

        private ContextMenu _studentAttendanceStatusMenu = new ContextMenu(); // menu with choises for a student`s attendance
        private CellPosition _clickedCell = new CellPosition(); // a cell where mouse was pressed in

        private Student[] _students = null; // array of students currently shown in lessonAttendanceGridView

        private SqlConnector _connector = new SqlConnector(new SqlServerConnector());

        //
        public MainWindow()
        {
            InitializeComponent();

            //
            _existingGroups = _connector.GetAllGroups();
            _existingLessons = _connector.GetAllLessons();

            //
            _SetupLessonAttendanceDataTable(_lessonAttendanceTable);
            _SetupLessonAttendanceDataGrid(_lessonAttendanceTable);

            _SetupAttendanceDataTable(_allTimeAttendanceTable);  
            _SetupAttendanceDataGrid(_allTimeAttendanceTable);

            //
            _InitComboBoxesTab1();
            _InitComboBoxesTab2();

            //
            _InitStudentAttandanceStatusMenu();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {           
            LoginWindow loginWindow = new LoginWindow(_connector);

            if (loginWindow.ShowDialog() != DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                _loggedTeacher = loginWindow.loggedTeacher; 


                if(_loggedTeacher.SystemStatus == "limited")
                {
                    addTeacherLinkLabel.Hide();     
                    addStudentLinkLabel.Hide();     
                    addGroupLinkLabel.Hide();     
                    addLessonLinkLabel.Hide();     
                }
            }    

            tabControl.SelectedTab = attendanceTabPage;
        }
        private void addTeacherLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTeacherWindow addTeacherWindow = new AddTeacherWindow(_connector);
            addTeacherWindow.ShowDialog();
            addTeacherWindow.Dispose();
        }
        private void addStudentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddStudentWindow studentWindow = new AddStudentWindow(_connector);
            studentWindow.ShowDialog();
            studentWindow.Dispose(); 
        }
        private void addGroupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddGroupWindow groupWindow = new AddGroupWindow(_connector);
            groupWindow.ShowDialog();
            groupWindow.Dispose();

        }
        private void addLessonLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddLessonWindow lessonWindow = new AddLessonWindow(_connector);
            lessonWindow.ShowDialog();
            lessonWindow.Dispose(); 
        }
        private void groups2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UpdateLessonAttendanceDataTable(_lessonAttendanceTable);
        }
        private void lessonAttendanceGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                _clickedCell.Column = e.ColumnIndex;
                _clickedCell.Row = e.RowIndex;

                Point pos = this.PointToClient(Cursor.Position); // get current cursor position in the client area
                _studentAttendanceStatusMenu.Show(this, pos, LeftRightAlignment.Right);
            }
        }
        private void studentAttendanceStatusMenuItem_Clicked(object sender, EventArgs args)
        {
            _lessonAttendanceTable.Rows[_clickedCell.Row].SetField(_clickedCell.Column, ((MenuItem)sender).Text);
        }
        private void saveButton_tab2_Click(object sender, EventArgs e)
        {
            if(!_AllStudensHaveAttandanceStatus())
            {
                MessageBox.Show("Not every student was processed"); 
            }
            else
            {
               _connector.AddAttendanceInfo(_CreateAttendanceInfoRows());    
            }
        }
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            _UpdateAttendanceDataTable(_allTimeAttendanceTable);
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

            lessonAttendanceGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable; 
            lessonAttendanceGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable; 

            DataGridViewColumn column = lessonAttendanceGridView.Columns[0]; 

            //setting for 'Students'  column
            column.Width = 250; // width in pixels
            column.ReadOnly = true;

            //setting for 'Attendance' column
            column = lessonAttendanceGridView.Columns[1];
            column.Width = 150; // width in pixels
            column.ReadOnly = true;
        }
        private void _SetupAttendanceDataTable(DataTable attendanceTable)
        {
            attendanceTable.Columns.Add("Student", typeof(string));
            attendanceTable.Columns.Add("Attendance", typeof(string));  
        }
        private void _SetupAttendanceDataGrid(DataTable attendanceTable)
        {
            attendanceGridView.AllowUserToAddRows = false;

            attendanceGridView.DataSource = attendanceTable;

            attendanceGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            attendanceGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewColumn column = attendanceGridView.Columns[0];

            //settings for 'Students'  column
            column.Width = 200; // width in pixels
            column.ReadOnly = true;

            //settings  for 'Attendance' column
            column = attendanceGridView.Columns[1];
            column.Width = 200; // width in pixels
            column.ReadOnly = true;
        }
        private void _UpdateLessonAttendanceDataTable(DataTable lessonAttendanceTable)
        {
            if (lessonAttendanceTable.Rows.Count > 0) lessonAttendanceTable.Clear();

            Group selectedGroup = (Group)groupComboBox_tab2.SelectedItem; 
            _students = _connector.GetStudensByGroup(selectedGroup.Name);

            foreach(Student student in _students)
            {
                lessonAttendanceTable.Rows.Add(new object[] { student.FullName.Trim(), null }); 
            }
        } 
        private void _UpdateAttendanceDataTable(DataTable attendanceTable)
        {
            if (attendanceTable.Rows.Count > 0) attendanceTable.Clear();

            AttendanceInfo[] records = _connector.GetStudentsAttendance(groupComboBox_tab1.Text, lessonComboBox_tab1.Text, datePicker.Value.ToString("yyyy/MM/dd"));
            foreach (AttendanceInfo record in records)
            {
                attendanceTable.Rows.Add(new object[] { record.StudentFullName, record.Status }); 
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
        private void _InitStudentAttandanceStatusMenu()
        {
            MenuItem menuAbsent = new MenuItem();
            MenuItem menuPresent = new MenuItem();
            
            menuAbsent.Text = "absent";
            menuPresent.Text = "present";

            menuAbsent.Click += studentAttendanceStatusMenuItem_Clicked;
            menuPresent.Click += studentAttendanceStatusMenuItem_Clicked;

            _studentAttendanceStatusMenu.MenuItems.Add(menuAbsent);
            _studentAttendanceStatusMenu.MenuItems.Add(menuPresent); 
        }

    //
        /// <summary>
        /// Checks column 'Attendance' in lessonAttendanceGridView  for presence   null values
        /// </summary>
        /// <returns>false if at least one null value is present</returns>
        private bool _AllStudensHaveAttandanceStatus()
        {
            foreach(DataRow row in _lessonAttendanceTable.Rows)
            {
                if (row.Field<string>("Attendance") == null)  return false; 
            }
            return true; 
        } 
        /// <summary>
        /// Collects data from lessonAttendanceTabPage and create attandance records
        /// </summary>
        /// <returns></returns>
        private List<AttendanceInfo> _CreateAttendanceInfoRows()
        {
            List<AttendanceInfo> output= new List<AttendanceInfo>(_lessonAttendanceTable.Rows.Count);

            int rowId = 0; 
            foreach (DataRow row in _lessonAttendanceTable.Rows)
            {
                AttendanceInfo record = new AttendanceInfo(); 

                record.Lesson = lessonComboBox_tab2.Text;
                record.Status = row.Field<string>("Attendance");
                record.Date = DateTime.Now.Date.ToString("yyyy/MM/dd");
                record.StudentId = _students[rowId].Id;

                ++rowId;

                output.Add(record); 
            }

            return output; 
        }

       

      
    }
}
