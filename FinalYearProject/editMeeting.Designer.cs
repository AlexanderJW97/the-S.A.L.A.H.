namespace theSALAH
{
    partial class editMeeting
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
            this.meetingTitleTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.meetingDescTxtBx = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.meetingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfMeetingLbl = new System.Windows.Forms.Label();
            this.updateGroupComboBoxBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseGroupMeetingComboBox = new System.Windows.Forms.ComboBox();
            this.meetingPlaceTxtBx = new System.Windows.Forms.TextBox();
            this.meetingPlaceLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.deleteMeetingBtn = new System.Windows.Forms.Button();
            this.discardChangesBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meetingTitleTxtBx
            // 
            this.meetingTitleTxtBx.Location = new System.Drawing.Point(225, 146);
            this.meetingTitleTxtBx.Name = "meetingTitleTxtBx";
            this.meetingTitleTxtBx.Size = new System.Drawing.Size(298, 26);
            this.meetingTitleTxtBx.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 83;
            this.label3.Text = "Meeting Title:";
            // 
            // meetingDescTxtBx
            // 
            this.meetingDescTxtBx.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.meetingDescTxtBx.Location = new System.Drawing.Point(225, 242);
            this.meetingDescTxtBx.Name = "meetingDescTxtBx";
            this.meetingDescTxtBx.Size = new System.Drawing.Size(298, 198);
            this.meetingDescTxtBx.TabIndex = 82;
            this.meetingDescTxtBx.Text = "Enter a brief description for your meeting here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label2.Location = new System.Drawing.Point(17, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Meeting Description:";
            // 
            // meetingDatePicker
            // 
            this.meetingDatePicker.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.meetingDatePicker.Location = new System.Drawing.Point(225, 210);
            this.meetingDatePicker.Name = "meetingDatePicker";
            this.meetingDatePicker.Size = new System.Drawing.Size(298, 26);
            this.meetingDatePicker.TabIndex = 80;
            // 
            // dateOfMeetingLbl
            // 
            this.dateOfMeetingLbl.AutoSize = true;
            this.dateOfMeetingLbl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.dateOfMeetingLbl.Location = new System.Drawing.Point(17, 210);
            this.dateOfMeetingLbl.Name = "dateOfMeetingLbl";
            this.dateOfMeetingLbl.Size = new System.Drawing.Size(126, 19);
            this.dateOfMeetingLbl.TabIndex = 79;
            this.dateOfMeetingLbl.Text = "Date of Meeting:";
            // 
            // updateGroupComboBoxBtn
            // 
            this.updateGroupComboBoxBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.updateGroupComboBoxBtn.Location = new System.Drawing.Point(225, 99);
            this.updateGroupComboBoxBtn.Name = "updateGroupComboBoxBtn";
            this.updateGroupComboBoxBtn.Size = new System.Drawing.Size(298, 41);
            this.updateGroupComboBoxBtn.TabIndex = 78;
            this.updateGroupComboBoxBtn.Text = "Update group list";
            this.updateGroupComboBoxBtn.UseVisualStyleBackColor = true;
            this.updateGroupComboBoxBtn.Click += new System.EventHandler(this.updateGroupComboBoxBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label1.Location = new System.Drawing.Point(17, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "Group:";
            // 
            // chooseGroupMeetingComboBox
            // 
            this.chooseGroupMeetingComboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.chooseGroupMeetingComboBox.FormattingEnabled = true;
            this.chooseGroupMeetingComboBox.Location = new System.Drawing.Point(225, 66);
            this.chooseGroupMeetingComboBox.Name = "chooseGroupMeetingComboBox";
            this.chooseGroupMeetingComboBox.Size = new System.Drawing.Size(298, 27);
            this.chooseGroupMeetingComboBox.TabIndex = 76;
            this.chooseGroupMeetingComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseGroupMeetingComboBox_SelectedIndexChanged);
            // 
            // meetingPlaceTxtBx
            // 
            this.meetingPlaceTxtBx.Location = new System.Drawing.Point(225, 178);
            this.meetingPlaceTxtBx.Name = "meetingPlaceTxtBx";
            this.meetingPlaceTxtBx.Size = new System.Drawing.Size(298, 26);
            this.meetingPlaceTxtBx.TabIndex = 73;
            // 
            // meetingPlaceLbl
            // 
            this.meetingPlaceLbl.AutoSize = true;
            this.meetingPlaceLbl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.meetingPlaceLbl.Location = new System.Drawing.Point(17, 182);
            this.meetingPlaceLbl.Name = "meetingPlaceLbl";
            this.meetingPlaceLbl.Size = new System.Drawing.Size(113, 19);
            this.meetingPlaceLbl.TabIndex = 72;
            this.meetingPlaceLbl.Text = "Meeting Place:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(9, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(198, 36);
            this.titleLbl.TabIndex = 71;
            this.titleLbl.Text = "Edit Meeting: ";
            // 
            // deleteMeetingBtn
            // 
            this.deleteMeetingBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.deleteMeetingBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteMeetingBtn.Location = new System.Drawing.Point(728, 647);
            this.deleteMeetingBtn.Name = "deleteMeetingBtn";
            this.deleteMeetingBtn.Size = new System.Drawing.Size(130, 53);
            this.deleteMeetingBtn.TabIndex = 87;
            this.deleteMeetingBtn.Text = "Delete Meeting";
            this.deleteMeetingBtn.UseVisualStyleBackColor = true;
            this.deleteMeetingBtn.Click += new System.EventHandler(this.deleteMeetingBtn_Click);
            // 
            // discardChangesBtn
            // 
            this.discardChangesBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.discardChangesBtn.Location = new System.Drawing.Point(592, 647);
            this.discardChangesBtn.Name = "discardChangesBtn";
            this.discardChangesBtn.Size = new System.Drawing.Size(130, 53);
            this.discardChangesBtn.TabIndex = 86;
            this.discardChangesBtn.Text = "Discard changes";
            this.discardChangesBtn.UseVisualStyleBackColor = true;
            this.discardChangesBtn.Click += new System.EventHandler(this.discardChangesBtn_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.saveChangesBtn.Location = new System.Drawing.Point(864, 647);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(130, 53);
            this.saveChangesBtn.TabIndex = 85;
            this.saveChangesBtn.Text = "Save changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // editMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.deleteMeetingBtn);
            this.Controls.Add(this.discardChangesBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.meetingTitleTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meetingDescTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meetingDatePicker);
            this.Controls.Add(this.dateOfMeetingLbl);
            this.Controls.Add(this.updateGroupComboBoxBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseGroupMeetingComboBox);
            this.Controls.Add(this.meetingPlaceTxtBx);
            this.Controls.Add(this.meetingPlaceLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "editMeeting";
            this.Text = "Edit Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox meetingTitleTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox meetingDescTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker meetingDatePicker;
        private System.Windows.Forms.Label dateOfMeetingLbl;
        private System.Windows.Forms.Button updateGroupComboBoxBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseGroupMeetingComboBox;
        private System.Windows.Forms.TextBox meetingPlaceTxtBx;
        private System.Windows.Forms.Label meetingPlaceLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button deleteMeetingBtn;
        private System.Windows.Forms.Button discardChangesBtn;
        private System.Windows.Forms.Button saveChangesBtn;
    }
}