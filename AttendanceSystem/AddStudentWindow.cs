using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceLibrary.DataAccess;
using AttendanceLibrary.Models; 

namespace AttendanceSystem
{
    public partial class AddStudentWindow : Form
    {
        private string _fieldError = "No description"; //tracks errors in fields
        private Group[] groupsList; 
        public AddStudentWindow()
        {
            InitializeComponent();
            groupsList = SqlConnector.GetAllGroups();
            if (groupsList.Length == 0)
            {
                groupsComboBox.Items.Add("No groups"); 
                groupsComboBox.Text = "No groups";  
            }
            else
            {
                groupsComboBox.DataSource = groupsList;
                groupsComboBox.DisplayMember = "Name";
            } 
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            _CaptureStudentData(student); 

            if(_ValildateStudentData(student))
            {
                SqlConnector.AddStudent(student);
                studentFirstNameTextBox.Text = ""; 
                studentLastNameTextBox.Text = ""; 
                studentPatronymicTextBox.Text = ""; 
                cardIdTextBox.Text = ""; 
            }
            else
            {
                MessageBox.Show(_fieldError, "Info"); 
            }
        }

    //
        private void _CaptureStudentData(Student student)
        {
            student.FirstName = studentFirstNameTextBox.Text.Trim();
            student.LastName = studentLastNameTextBox.Text.Trim();
            student.Patronymic = studentPatronymicTextBox.Text.Trim();
            student.CardId = Int32.Parse(cardIdTextBox.Text);
            student.RalatedGroup = groupsComboBox.Text; 
        }
        private bool _ValildateStudentData(Student student)
        {
            return _IsFullNameValid(student.FirstName, student.LastName, student.Patronymic) &&
                _IsCardIdValid(student.CardId) && _IsGroupValid(student.RalatedGroup);
        }
        private bool _IsFullNameValid(string firstName, string lastName, string patronymic)
        {
            return true;
        }
        private bool _IsCardIdValid(int cardId)
        {
            return true; 
        } 
        private bool _IsGroupValid(string groupName)
        {
            if (groupName == "No groups" )
            {
                _fieldError = "Student shoud have a group";
                return false;
            }
            return true; 
        }
    }
}
