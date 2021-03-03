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
    public partial class AddLessonWindow : Form
    {
        private string _fieldError = "No description"; //tracks errors in fields
        
        public AddLessonWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Lesson lesson = new Lesson();
            _CatchLessonData(lesson); 

            if(_ValidateLessonData(lesson))
            {
                SqlConnector.AddLesson(lesson);
                lessonNameTextBox.Text = ""; 
            }
            else
            {
                MessageBox.Show(_fieldError, "Info");
                _fieldError = "No description"; 
            }
                   
        }

    //
        private void _CatchLessonData(Lesson lesson)
        {
            lesson.Name = lessonNameTextBox.Text.Trim(); 
        }
        private bool _ValidateLessonData(Lesson lesson)
        {
            return _IsNameValid(lesson.Name); 
        }
        private bool _IsNameValid(string lessonName)
        {
            if(SqlConnector.LessonExists(lessonName))
            {
                _fieldError = "Lesson with this name alrady exists";  
                return false; 
            }

            return true;
        }
    }
}
