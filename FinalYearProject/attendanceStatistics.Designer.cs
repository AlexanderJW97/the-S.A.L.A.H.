namespace theSALAH
{
    partial class attendanceStatistics
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseGroupCmbBx = new System.Windows.Forms.ComboBox();
            this.avgAttendLbl = new System.Windows.Forms.Label();
            this.highestAttendanceLbl = new System.Windows.Forms.Label();
            this.lowestAttendanceLbl = new System.Windows.Forms.Label();
            this.totalNumScoutsLbl = new System.Windows.Forms.Label();
            this.totalNumMeetingsLbl = new System.Windows.Forms.Label();
            this.AvgAttValueLblAvgAttValueLbl = new System.Windows.Forms.Label();
            this.highAttenMeetingValueLbl = new System.Windows.Forms.Label();
            this.lowAttenMeetingValueLbl = new System.Windows.Forms.Label();
            this.totalNumScoutsValueLbl = new System.Windows.Forms.Label();
            this.totalNumMeetingsValueLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.button2.Location = new System.Drawing.Point(245, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update Group List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Group\'s Statistics To View";
            // 
            // chooseGroupCmbBx
            // 
            this.chooseGroupCmbBx.FormattingEnabled = true;
            this.chooseGroupCmbBx.Location = new System.Drawing.Point(12, 28);
            this.chooseGroupCmbBx.Name = "chooseGroupCmbBx";
            this.chooseGroupCmbBx.Size = new System.Drawing.Size(227, 27);
            this.chooseGroupCmbBx.TabIndex = 9;
            this.chooseGroupCmbBx.SelectedIndexChanged += new System.EventHandler(this.chooseGroupCmbBx_SelectedIndexChanged);
            // 
            // avgAttendLbl
            // 
            this.avgAttendLbl.AutoSize = true;
            this.avgAttendLbl.Location = new System.Drawing.Point(8, 81);
            this.avgAttendLbl.Name = "avgAttendLbl";
            this.avgAttendLbl.Size = new System.Drawing.Size(237, 19);
            this.avgAttendLbl.TabIndex = 12;
            this.avgAttendLbl.Text = "Average Attendance for a meeting";
            // 
            // highestAttendanceLbl
            // 
            this.highestAttendanceLbl.AutoSize = true;
            this.highestAttendanceLbl.Location = new System.Drawing.Point(8, 202);
            this.highestAttendanceLbl.Name = "highestAttendanceLbl";
            this.highestAttendanceLbl.Size = new System.Drawing.Size(182, 19);
            this.highestAttendanceLbl.TabIndex = 13;
            this.highestAttendanceLbl.Text = "Highest attended meeting";
            // 
            // lowestAttendanceLbl
            // 
            this.lowestAttendanceLbl.AutoSize = true;
            this.lowestAttendanceLbl.Location = new System.Drawing.Point(8, 172);
            this.lowestAttendanceLbl.Name = "lowestAttendanceLbl";
            this.lowestAttendanceLbl.Size = new System.Drawing.Size(179, 19);
            this.lowestAttendanceLbl.TabIndex = 14;
            this.lowestAttendanceLbl.Text = "Lowest attended meeting";
            // 
            // totalNumScoutsLbl
            // 
            this.totalNumScoutsLbl.AutoSize = true;
            this.totalNumScoutsLbl.Location = new System.Drawing.Point(8, 142);
            this.totalNumScoutsLbl.Name = "totalNumScoutsLbl";
            this.totalNumScoutsLbl.Size = new System.Drawing.Size(252, 19);
            this.totalNumScoutsLbl.TabIndex = 15;
            this.totalNumScoutsLbl.Text = "Total number of Scouts in the group";
            // 
            // totalNumMeetingsLbl
            // 
            this.totalNumMeetingsLbl.AutoSize = true;
            this.totalNumMeetingsLbl.Location = new System.Drawing.Point(8, 110);
            this.totalNumMeetingsLbl.Name = "totalNumMeetingsLbl";
            this.totalNumMeetingsLbl.Size = new System.Drawing.Size(220, 19);
            this.totalNumMeetingsLbl.TabIndex = 16;
            this.totalNumMeetingsLbl.Text = "Total Number of Meetings Run";
            // 
            // AvgAttValueLblAvgAttValueLbl
            // 
            this.AvgAttValueLblAvgAttValueLbl.AutoSize = true;
            this.AvgAttValueLblAvgAttValueLbl.Location = new System.Drawing.Point(402, 81);
            this.AvgAttValueLblAvgAttValueLbl.Name = "AvgAttValueLblAvgAttValueLbl";
            this.AvgAttValueLblAvgAttValueLbl.Size = new System.Drawing.Size(44, 19);
            this.AvgAttValueLblAvgAttValueLbl.TabIndex = 17;
            this.AvgAttValueLblAvgAttValueLbl.Text = "value";
            // 
            // highAttenMeetingValueLbl
            // 
            this.highAttenMeetingValueLbl.AutoSize = true;
            this.highAttenMeetingValueLbl.Location = new System.Drawing.Point(402, 202);
            this.highAttenMeetingValueLbl.Name = "highAttenMeetingValueLbl";
            this.highAttenMeetingValueLbl.Size = new System.Drawing.Size(44, 19);
            this.highAttenMeetingValueLbl.TabIndex = 18;
            this.highAttenMeetingValueLbl.Text = "value";
            // 
            // lowAttenMeetingValueLbl
            // 
            this.lowAttenMeetingValueLbl.AutoSize = true;
            this.lowAttenMeetingValueLbl.Location = new System.Drawing.Point(402, 172);
            this.lowAttenMeetingValueLbl.Name = "lowAttenMeetingValueLbl";
            this.lowAttenMeetingValueLbl.Size = new System.Drawing.Size(44, 19);
            this.lowAttenMeetingValueLbl.TabIndex = 19;
            this.lowAttenMeetingValueLbl.Text = "value";
            // 
            // totalNumScoutsValueLbl
            // 
            this.totalNumScoutsValueLbl.AutoSize = true;
            this.totalNumScoutsValueLbl.Location = new System.Drawing.Point(402, 142);
            this.totalNumScoutsValueLbl.Name = "totalNumScoutsValueLbl";
            this.totalNumScoutsValueLbl.Size = new System.Drawing.Size(44, 19);
            this.totalNumScoutsValueLbl.TabIndex = 20;
            this.totalNumScoutsValueLbl.Text = "value";
            // 
            // totalNumMeetingsValueLbl
            // 
            this.totalNumMeetingsValueLbl.AutoSize = true;
            this.totalNumMeetingsValueLbl.Location = new System.Drawing.Point(402, 110);
            this.totalNumMeetingsValueLbl.Name = "totalNumMeetingsValueLbl";
            this.totalNumMeetingsValueLbl.Size = new System.Drawing.Size(44, 19);
            this.totalNumMeetingsValueLbl.TabIndex = 21;
            this.totalNumMeetingsValueLbl.Text = "value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 43);
            this.button1.TabIndex = 22;
            this.button1.Text = "Return to Main Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attendanceStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalNumMeetingsValueLbl);
            this.Controls.Add(this.totalNumScoutsValueLbl);
            this.Controls.Add(this.lowAttenMeetingValueLbl);
            this.Controls.Add(this.highAttenMeetingValueLbl);
            this.Controls.Add(this.AvgAttValueLblAvgAttValueLbl);
            this.Controls.Add(this.totalNumMeetingsLbl);
            this.Controls.Add(this.totalNumScoutsLbl);
            this.Controls.Add(this.lowestAttendanceLbl);
            this.Controls.Add(this.highestAttendanceLbl);
            this.Controls.Add(this.avgAttendLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseGroupCmbBx);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.Name = "attendanceStatistics";
            this.Text = "Attendance Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseGroupCmbBx;
        private System.Windows.Forms.Label avgAttendLbl;
        private System.Windows.Forms.Label highestAttendanceLbl;
        private System.Windows.Forms.Label lowestAttendanceLbl;
        private System.Windows.Forms.Label totalNumScoutsLbl;
        private System.Windows.Forms.Label totalNumMeetingsLbl;
        private System.Windows.Forms.Label AvgAttValueLblAvgAttValueLbl;
        private System.Windows.Forms.Label highAttenMeetingValueLbl;
        private System.Windows.Forms.Label lowAttenMeetingValueLbl;
        private System.Windows.Forms.Label totalNumScoutsValueLbl;
        private System.Windows.Forms.Label totalNumMeetingsValueLbl;
        private System.Windows.Forms.Button button1;
    }
}