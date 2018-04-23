namespace theSALAH
{
    partial class attendanceScreen
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
            this.meetingsChooseGroupCmbBx = new System.Windows.Forms.ComboBox();
            this.attendanceBtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            this.cancelNewGroupBtn = new System.Windows.Forms.Button();
            this.editGroupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.button2.Location = new System.Drawing.Point(245, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update Group List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Group\'s Meetings To View";
            // 
            // meetingsChooseGroupCmbBx
            // 
            this.meetingsChooseGroupCmbBx.FormattingEnabled = true;
            this.meetingsChooseGroupCmbBx.Location = new System.Drawing.Point(12, 32);
            this.meetingsChooseGroupCmbBx.Name = "meetingsChooseGroupCmbBx";
            this.meetingsChooseGroupCmbBx.Size = new System.Drawing.Size(227, 28);
            this.meetingsChooseGroupCmbBx.TabIndex = 9;
            // 
            // attendanceBtn
            // 
            this.attendanceBtn.Location = new System.Drawing.Point(669, 75);
            this.attendanceBtn.Name = "attendanceBtn";
            this.attendanceBtn.Size = new System.Drawing.Size(305, 49);
            this.attendanceBtn.TabIndex = 17;
            this.attendanceBtn.Text = "Complete Register For Meeting";
            this.attendanceBtn.UseVisualStyleBackColor = true;
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(669, 130);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(305, 49);
            this.statsBtn.TabIndex = 18;
            this.statsBtn.Text = "Get group attendance statistics";
            this.statsBtn.UseVisualStyleBackColor = true;
            // 
            // cancelNewGroupBtn
            // 
            this.cancelNewGroupBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.cancelNewGroupBtn.Location = new System.Drawing.Point(727, 647);
            this.cancelNewGroupBtn.Name = "cancelNewGroupBtn";
            this.cancelNewGroupBtn.Size = new System.Drawing.Size(140, 53);
            this.cancelNewGroupBtn.TabIndex = 64;
            this.cancelNewGroupBtn.Text = "Discard Changes";
            this.cancelNewGroupBtn.UseVisualStyleBackColor = true;
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.editGroupBtn.Location = new System.Drawing.Point(873, 647);
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.Size = new System.Drawing.Size(117, 53);
            this.editGroupBtn.TabIndex = 63;
            this.editGroupBtn.Text = "Save Changes";
            this.editGroupBtn.UseVisualStyleBackColor = true;
            // 
            // attendanceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.cancelNewGroupBtn);
            this.Controls.Add(this.editGroupBtn);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.attendanceBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meetingsChooseGroupCmbBx);
            this.Name = "attendanceScreen";
            this.Text = "Attendance Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox meetingsChooseGroupCmbBx;
        private System.Windows.Forms.Button attendanceBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button cancelNewGroupBtn;
        private System.Windows.Forms.Button editGroupBtn;
    }
}