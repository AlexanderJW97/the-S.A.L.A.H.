namespace theSALAH
{
    partial class addNewMeeting
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
            this.cancelNewGroupBtn = new System.Windows.Forms.Button();
            this.addNewGroupBtn = new System.Windows.Forms.Button();
            this.meetingPlaceTxtBx = new System.Windows.Forms.TextBox();
            this.meetingPlaceLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.updateGroupComboBoxBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseGroupMeetingComboBox = new System.Windows.Forms.ComboBox();
            this.meetingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfMeetingLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meetingDescTxtBx = new System.Windows.Forms.RichTextBox();
            this.meetingTitleTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelNewGroupBtn
            // 
            this.cancelNewGroupBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.cancelNewGroupBtn.Location = new System.Drawing.Point(548, 385);
            this.cancelNewGroupBtn.Name = "cancelNewGroupBtn";
            this.cancelNewGroupBtn.Size = new System.Drawing.Size(117, 53);
            this.cancelNewGroupBtn.TabIndex = 61;
            this.cancelNewGroupBtn.Text = "Cancel";
            this.cancelNewGroupBtn.UseVisualStyleBackColor = true;
            this.cancelNewGroupBtn.Click += new System.EventHandler(this.cancelNewGroupBtn_Click);
            // 
            // addNewGroupBtn
            // 
            this.addNewGroupBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.addNewGroupBtn.Location = new System.Drawing.Point(671, 385);
            this.addNewGroupBtn.Name = "addNewGroupBtn";
            this.addNewGroupBtn.Size = new System.Drawing.Size(117, 53);
            this.addNewGroupBtn.TabIndex = 60;
            this.addNewGroupBtn.Text = "OK";
            this.addNewGroupBtn.UseVisualStyleBackColor = true;
            this.addNewGroupBtn.Click += new System.EventHandler(this.addNewMeetingBtn_Click);
            // 
            // meetingPlaceTxtBx
            // 
            this.meetingPlaceTxtBx.Location = new System.Drawing.Point(222, 176);
            this.meetingPlaceTxtBx.Name = "meetingPlaceTxtBx";
            this.meetingPlaceTxtBx.Size = new System.Drawing.Size(298, 26);
            this.meetingPlaceTxtBx.TabIndex = 59;
            // 
            // meetingPlaceLbl
            // 
            this.meetingPlaceLbl.AutoSize = true;
            this.meetingPlaceLbl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.meetingPlaceLbl.Location = new System.Drawing.Point(14, 180);
            this.meetingPlaceLbl.Name = "meetingPlaceLbl";
            this.meetingPlaceLbl.Size = new System.Drawing.Size(113, 19);
            this.meetingPlaceLbl.TabIndex = 55;
            this.meetingPlaceLbl.Text = "Meeting Place:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(6, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(223, 36);
            this.titleLbl.TabIndex = 53;
            this.titleLbl.Text = "Meeting Planner";
            // 
            // updateGroupComboBoxBtn
            // 
            this.updateGroupComboBoxBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.updateGroupComboBoxBtn.Location = new System.Drawing.Point(222, 97);
            this.updateGroupComboBoxBtn.Name = "updateGroupComboBoxBtn";
            this.updateGroupComboBoxBtn.Size = new System.Drawing.Size(298, 41);
            this.updateGroupComboBoxBtn.TabIndex = 64;
            this.updateGroupComboBoxBtn.Text = "Update group list";
            this.updateGroupComboBoxBtn.UseVisualStyleBackColor = true;
            this.updateGroupComboBoxBtn.Click += new System.EventHandler(this.updateGroupComboBoxBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "Group:";
            // 
            // chooseGroupMeetingComboBox
            // 
            this.chooseGroupMeetingComboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.chooseGroupMeetingComboBox.FormattingEnabled = true;
            this.chooseGroupMeetingComboBox.Location = new System.Drawing.Point(222, 64);
            this.chooseGroupMeetingComboBox.Name = "chooseGroupMeetingComboBox";
            this.chooseGroupMeetingComboBox.Size = new System.Drawing.Size(298, 27);
            this.chooseGroupMeetingComboBox.TabIndex = 62;
            this.chooseGroupMeetingComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseGroupMeetingComboBox_SelectedIndexChanged);
            // 
            // meetingDatePicker
            // 
            this.meetingDatePicker.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.meetingDatePicker.Location = new System.Drawing.Point(222, 208);
            this.meetingDatePicker.Name = "meetingDatePicker";
            this.meetingDatePicker.Size = new System.Drawing.Size(298, 26);
            this.meetingDatePicker.TabIndex = 66;
            // 
            // dateOfMeetingLbl
            // 
            this.dateOfMeetingLbl.AutoSize = true;
            this.dateOfMeetingLbl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.dateOfMeetingLbl.Location = new System.Drawing.Point(14, 208);
            this.dateOfMeetingLbl.Name = "dateOfMeetingLbl";
            this.dateOfMeetingLbl.Size = new System.Drawing.Size(126, 19);
            this.dateOfMeetingLbl.TabIndex = 65;
            this.dateOfMeetingLbl.Text = "Date of Meeting:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label2.Location = new System.Drawing.Point(14, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Meeting Description:";
            // 
            // meetingDescTxtBx
            // 
            this.meetingDescTxtBx.Location = new System.Drawing.Point(222, 240);
            this.meetingDescTxtBx.Name = "meetingDescTxtBx";
            this.meetingDescTxtBx.Size = new System.Drawing.Size(298, 198);
            this.meetingDescTxtBx.TabIndex = 68;
            this.meetingDescTxtBx.Text = "Enter a brief description for your meeting here";
            // 
            // meetingTitleTxtBx
            // 
            this.meetingTitleTxtBx.Location = new System.Drawing.Point(222, 144);
            this.meetingTitleTxtBx.Name = "meetingTitleTxtBx";
            this.meetingTitleTxtBx.Size = new System.Drawing.Size(298, 26);
            this.meetingTitleTxtBx.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label3.Location = new System.Drawing.Point(14, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Meeting Title:";
            // 
            // addNewMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.meetingTitleTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meetingDescTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meetingDatePicker);
            this.Controls.Add(this.dateOfMeetingLbl);
            this.Controls.Add(this.updateGroupComboBoxBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseGroupMeetingComboBox);
            this.Controls.Add(this.cancelNewGroupBtn);
            this.Controls.Add(this.addNewGroupBtn);
            this.Controls.Add(this.meetingPlaceTxtBx);
            this.Controls.Add(this.meetingPlaceLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "addNewMeeting";
            this.Text = "addNewMeeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelNewGroupBtn;
        private System.Windows.Forms.Button addNewGroupBtn;
        private System.Windows.Forms.TextBox meetingPlaceTxtBx;
        private System.Windows.Forms.Label meetingPlaceLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button updateGroupComboBoxBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseGroupMeetingComboBox;
        private System.Windows.Forms.DateTimePicker meetingDatePicker;
        private System.Windows.Forms.Label dateOfMeetingLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox meetingDescTxtBx;
        private System.Windows.Forms.TextBox meetingTitleTxtBx;
        private System.Windows.Forms.Label label3;
    }
}