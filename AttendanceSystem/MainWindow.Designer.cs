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
            this.chooseDataLabel = new System.Windows.Forms.Label();
            this.chooseGroupLabel = new System.Windows.Forms.Label();
            this.attendanceGridView = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupsComboBox = new System.Windows.Forms.ComboBox();
            this.lessonAttendanceTabPage = new MetroFramework.Controls.MetroTabPage();
            this.lessonLabel = new System.Windows.Forms.Label();
            this.lessonsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addTeacherLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addStudentLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addGroupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addLessonLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl.SuspendLayout();
            this.attendanceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).BeginInit();
            this.lessonAttendanceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.attendanceTabPage);
            this.tabControl.Controls.Add(this.lessonAttendanceTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(941, 523);
            this.tabControl.TabIndex = 0;
            // 
            // attendanceTabPage
            // 
            this.attendanceTabPage.Controls.Add(this.chooseDataLabel);
            this.attendanceTabPage.Controls.Add(this.chooseGroupLabel);
            this.attendanceTabPage.Controls.Add(this.attendanceGridView);
            this.attendanceTabPage.Controls.Add(this.datePicker);
            this.attendanceTabPage.Controls.Add(this.groupsComboBox);
            this.attendanceTabPage.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceTabPage.HorizontalScrollbarBarColor = true;
            this.attendanceTabPage.Location = new System.Drawing.Point(4, 39);
            this.attendanceTabPage.Name = "attendanceTabPage";
            this.attendanceTabPage.Size = new System.Drawing.Size(933, 480);
            this.attendanceTabPage.TabIndex = 0;
            this.attendanceTabPage.Text = "Attendance";
            this.attendanceTabPage.VerticalScrollbarBarColor = true;
            // 
            // chooseDataLabel
            // 
            this.chooseDataLabel.AutoSize = true;
            this.chooseDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseDataLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDataLabel.Location = new System.Drawing.Point(144, 19);
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
            this.attendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceGridView.Location = new System.Drawing.Point(3, 78);
            this.attendanceGridView.Name = "attendanceGridView";
            this.attendanceGridView.RowHeadersWidth = 51;
            this.attendanceGridView.RowTemplate.Height = 24;
            this.attendanceGridView.Size = new System.Drawing.Size(930, 399);
            this.attendanceGridView.TabIndex = 4;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(148, 45);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(312, 27);
            this.datePicker.TabIndex = 3;
            // 
            // groupsComboBox
            // 
            this.groupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsComboBox.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsComboBox.FormattingEnabled = true;
            this.groupsComboBox.Location = new System.Drawing.Point(3, 44);
            this.groupsComboBox.Name = "groupsComboBox";
            this.groupsComboBox.Size = new System.Drawing.Size(139, 28);
            this.groupsComboBox.TabIndex = 2;
            // 
            // lessonAttendanceTabPage
            // 
            this.lessonAttendanceTabPage.Controls.Add(this.lessonLabel);
            this.lessonAttendanceTabPage.Controls.Add(this.lessonsComboBox);
            this.lessonAttendanceTabPage.Controls.Add(this.label1);
            this.lessonAttendanceTabPage.Controls.Add(this.dataGridView1);
            this.lessonAttendanceTabPage.Controls.Add(this.comboBox1);
            this.lessonAttendanceTabPage.HorizontalScrollbarBarColor = true;
            this.lessonAttendanceTabPage.Location = new System.Drawing.Point(4, 39);
            this.lessonAttendanceTabPage.Name = "lessonAttendanceTabPage";
            this.lessonAttendanceTabPage.Size = new System.Drawing.Size(933, 480);
            this.lessonAttendanceTabPage.TabIndex = 1;
            this.lessonAttendanceTabPage.Text = "Lesson Attendance";
            this.lessonAttendanceTabPage.VerticalScrollbarBarColor = true;
            // 
            // lessonLabel
            // 
            this.lessonLabel.AutoSize = true;
            this.lessonLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lessonLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLabel.Location = new System.Drawing.Point(153, 9);
            this.lessonLabel.Name = "lessonLabel";
            this.lessonLabel.Size = new System.Drawing.Size(71, 22);
            this.lessonLabel.TabIndex = 9;
            this.lessonLabel.Text = "Lesson:";
            // 
            // lessonsComboBox
            // 
            this.lessonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonsComboBox.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonsComboBox.FormattingEnabled = true;
            this.lessonsComboBox.Location = new System.Drawing.Point(157, 34);
            this.lessonsComboBox.Name = "lessonsComboBox";
            this.lessonsComboBox.Size = new System.Drawing.Size(139, 28);
            this.lessonsComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Group:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 416);
            this.dataGridView1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 28);
            this.comboBox1.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage attendanceTabPage;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox groupsComboBox;
        private System.Windows.Forms.DataGridView attendanceGridView;
        private System.Windows.Forms.Label chooseDataLabel;
        private System.Windows.Forms.Label chooseGroupLabel;
        private MetroFramework.Controls.MetroTabPage lessonAttendanceTabPage;
        private System.Windows.Forms.Label lessonLabel;
        private System.Windows.Forms.ComboBox lessonsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel addTeacherLinkLabel;
        private System.Windows.Forms.LinkLabel addStudentLinkLabel;
        private System.Windows.Forms.LinkLabel addGroupLinkLabel;
        private System.Windows.Forms.LinkLabel addLessonLinkLabel;
    }
}

