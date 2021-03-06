﻿using System;
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
    public partial class AddGroupWindow : Form
    {
        private string _fieldError = null; //tracks errors in fields
        private Teacher[] _teachers;
        SqlConnector _connector; 
        public AddGroupWindow(SqlConnector connector)
        {
            InitializeComponent();
            _connector = connector; 

            _teachers = _connector.GetAllTeachers();

            curatorsComboBox.DataSource = _teachers;
            curatorsComboBox.DisplayMember = "FullName"; 
        }
    //
        private void addButton_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            _CaptureGroupData(group); 

            if(_ValidateGroupData(group))
            {
                _connector.AddGroup(group);
                groupNameTextBox.Text = ""; 
            }
            else
            {
                MessageBox.Show(_fieldError, "Info");
                _fieldError = null; 
            }
        }

    //
        private void _CaptureGroupData(Group group)
        {
            group.Name = groupNameTextBox.Text.Trim(); 

            Teacher selectedTeacher = (Teacher)curatorsComboBox.SelectedItem;
            group.CuratorId = selectedTeacher.Id;
        }
        private bool _ValidateGroupData(Group group)
        {
            return _IsGroupNameValid(group.Name); 
        }
        private bool _IsGroupNameValid(string name)
        {
            if (!_connector.GroupExists(name) && name.Length >= 4)
            {
                return true; 
            }
            else
            {
                _fieldError = "Name is too short or group already exists";
                return false;
            }
        }
    }
}
