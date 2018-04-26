namespace theSALAH
{
    partial class registerScreen
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
            this.updateMeetingListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.meetingsChooseGroupCmbBx = new System.Windows.Forms.ComboBox();
            this.discardChangesBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.registerCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.meetingNotesRTxtBx = new System.Windows.Forms.RichTextBox();
            this.meetingTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateMeetingListBtn
            // 
            this.updateMeetingListBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.updateMeetingListBtn.Location = new System.Drawing.Point(245, 21);
            this.updateMeetingListBtn.Name = "updateMeetingListBtn";
            this.updateMeetingListBtn.Size = new System.Drawing.Size(208, 44);
            this.updateMeetingListBtn.TabIndex = 15;
            this.updateMeetingListBtn.Text = "Update Meeting List";
            this.updateMeetingListBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Group\'s Meetings To View";
            // 
            // meetingsChooseGroupCmbBx
            // 
            this.meetingsChooseGroupCmbBx.FormattingEnabled = true;
            this.meetingsChooseGroupCmbBx.Location = new System.Drawing.Point(12, 31);
            this.meetingsChooseGroupCmbBx.Name = "meetingsChooseGroupCmbBx";
            this.meetingsChooseGroupCmbBx.Size = new System.Drawing.Size(227, 27);
            this.meetingsChooseGroupCmbBx.TabIndex = 9;
            this.meetingsChooseGroupCmbBx.SelectedIndexChanged += new System.EventHandler(this.meetingsChooseGroupCmbBx_SelectedIndexChanged);
            // 
            // discardChangesBtn
            // 
            this.discardChangesBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.discardChangesBtn.Location = new System.Drawing.Point(727, 619);
            this.discardChangesBtn.Name = "discardChangesBtn";
            this.discardChangesBtn.Size = new System.Drawing.Size(140, 50);
            this.discardChangesBtn.TabIndex = 64;
            this.discardChangesBtn.Text = "Discard Changes";
            this.discardChangesBtn.UseVisualStyleBackColor = true;
            this.discardChangesBtn.Click += new System.EventHandler(this.discardChangesBtn_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.saveChangesBtn.Location = new System.Drawing.Point(873, 619);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(117, 50);
            this.saveChangesBtn.TabIndex = 63;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // registerCheckedListBox1
            // 
            this.registerCheckedListBox1.FormattingEnabled = true;
            this.registerCheckedListBox1.Location = new System.Drawing.Point(549, 42);
            this.registerCheckedListBox1.Name = "registerCheckedListBox1";
            this.registerCheckedListBox1.Size = new System.Drawing.Size(441, 571);
            this.registerCheckedListBox1.TabIndex = 65;
            // 
            // meetingNotesRTxtBx
            // 
            this.meetingNotesRTxtBx.Location = new System.Drawing.Point(12, 126);
            this.meetingNotesRTxtBx.Name = "meetingNotesRTxtBx";
            this.meetingNotesRTxtBx.Size = new System.Drawing.Size(531, 487);
            this.meetingNotesRTxtBx.TabIndex = 66;
            this.meetingNotesRTxtBx.Text = "";
            // 
            // meetingTitle
            // 
            this.meetingTitle.AutoSize = true;
            this.meetingTitle.Location = new System.Drawing.Point(8, 86);
            this.meetingTitle.Name = "meetingTitle";
            this.meetingTitle.Size = new System.Drawing.Size(95, 19);
            this.meetingTitle.TabIndex = 67;
            this.meetingTitle.Text = "meetingTitle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Check all scouts who attended the selected meeting.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Description";
            // 
            // registerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meetingTitle);
            this.Controls.Add(this.meetingNotesRTxtBx);
            this.Controls.Add(this.registerCheckedListBox1);
            this.Controls.Add(this.discardChangesBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.updateMeetingListBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meetingsChooseGroupCmbBx);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.Name = "registerScreen";
            this.Text = "Register Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateMeetingListBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox meetingsChooseGroupCmbBx;
        private System.Windows.Forms.Button discardChangesBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.CheckedListBox registerCheckedListBox1;
        private System.Windows.Forms.RichTextBox meetingNotesRTxtBx;
        private System.Windows.Forms.Label meetingTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}