namespace AttendanceSystem
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.attendanceTabPage = new MetroFramework.Controls.MetroTabPage();
            this.chooseLessonLabel = new System.Windows.Forms.Label();
            this.lessonComboBox_tab1 = new System.Windows.Forms.ComboBox();
            this.chooseDataLabel = new System.Windows.Forms.Label();
            this.chooseGroupLabel = new System.Windows.Forms.Label();
            this.attendanceGridView = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupComboBox_tab1 = new System.Windows.Forms.ComboBox();
            this.lessonAttendanceTabPage = new MetroFramework.Controls.MetroTabPage();
            this.lessonLabel = new System.Windows.Forms.Label();
            this.lessonComboBox_tab2 = new System.Windows.Forms.ComboBox();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.lessonAttendanceGridView = new System.Windows.Forms.DataGridView();
            this.groupComboBox_tab2 = new System.Windows.Forms.ComboBox();
            this.addTeacherLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addStudentLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addGroupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addLessonLinkLabel = new System.Windows.Forms.LinkLabel();
            this.saveButton_tab2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.attendanceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).BeginInit();
            this.lessonAttendanceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.attendanceTabPage);
            this.tabControl.Controls.Add(this.lessonAttendanceTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(941, 523);
            this.tabControl.TabIndex = 0;
            // 
            // attendanceTabPage
            // 
            this.attendanceTabPage.Controls.Add(this.chooseLessonLabel);
            this.attendanceTabPage.Controls.Add(this.lessonComboBox_tab1);
            this.attendanceTabPage.Controls.Add(this.chooseDataLabel);
            this.attendanceTabPage.Controls.Add(this.chooseGroupLabel);
            this.attendanceTabPage.Controls.Add(this.attendanceGridView);
            this.attendanceTabPage.Controls.Add(this.datePicker);
            this.attendanceTabPage.Controls.Add(this.groupComboBox_tab1);
            this.attendanceTabPage.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceTabPage.HorizontalScrollbarBarColor = true;
            this.attendanceTabPage.Location = new System.Drawing.Point(4, 39);
            this.attendanceTabPage.Name = "attendanceTabPage";
            this.attendanceTabPage.Size = new System.Drawing.Size(933, 480);
            this.attendanceTabPage.TabIndex = 0;
            this.attendanceTabPage.Text = "Attendance ";
            this.attendanceTabPage.VerticalScrollbarBarColor = true;
            // 
            // chooseLessonLabel
            // 
            this.chooseLessonLabel.AutoSize = true;
            this.chooseLessonLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseLessonLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLessonLabel.Location = new System.Drawing.Point(196, 18);
            this.chooseLessonLabel.Name = "chooseLessonLabel";
            this.chooseLessonLabel.Size = new System.Drawing.Size(71, 22);
            this.chooseLessonLabel.TabIndex = 11;
            this.chooseLessonLabel.Text = "Lesson:";
            // 
            // lessonComboBox_tab1
            // 
            this.lessonComboBox_tab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonComboBox_tab1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonComboBox_tab1.FormattingEnabled = true;
            this.lessonComboBox_tab1.Location = new System.Drawing.Point(196, 43);
            this.lessonComboBox_tab1.Name = "lessonComboBox_tab1";
            this.lessonComboBox_tab1.Size = new System.Drawing.Size(199, 28);
            this.lessonComboBox_tab1.TabIndex = 10;
            // 
            // chooseDataLabel
            // 
            this.chooseDataLabel.AutoSize = true;
            this.chooseDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseDataLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDataLabel.Location = new System.Drawing.Point(404, 19);
            this.chooseDataLabel.Name = "chooseDataLabel";
            this.chooseDataLabel.Size = new System.Drawing.Size(54, 22);
            this.chooseDataLabel.TabIndex = 6;
            this.chooseDataLabel.Text = "Date:";
            // 
            // chooseGroupLabel
            // 
            this.chooseGroupLabel.AutoSize = true;
            this.chooseGroupLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseGroupLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseGroupLabel.Location = new System.Drawing.Point(3, 19);
            this.chooseGroupLabel.Name = "chooseGroupLabel";
            this.chooseGroupLabel.Size = new System.Drawing.Size(67, 22);
            this.chooseGroupLabel.TabIndex = 5;
            this.chooseGroupLabel.Text = "Group:";
            // 
            // attendanceGridView
            // 
            this.attendanceGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.attendanceGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.attendanceGridView.Location = new System.Drawing.Point(0, 81);
            this.attendanceGridView.Name = "attendanceGridView";
            this.attendanceGridView.RowHeadersWidth = 51;
            this.attendanceGridView.RowTemplate.Height = 24;
            this.attendanceGridView.Size = new System.Drawing.Size(933, 399);
            this.attendanceGridView.TabIndex = 4;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(408, 44);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(312, 27);
            this.datePicker.TabIndex = 3;
            // 
            // groupComboBox_tab1
            // 
            this.groupComboBox_tab1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox_tab1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox_tab1.FormattingEnabled = true;
            this.groupComboBox_tab1.Location = new System.Drawing.Point(0, 43);
            this.groupComboBox_tab1.Name = "groupComboBox_tab1";
            this.groupComboBox_tab1.Size = new System.Drawing.Size(191, 28);
            this.groupComboBox_tab1.TabIndex = 2;
            // 
            // lessonAttendanceTabPage
            // 
            this.lessonAttendanceTabPage.Controls.Add(this.saveButton_tab2);
            this.lessonAttendanceTabPage.Controls.Add(this.lessonLabel);
            this.lessonAttendanceTabPage.Controls.Add(this.lessonComboBox_tab2);
            this.lessonAttendanceTabPage.Controls.Add(this.groupsLabel);
            this.lessonAttendanceTabPage.Controls.Add(this.lessonAttendanceGridView);
            this.lessonAttendanceTabPage.Controls.Add(this.groupComboBox_tab2);
            this.lessonAttendanceTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessonAttendanceTabPage.HorizontalScrollbarBarColor = true;
            this.lessonAttendanceTabPage.Location = new System.Drawing.Point(4, 39);
            this.lessonAttendanceTabPage.Name = "lessonAttendanceTabPage";
            this.lessonAttendanceTabPage.Size = new System.Drawing.Size(933, 480);
            this.lessonAttendanceTabPage.TabIndex = 1;
            this.lessonAttendanceTabPage.Text = "  Lesson Attendance";
            this.lessonAttendanceTabPage.VerticalScrollbarBarColor = true;
            this.lessonAttendanceTabPage.VerticalScrollbarSize = 12;
            // 
            // lessonLabel
            // 
            this.lessonLabel.AutoSize = true;
            this.lessonLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lessonLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLabel.Location = new System.Drawing.Point(193, 9);
            this.lessonLabel.Name = "lessonLabel";
            this.lessonLabel.Size = new System.Drawing.Size(71, 22);
            this.lessonLabel.TabIndex = 9;
            this.lessonLabel.Text = "Lesson:";
            // 
            // lessonComboBox_tab2
            // 
            this.lessonComboBox_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonComboBox_tab2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonComboBox_tab2.FormattingEnabled = true;
            this.lessonComboBox_tab2.Location = new System.Drawing.Point(193, 34);
            this.lessonComboBox_tab2.Name = "lessonComboBox_tab2";
            this.lessonComboBox_tab2.Size = new System.Drawing.Size(199, 28);
            this.lessonComboBox_tab2.TabIndex = 8;
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupsLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsLabel.Location = new System.Drawing.Point(-1, 9);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(67, 22);
            this.groupsLabel.TabIndex = 7;
            this.groupsLabel.Text = "Group:";
            // 
            // lessonAttendanceGridView
            // 
            this.lessonAttendanceGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lessonAttendanceGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lessonAttendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessonAttendanceGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lessonAttendanceGridView.Location = new System.Drawing.Point(0, 67);
            this.lessonAttendanceGridView.Name = "lessonAttendanceGridView";
            this.lessonAttendanceGridView.RowHeadersWidth = 51;
            this.lessonAttendanceGridView.RowTemplate.Height = 24;
            this.lessonAttendanceGridView.Size = new System.Drawing.Size(933, 413);
            this.lessonAttendanceGridView.TabIndex = 6;
            this.lessonAttendanceGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lessonAttendanceGridView_CellMouseClick);
            // 
            // groupComboBox_tab2
            // 
            this.groupComboBox_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox_tab2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox_tab2.FormattingEnabled = true;
            this.groupComboBox_tab2.Location = new System.Drawing.Point(0, 34);
            this.groupComboBox_tab2.Name = "groupComboBox_tab2";
            this.groupComboBox_tab2.Size = new System.Drawing.Size(187, 28);
            this.groupComboBox_tab2.TabIndex = 5;
            this.groupComboBox_tab2.SelectedIndexChanged += new System.EventHandler(this.groups2ComboBox_SelectedIndexChanged);
            // 
            // addTeacherLinkLabel
            // 
            this.addTeacherLinkLabel.AutoSize = true;
            this.addTeacherLinkLabel.Location = new System.Drawing.Point(706, 40);
            this.addTeacherLinkLabel.Name = "addTeacherLinkLabel";
            this.addTeacherLinkLabel.Size = new System.Drawing.Size(85, 17);
            this.addTeacherLinkLabel.TabIndex = 1;
            this.addTeacherLinkLabel.TabStop = true;
            this.addTeacherLinkLabel.Text = "Add teacher";
            this.addTeacherLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addTeacherLinkLabel_LinkClicked);
            // 
            // addStudentLinkLabel
            // 
            this.addStudentLinkLabel.AutoSize = true;
            this.addStudentLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addStudentLinkLabel.Location = new System.Drawing.Point(877, 40);
            this.addStudentLinkLabel.Name = "addStudentLinkLabel";
            this.addStudentLinkLabel.Size = new System.Drawing.Size(86, 19);
            this.addStudentLinkLabel.TabIndex = 2;
            this.addStudentLinkLabel.TabStop = true;
            this.addStudentLinkLabel.Text = "Add student";
            this.addStudentLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addStudentLinkLabel_LinkClicked);
            // 
            // addGroupLinkLabel
            // 
            this.addGroupLinkLabel.AutoSize = true;
            this.addGroupLinkLabel.Location = new System.Drawing.Point(797, 40);
            this.addGroupLinkLabel.Name = "addGroupLinkLabel";
            this.addGroupLinkLabel.Size = new System.Drawing.Size(74, 17);
            this.addGroupLinkLabel.TabIndex = 3;
            this.addGroupLinkLabel.TabStop = true;
            this.addGroupLinkLabel.Text = "Add group";
            this.addGroupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addGroupLinkLabel_LinkClicked);
            // 
            // addLessonLinkLabel
            // 
            this.addLessonLinkLabel.AutoSize = true;
            this.addLessonLinkLabel.Location = new System.Drawing.Point(615, 40);
            this.addLessonLinkLabel.Name = "addLessonLinkLabel";
            this.addLessonLinkLabel.Size = new System.Drawing.Size(78, 17);
            this.addLessonLinkLabel.TabIndex = 4;
            this.addLessonLinkLabel.TabStop = true;
            this.addLessonLinkLabel.Text = "Add lesson";
            this.addLessonLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addLessonLinkLabel_LinkClicked);
            // 
            // saveButton_tab2
            // 
            this.saveButton_tab2.Location = new System.Drawing.Point(776, 32);
            this.saveButton_tab2.Name = "saveButton_tab2";
            this.saveButton_tab2.Size = new System.Drawing.Size(154, 30);
            this.saveButton_tab2.TabIndex = 10;
            this.saveButton_tab2.Text = "Save";
            this.saveButton_tab2.UseVisualStyleBackColor = true;
            this.saveButton_tab2.Click += new System.EventHandler(this.saveButton_tab2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 603);
            this.Controls.Add(this.addLessonLinkLabel);
            this.Controls.Add(this.addGroupLinkLabel);
            this.Controls.Add(this.addStudentLinkLabel);
            this.Controls.Add(this.addTeacherLinkLabel);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "Attendance system";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.attendanceTabPage.ResumeLayout(false);
            this.attendanceTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).EndInit();
            this.lessonAttendanceTabPage.ResumeLayout(false);
            this.lessonAttendanceTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage attendanceTabPage;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox groupComboBox_tab1;
        private System.Windows.Forms.DataGridView attendanceGridView;
        private System.Windows.Forms.Label chooseDataLabel;
        private System.Windows.Forms.Label chooseGroupLabel;
        private MetroFramework.Controls.MetroTabPage lessonAttendanceTabPage;
        private System.Windows.Forms.Label lessonLabel;
        private System.Windows.Forms.ComboBox lessonComboBox_tab2;
        private System.Windows.Forms.Label groupsLabel;
        private System.Windows.Forms.DataGridView lessonAttendanceGridView;
        private System.Windows.Forms.ComboBox groupComboBox_tab2;
        private System.Windows.Forms.LinkLabel addTeacherLinkLabel;
        private System.Windows.Forms.LinkLabel addStudentLinkLabel;
        private System.Windows.Forms.LinkLabel addGroupLinkLabel;
        private System.Windows.Forms.LinkLabel addLessonLinkLabel;
        private System.Windows.Forms.Label chooseLessonLabel;
        private System.Windows.Forms.ComboBox lessonComboBox_tab1;
        private System.Windows.Forms.Button saveButton_tab2;
    }
}

