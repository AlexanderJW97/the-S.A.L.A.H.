﻿namespace theSALAH
{
    partial class main_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.upcoming_meetings_lbl = new System.Windows.Forms.Label();
            this.new_group_bttn = new System.Windows.Forms.Button();
            this.new_scout_bttn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.welcome_text_lbl = new System.Windows.Forms.Label();
            this.home_screen_time_lbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newYoungPersonBtn = new System.Windows.Forms.Button();
            this.groupComboBoxScouts = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.attendanceStatsBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.planMeetingBtn = new System.Windows.Forms.Button();
            this.upcomingMeetingsLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupComboBoxMeetings = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.editResourcesBtn = new System.Windows.Forms.Button();
            this.editLocationsBtn = new System.Windows.Forms.Button();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.main_screen_tmr = new System.Windows.Forms.Timer(this.components);
            this.exit_btn = new System.Windows.Forms.Button();
            this.log_out_btn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // upcoming_meetings_lbl
            // 
            this.upcoming_meetings_lbl.AutoSize = true;
            this.upcoming_meetings_lbl.Location = new System.Drawing.Point(46, 311);
            this.upcoming_meetings_lbl.Name = "upcoming_meetings_lbl";
            this.upcoming_meetings_lbl.Size = new System.Drawing.Size(150, 20);
            this.upcoming_meetings_lbl.TabIndex = 0;
            this.upcoming_meetings_lbl.Text = "Upcoming Meetings";
            // 
            // new_group_bttn
            // 
            this.new_group_bttn.Location = new System.Drawing.Point(783, 534);
            this.new_group_bttn.Name = "new_group_bttn";
            this.new_group_bttn.Size = new System.Drawing.Size(231, 60);
            this.new_group_bttn.TabIndex = 1;
            this.new_group_bttn.Text = "Add a new group";
            this.new_group_bttn.UseVisualStyleBackColor = true;
            // 
            // new_scout_bttn
            // 
            this.new_scout_bttn.Location = new System.Drawing.Point(783, 458);
            this.new_scout_bttn.Name = "new_scout_bttn";
            this.new_scout_bttn.Size = new System.Drawing.Size(231, 60);
            this.new_scout_bttn.TabIndex = 2;
            this.new_scout_bttn.Text = "Add a new scout";
            this.new_scout_bttn.UseVisualStyleBackColor = true;
            this.new_scout_bttn.Click += new System.EventHandler(this.new_scout_bttn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1102, 841);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.welcome_text_lbl);
            this.tabPage1.Controls.Add(this.home_screen_time_lbl);
            this.tabPage1.Controls.Add(this.upcoming_meetings_lbl);
            this.tabPage1.Controls.Add(this.new_scout_bttn);
            this.tabPage1.Controls.Add(this.new_group_bttn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 808);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // welcome_text_lbl
            // 
            this.welcome_text_lbl.AutoSize = true;
            this.welcome_text_lbl.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text_lbl.Location = new System.Drawing.Point(963, 3);
            this.welcome_text_lbl.Name = "welcome_text_lbl";
            this.welcome_text_lbl.Size = new System.Drawing.Size(125, 47);
            this.welcome_text_lbl.TabIndex = 4;
            this.welcome_text_lbl.Text = "label1";
            // 
            // home_screen_time_lbl
            // 
            this.home_screen_time_lbl.AutoSize = true;
            this.home_screen_time_lbl.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_screen_time_lbl.Location = new System.Drawing.Point(828, 50);
            this.home_screen_time_lbl.Name = "home_screen_time_lbl";
            this.home_screen_time_lbl.Size = new System.Drawing.Size(260, 47);
            this.home_screen_time_lbl.TabIndex = 3;
            this.home_screen_time_lbl.Text = "Current Time";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newYoungPersonBtn);
            this.tabPage2.Controls.Add(this.groupComboBoxScouts);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1094, 808);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scouts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // newYoungPersonBtn
            // 
            this.newYoungPersonBtn.Location = new System.Drawing.Point(289, 53);
            this.newYoungPersonBtn.Name = "newYoungPersonBtn";
            this.newYoungPersonBtn.Size = new System.Drawing.Size(208, 45);
            this.newYoungPersonBtn.TabIndex = 1;
            this.newYoungPersonBtn.Text = "Add new Young Person";
            this.newYoungPersonBtn.UseVisualStyleBackColor = true;
            // 
            // groupComboBoxScouts
            // 
            this.groupComboBoxScouts.FormattingEnabled = true;
            this.groupComboBoxScouts.Location = new System.Drawing.Point(15, 53);
            this.groupComboBoxScouts.Name = "groupComboBoxScouts";
            this.groupComboBoxScouts.Size = new System.Drawing.Size(227, 28);
            this.groupComboBoxScouts.TabIndex = 0;
            this.groupComboBoxScouts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.attendanceStatsBtn);
            this.tabPage3.Controls.Add(this.registerBtn);
            this.tabPage3.Controls.Add(this.planMeetingBtn);
            this.tabPage3.Controls.Add(this.upcomingMeetingsLbl);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.groupComboBoxMeetings);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1094, 808);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Meetings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // attendanceStatsBtn
            // 
            this.attendanceStatsBtn.Location = new System.Drawing.Point(635, 265);
            this.attendanceStatsBtn.Name = "attendanceStatsBtn";
            this.attendanceStatsBtn.Size = new System.Drawing.Size(305, 50);
            this.attendanceStatsBtn.TabIndex = 5;
            this.attendanceStatsBtn.Text = "Attendance Statistics";
            this.attendanceStatsBtn.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(635, 209);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(305, 50);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Registers";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // planMeetingBtn
            // 
            this.planMeetingBtn.Location = new System.Drawing.Point(635, 152);
            this.planMeetingBtn.Name = "planMeetingBtn";
            this.planMeetingBtn.Size = new System.Drawing.Size(306, 51);
            this.planMeetingBtn.TabIndex = 3;
            this.planMeetingBtn.Text = "Meeting Planner";
            this.planMeetingBtn.UseVisualStyleBackColor = true;
            // 
            // upcomingMeetingsLbl
            // 
            this.upcomingMeetingsLbl.AutoSize = true;
            this.upcomingMeetingsLbl.Location = new System.Drawing.Point(21, 113);
            this.upcomingMeetingsLbl.Name = "upcomingMeetingsLbl";
            this.upcomingMeetingsLbl.Size = new System.Drawing.Size(150, 20);
            this.upcomingMeetingsLbl.TabIndex = 2;
            this.upcomingMeetingsLbl.Text = "Upcoming Meetings";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(21, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(592, 624);
            this.listBox1.TabIndex = 1;
            // 
            // groupComboBoxMeetings
            // 
            this.groupComboBoxMeetings.FormattingEnabled = true;
            this.groupComboBoxMeetings.Location = new System.Drawing.Point(19, 53);
            this.groupComboBoxMeetings.Name = "groupComboBoxMeetings";
            this.groupComboBoxMeetings.Size = new System.Drawing.Size(216, 28);
            this.groupComboBoxMeetings.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.editResourcesBtn);
            this.tabPage5.Controls.Add(this.editLocationsBtn);
            this.tabPage5.Controls.Add(this.locationComboBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1094, 808);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Resources";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // editResourcesBtn
            // 
            this.editResourcesBtn.Location = new System.Drawing.Point(472, 63);
            this.editResourcesBtn.Name = "editResourcesBtn";
            this.editResourcesBtn.Size = new System.Drawing.Size(222, 51);
            this.editResourcesBtn.TabIndex = 2;
            this.editResourcesBtn.Text = "Edit Resources";
            this.editResourcesBtn.UseVisualStyleBackColor = true;
            // 
            // editLocationsBtn
            // 
            this.editLocationsBtn.Location = new System.Drawing.Point(244, 63);
            this.editLocationsBtn.Name = "editLocationsBtn";
            this.editLocationsBtn.Size = new System.Drawing.Size(222, 51);
            this.editLocationsBtn.TabIndex = 1;
            this.editLocationsBtn.Text = "Edit Locations";
            this.editLocationsBtn.UseVisualStyleBackColor = true;
            // 
            // locationComboBox
            // 
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(13, 63);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(205, 28);
            this.locationComboBox.TabIndex = 0;
            // 
            // main_screen_tmr
            // 
            this.main_screen_tmr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(1194, 31);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(77, 31);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // log_out_btn
            // 
            this.log_out_btn.Location = new System.Drawing.Point(1111, 31);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(77, 31);
            this.log_out_btn.TabIndex = 5;
            this.log_out_btn.Text = "Log Out";
            this.log_out_btn.UseVisualStyleBackColor = true;
            // 
            // main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 843);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.log_out_btn);
            this.Controls.Add(this.tabControl);
            this.Name = "main_screen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_screen_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label upcoming_meetings_lbl;
        private System.Windows.Forms.Button new_group_bttn;
        private System.Windows.Forms.Button new_scout_bttn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label home_screen_time_lbl;
        private System.Windows.Forms.Timer main_screen_tmr;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button log_out_btn;
        private System.Windows.Forms.Label welcome_text_lbl;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox groupComboBoxScouts;
        private System.Windows.Forms.Button newYoungPersonBtn;
        private System.Windows.Forms.Button attendanceStatsBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button planMeetingBtn;
        private System.Windows.Forms.Label upcomingMeetingsLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox groupComboBoxMeetings;
        private System.Windows.Forms.Button editResourcesBtn;
        private System.Windows.Forms.Button editLocationsBtn;
        private System.Windows.Forms.ComboBox locationComboBox;
    }
}
