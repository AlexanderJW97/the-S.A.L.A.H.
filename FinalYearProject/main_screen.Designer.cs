using System;

namespace theSALAH
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.welcome_text_lbl = new System.Windows.Forms.Label();
            this.log_out_btn = new System.Windows.Forms.Button();
            this.home_screen_time_lbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editGroupBtn = new System.Windows.Forms.Button();
            this.displayScoutsDGV = new System.Windows.Forms.DataGridView();
            this.updateComboBoxBtn = new System.Windows.Forms.Button();
            this.chooseGroupLbl = new System.Windows.Forms.Label();
            this.newYoungPersonBtn = new System.Windows.Forms.Button();
            this.groupComboBoxGroups = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.displayMeetingsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.attendanceStatsBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.planMeetingBtn = new System.Windows.Forms.Button();
            this.meetingsChooseGroupCmbBx = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.editLocationBtn = new System.Windows.Forms.Button();
            this.addLocationBtn = new System.Windows.Forms.Button();
            this.updateGroupListLocationsBtn = new System.Windows.Forms.Button();
            this.resourcesDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addResourceBtn = new System.Windows.Forms.Button();
            this.locationCmbBx = new System.Windows.Forms.ComboBox();
            this.main_screen_tmr = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayScoutsDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayMeetingsDGV)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // upcoming_meetings_lbl
            // 
            this.upcoming_meetings_lbl.AutoSize = true;
            this.upcoming_meetings_lbl.Location = new System.Drawing.Point(7, 112);
            this.upcoming_meetings_lbl.Name = "upcoming_meetings_lbl";
            this.upcoming_meetings_lbl.Size = new System.Drawing.Size(148, 19);
            this.upcoming_meetings_lbl.TabIndex = 0;
            this.upcoming_meetings_lbl.Text = "Upcoming Meetings";
            // 
            // new_group_bttn
            // 
            this.new_group_bttn.Location = new System.Drawing.Point(752, 610);
            this.new_group_bttn.Name = "new_group_bttn";
            this.new_group_bttn.Size = new System.Drawing.Size(231, 60);
            this.new_group_bttn.TabIndex = 1;
            this.new_group_bttn.Text = "Add a New Group";
            this.new_group_bttn.UseVisualStyleBackColor = true;
            this.new_group_bttn.Click += new System.EventHandler(this.new_group_bttn_Click);
            // 
            // new_scout_bttn
            // 
            this.new_scout_bttn.Location = new System.Drawing.Point(752, 544);
            this.new_scout_bttn.Name = "new_scout_bttn";
            this.new_scout_bttn.Size = new System.Drawing.Size(231, 60);
            this.new_scout_bttn.TabIndex = 2;
            this.new_scout_bttn.Text = "Add a New Scout";
            this.new_scout_bttn.UseVisualStyleBackColor = true;
            this.new_scout_bttn.Click += new System.EventHandler(this.new_scout_bttn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1024, 768);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exit_btn);
            this.tabPage1.Controls.Add(this.welcome_text_lbl);
            this.tabPage1.Controls.Add(this.log_out_btn);
            this.tabPage1.Controls.Add(this.home_screen_time_lbl);
            this.tabPage1.Controls.Add(this.upcoming_meetings_lbl);
            this.tabPage1.Controls.Add(this.new_scout_bttn);
            this.tabPage1.Controls.Add(this.new_group_bttn);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 736);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.exit_btn.Location = new System.Drawing.Point(906, 6);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(77, 31);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // welcome_text_lbl
            // 
            this.welcome_text_lbl.AutoSize = true;
            this.welcome_text_lbl.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text_lbl.Location = new System.Drawing.Point(3, 3);
            this.welcome_text_lbl.Name = "welcome_text_lbl";
            this.welcome_text_lbl.Size = new System.Drawing.Size(125, 47);
            this.welcome_text_lbl.TabIndex = 4;
            this.welcome_text_lbl.Text = "label1";
            // 
            // log_out_btn
            // 
            this.log_out_btn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.log_out_btn.Location = new System.Drawing.Point(823, 6);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(77, 31);
            this.log_out_btn.TabIndex = 5;
            this.log_out_btn.Text = "Log Out";
            this.log_out_btn.UseVisualStyleBackColor = true;
            this.log_out_btn.Click += new System.EventHandler(this.log_out_btn_Click);
            // 
            // home_screen_time_lbl
            // 
            this.home_screen_time_lbl.AutoSize = true;
            this.home_screen_time_lbl.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_screen_time_lbl.Location = new System.Drawing.Point(3, 50);
            this.home_screen_time_lbl.Name = "home_screen_time_lbl";
            this.home_screen_time_lbl.Size = new System.Drawing.Size(260, 47);
            this.home_screen_time_lbl.TabIndex = 3;
            this.home_screen_time_lbl.Text = "Current Time";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editGroupBtn);
            this.tabPage2.Controls.Add(this.displayScoutsDGV);
            this.tabPage2.Controls.Add(this.updateComboBoxBtn);
            this.tabPage2.Controls.Add(this.chooseGroupLbl);
            this.tabPage2.Controls.Add(this.newYoungPersonBtn);
            this.tabPage2.Controls.Add(this.groupComboBoxGroups);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 736);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scouts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.editGroupBtn.Location = new System.Drawing.Point(671, 153);
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.Size = new System.Drawing.Size(306, 51);
            this.editGroupBtn.TabIndex = 5;
            this.editGroupBtn.Text = "Edit Selected Group";
            this.editGroupBtn.UseVisualStyleBackColor = true;
            this.editGroupBtn.Click += new System.EventHandler(this.editGroupBtn_Click);
            // 
            // displayScoutsDGV
            // 
            this.displayScoutsDGV.AllowUserToAddRows = false;
            this.displayScoutsDGV.AllowUserToDeleteRows = false;
            this.displayScoutsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayScoutsDGV.Location = new System.Drawing.Point(15, 96);
            this.displayScoutsDGV.Name = "displayScoutsDGV";
            this.displayScoutsDGV.RowTemplate.Height = 28;
            this.displayScoutsDGV.Size = new System.Drawing.Size(650, 580);
            this.displayScoutsDGV.TabIndex = 4;
            this.displayScoutsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayScoutsDGV_CellClick);
            // 
            // updateComboBoxBtn
            // 
            this.updateComboBoxBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.updateComboBoxBtn.Location = new System.Drawing.Point(248, 43);
            this.updateComboBoxBtn.Name = "updateComboBoxBtn";
            this.updateComboBoxBtn.Size = new System.Drawing.Size(208, 46);
            this.updateComboBoxBtn.TabIndex = 3;
            this.updateComboBoxBtn.Text = "Update Group List";
            this.updateComboBoxBtn.UseVisualStyleBackColor = true;
            this.updateComboBoxBtn.Click += new System.EventHandler(this.updateComboBoxBtn_Click);
            // 
            // chooseGroupLbl
            // 
            this.chooseGroupLbl.AutoSize = true;
            this.chooseGroupLbl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.chooseGroupLbl.Location = new System.Drawing.Point(11, 31);
            this.chooseGroupLbl.Name = "chooseGroupLbl";
            this.chooseGroupLbl.Size = new System.Drawing.Size(118, 19);
            this.chooseGroupLbl.TabIndex = 2;
            this.chooseGroupLbl.Text = "Groups To View";
            // 
            // newYoungPersonBtn
            // 
            this.newYoungPersonBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.newYoungPersonBtn.Location = new System.Drawing.Point(671, 96);
            this.newYoungPersonBtn.Name = "newYoungPersonBtn";
            this.newYoungPersonBtn.Size = new System.Drawing.Size(306, 51);
            this.newYoungPersonBtn.TabIndex = 1;
            this.newYoungPersonBtn.Text = "Add a New Scout";
            this.newYoungPersonBtn.UseVisualStyleBackColor = true;
            this.newYoungPersonBtn.Click += new System.EventHandler(this.newYoungPersonBtn_Click);
            // 
            // groupComboBoxGroups
            // 
            this.groupComboBoxGroups.FormattingEnabled = true;
            this.groupComboBoxGroups.Location = new System.Drawing.Point(15, 53);
            this.groupComboBoxGroups.Name = "groupComboBoxGroups";
            this.groupComboBoxGroups.Size = new System.Drawing.Size(227, 27);
            this.groupComboBoxGroups.TabIndex = 0;
            this.groupComboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.groupComboBoxGroups_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.displayMeetingsDGV);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.attendanceStatsBtn);
            this.tabPage3.Controls.Add(this.registerBtn);
            this.tabPage3.Controls.Add(this.planMeetingBtn);
            this.tabPage3.Controls.Add(this.meetingsChooseGroupCmbBx);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1016, 736);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Meetings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.button2.Location = new System.Drawing.Point(248, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update Group List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // displayMeetingsDGV
            // 
            this.displayMeetingsDGV.AllowUserToAddRows = false;
            this.displayMeetingsDGV.AllowUserToDeleteRows = false;
            this.displayMeetingsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayMeetingsDGV.Location = new System.Drawing.Point(15, 96);
            this.displayMeetingsDGV.Name = "displayMeetingsDGV";
            this.displayMeetingsDGV.RowTemplate.Height = 28;
            this.displayMeetingsDGV.Size = new System.Drawing.Size(650, 580);
            this.displayMeetingsDGV.TabIndex = 7;
            this.displayMeetingsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayMeetingsDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Group\'s Meetings To View";
            // 
            // attendanceStatsBtn
            // 
            this.attendanceStatsBtn.Location = new System.Drawing.Point(672, 209);
            this.attendanceStatsBtn.Name = "attendanceStatsBtn";
            this.attendanceStatsBtn.Size = new System.Drawing.Size(305, 50);
            this.attendanceStatsBtn.TabIndex = 5;
            this.attendanceStatsBtn.Text = "Attendance Statistics";
            this.attendanceStatsBtn.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(671, 153);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(305, 50);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Registers";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // planMeetingBtn
            // 
            this.planMeetingBtn.Location = new System.Drawing.Point(671, 96);
            this.planMeetingBtn.Name = "planMeetingBtn";
            this.planMeetingBtn.Size = new System.Drawing.Size(306, 51);
            this.planMeetingBtn.TabIndex = 3;
            this.planMeetingBtn.Text = "Meeting Planner";
            this.planMeetingBtn.UseVisualStyleBackColor = true;
            this.planMeetingBtn.Click += new System.EventHandler(this.planMeetingBtn_Click);
            // 
            // meetingsChooseGroupCmbBx
            // 
            this.meetingsChooseGroupCmbBx.FormattingEnabled = true;
            this.meetingsChooseGroupCmbBx.Location = new System.Drawing.Point(15, 53);
            this.meetingsChooseGroupCmbBx.Name = "meetingsChooseGroupCmbBx";
            this.meetingsChooseGroupCmbBx.Size = new System.Drawing.Size(227, 27);
            this.meetingsChooseGroupCmbBx.TabIndex = 0;
            this.meetingsChooseGroupCmbBx.SelectedIndexChanged += new System.EventHandler(this.meetingsChooseGroupCmbBx_SelectedIndexChanged_1);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.editLocationBtn);
            this.tabPage5.Controls.Add(this.addLocationBtn);
            this.tabPage5.Controls.Add(this.updateGroupListLocationsBtn);
            this.tabPage5.Controls.Add(this.resourcesDGV);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.addResourceBtn);
            this.tabPage5.Controls.Add(this.locationCmbBx);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1016, 736);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Resources";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // editLocationBtn
            // 
            this.editLocationBtn.Location = new System.Drawing.Point(662, 89);
            this.editLocationBtn.Name = "editLocationBtn";
            this.editLocationBtn.Size = new System.Drawing.Size(306, 51);
            this.editLocationBtn.TabIndex = 17;
            this.editLocationBtn.Text = "Edit Selected Location";
            this.editLocationBtn.UseVisualStyleBackColor = true;
            this.editLocationBtn.Click += new System.EventHandler(this.editLocationBtn_Click);
            // 
            // addLocationBtn
            // 
            this.addLocationBtn.Location = new System.Drawing.Point(662, 146);
            this.addLocationBtn.Name = "addLocationBtn";
            this.addLocationBtn.Size = new System.Drawing.Size(306, 51);
            this.addLocationBtn.TabIndex = 16;
            this.addLocationBtn.Text = "Add a Location";
            this.addLocationBtn.UseVisualStyleBackColor = true;
            this.addLocationBtn.Click += new System.EventHandler(this.addLocationBtn_Click);
            // 
            // updateGroupListLocationsBtn
            // 
            this.updateGroupListLocationsBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.updateGroupListLocationsBtn.Location = new System.Drawing.Point(239, 36);
            this.updateGroupListLocationsBtn.Name = "updateGroupListLocationsBtn";
            this.updateGroupListLocationsBtn.Size = new System.Drawing.Size(208, 46);
            this.updateGroupListLocationsBtn.TabIndex = 15;
            this.updateGroupListLocationsBtn.Text = "Update Location List";
            this.updateGroupListLocationsBtn.UseVisualStyleBackColor = true;
            this.updateGroupListLocationsBtn.Click += new System.EventHandler(this.updateGroupListLocationsBtn_Click);
            // 
            // resourcesDGV
            // 
            this.resourcesDGV.AllowUserToAddRows = false;
            this.resourcesDGV.AllowUserToDeleteRows = false;
            this.resourcesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resourcesDGV.Location = new System.Drawing.Point(6, 89);
            this.resourcesDGV.Name = "resourcesDGV";
            this.resourcesDGV.RowTemplate.Height = 28;
            this.resourcesDGV.Size = new System.Drawing.Size(650, 580);
            this.resourcesDGV.TabIndex = 14;
            this.resourcesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resourcesDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Locations To View";
            // 
            // addResourceBtn
            // 
            this.addResourceBtn.Location = new System.Drawing.Point(662, 203);
            this.addResourceBtn.Name = "addResourceBtn";
            this.addResourceBtn.Size = new System.Drawing.Size(306, 51);
            this.addResourceBtn.TabIndex = 10;
            this.addResourceBtn.Text = "Add a Resource";
            this.addResourceBtn.UseVisualStyleBackColor = true;
            this.addResourceBtn.Click += new System.EventHandler(this.addResourceBtn_Click);
            // 
            // locationCmbBx
            // 
            this.locationCmbBx.FormattingEnabled = true;
            this.locationCmbBx.Location = new System.Drawing.Point(6, 46);
            this.locationCmbBx.Name = "locationCmbBx";
            this.locationCmbBx.Size = new System.Drawing.Size(227, 27);
            this.locationCmbBx.TabIndex = 9;
            this.locationCmbBx.SelectedIndexChanged += new System.EventHandler(this.locationCmbBx_SelectedIndexChanged);
            // 
            // main_screen_tmr
            // 
            this.main_screen_tmr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.tabControl);
            this.Name = "main_screen";
            this.Text = "The S.A.L.A.H.";
            this.Load += new System.EventHandler(this.main_screen_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayScoutsDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayMeetingsDGV)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        private void home_screen_time_lbl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private System.Windows.Forms.ComboBox groupComboBoxGroups;
        private System.Windows.Forms.Button newYoungPersonBtn;
        private System.Windows.Forms.Button attendanceStatsBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button planMeetingBtn;
        private System.Windows.Forms.ComboBox meetingsChooseGroupCmbBx;
        private System.Windows.Forms.Button updateComboBoxBtn;
        private System.Windows.Forms.Label chooseGroupLbl;
        private System.Windows.Forms.DataGridView displayScoutsDGV;
        private System.Windows.Forms.Button editGroupBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView displayMeetingsDGV;
        private System.Windows.Forms.Button updateGroupListLocationsBtn;
        private System.Windows.Forms.DataGridView resourcesDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addResourceBtn;
        private System.Windows.Forms.ComboBox locationCmbBx;
        private System.Windows.Forms.Button addLocationBtn;
        private System.Windows.Forms.Button editLocationBtn;
    }
}

