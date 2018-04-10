namespace theSALAH
{
    partial class addNewGroup
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
            this.groupNameTxtbx = new System.Windows.Forms.TextBox();
            this.ageGroupCBox = new System.Windows.Forms.ComboBox();
            this.ageGroupLbl = new System.Windows.Forms.Label();
            this.meetingPlaceLbl = new System.Windows.Forms.Label();
            this.groupNameLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelNewGroupBtn
            // 
            this.cancelNewGroupBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.cancelNewGroupBtn.Location = new System.Drawing.Point(221, 197);
            this.cancelNewGroupBtn.Name = "cancelNewGroupBtn";
            this.cancelNewGroupBtn.Size = new System.Drawing.Size(117, 53);
            this.cancelNewGroupBtn.TabIndex = 52;
            this.cancelNewGroupBtn.Text = "Cancel";
            this.cancelNewGroupBtn.UseVisualStyleBackColor = true;
            // 
            // addNewGroupBtn
            // 
            this.addNewGroupBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.addNewGroupBtn.Location = new System.Drawing.Point(402, 197);
            this.addNewGroupBtn.Name = "addNewGroupBtn";
            this.addNewGroupBtn.Size = new System.Drawing.Size(117, 53);
            this.addNewGroupBtn.TabIndex = 51;
            this.addNewGroupBtn.Text = "OK";
            this.addNewGroupBtn.UseVisualStyleBackColor = true;
            this.addNewGroupBtn.Click += new System.EventHandler(this.addNewScoutBtn_Click);
            // 
            // meetingPlaceTxtBx
            // 
            this.meetingPlaceTxtBx.Location = new System.Drawing.Point(221, 107);
            this.meetingPlaceTxtBx.Name = "meetingPlaceTxtBx";
            this.meetingPlaceTxtBx.Size = new System.Drawing.Size(298, 26);
            this.meetingPlaceTxtBx.TabIndex = 41;
            // 
            // groupNameTxtbx
            // 
            this.groupNameTxtbx.Location = new System.Drawing.Point(221, 75);
            this.groupNameTxtbx.Name = "groupNameTxtbx";
            this.groupNameTxtbx.Size = new System.Drawing.Size(298, 26);
            this.groupNameTxtbx.TabIndex = 40;
            // 
            // ageGroupCBox
            // 
            this.ageGroupCBox.FormattingEnabled = true;
            this.ageGroupCBox.Items.AddRange(new object[] {
            "Beaver",
            "Cub",
            "Scout",
            "Explorer",
            "Network"});
            this.ageGroupCBox.Location = new System.Drawing.Point(221, 139);
            this.ageGroupCBox.Name = "ageGroupCBox";
            this.ageGroupCBox.Size = new System.Drawing.Size(298, 28);
            this.ageGroupCBox.TabIndex = 39;
            // 
            // ageGroupLbl
            // 
            this.ageGroupLbl.AutoSize = true;
            this.ageGroupLbl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.ageGroupLbl.Location = new System.Drawing.Point(7, 147);
            this.ageGroupLbl.Name = "ageGroupLbl";
            this.ageGroupLbl.Size = new System.Drawing.Size(84, 19);
            this.ageGroupLbl.TabIndex = 38;
            this.ageGroupLbl.Text = "Age group:";
            // 
            // meetingPlaceLbl
            // 
            this.meetingPlaceLbl.AutoSize = true;
            this.meetingPlaceLbl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.meetingPlaceLbl.Location = new System.Drawing.Point(7, 113);
            this.meetingPlaceLbl.Name = "meetingPlaceLbl";
            this.meetingPlaceLbl.Size = new System.Drawing.Size(111, 19);
            this.meetingPlaceLbl.TabIndex = 36;
            this.meetingPlaceLbl.Text = "Meeting place:";
            // 
            // groupNameLbl
            // 
            this.groupNameLbl.AutoSize = true;
            this.groupNameLbl.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.groupNameLbl.Location = new System.Drawing.Point(7, 81);
            this.groupNameLbl.Name = "groupNameLbl";
            this.groupNameLbl.Size = new System.Drawing.Size(97, 19);
            this.groupNameLbl.TabIndex = 35;
            this.groupNameLbl.Text = "Group name:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(11, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(240, 36);
            this.titleLbl.TabIndex = 34;
            this.titleLbl.Text = "Add a new Group";
            // 
            // addNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.cancelNewGroupBtn);
            this.Controls.Add(this.addNewGroupBtn);
            this.Controls.Add(this.meetingPlaceTxtBx);
            this.Controls.Add(this.groupNameTxtbx);
            this.Controls.Add(this.ageGroupCBox);
            this.Controls.Add(this.ageGroupLbl);
            this.Controls.Add(this.meetingPlaceLbl);
            this.Controls.Add(this.groupNameLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "addNewGroup";
            this.Text = "addNewGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelNewGroupBtn;
        private System.Windows.Forms.Button addNewGroupBtn;
        private System.Windows.Forms.TextBox meetingPlaceTxtBx;
        private System.Windows.Forms.TextBox groupNameTxtbx;
        private System.Windows.Forms.ComboBox ageGroupCBox;
        private System.Windows.Forms.Label ageGroupLbl;
        private System.Windows.Forms.Label meetingPlaceLbl;
        private System.Windows.Forms.Label groupNameLbl;
        private System.Windows.Forms.Label titleLbl;
    }
}