namespace theSALAH
{
    partial class editResource
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
            this.label2 = new System.Windows.Forms.Label();
            this.deadtxtbx = new System.Windows.Forms.Label();
            this.resourceNameTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resourceNotesTxtBx = new System.Windows.Forms.RichTextBox();
            this.updateGroupComboBoxBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseLocationComboBox = new System.Windows.Forms.ComboBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteLocationBtn = new System.Windows.Forms.Button();
            this.discardChangesBtn = new System.Windows.Forms.Button();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label2.Location = new System.Drawing.Point(13, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 134;
            this.label2.Text = "Quantity of Resource:";
            // 
            // deadtxtbx
            // 
            this.deadtxtbx.AutoSize = true;
            this.deadtxtbx.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.deadtxtbx.Location = new System.Drawing.Point(14, 182);
            this.deadtxtbx.Name = "deadtxtbx";
            this.deadtxtbx.Size = new System.Drawing.Size(124, 19);
            this.deadtxtbx.TabIndex = 133;
            this.deadtxtbx.Text = "Resource Notes:";
            // 
            // resourceNameTxtBx
            // 
            this.resourceNameTxtBx.Location = new System.Drawing.Point(227, 146);
            this.resourceNameTxtBx.Name = "resourceNameTxtBx";
            this.resourceNameTxtBx.Size = new System.Drawing.Size(298, 26);
            this.resourceNameTxtBx.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 131;
            this.label3.Text = "Name of Resource:";
            // 
            // resourceNotesTxtBx
            // 
            this.resourceNotesTxtBx.Location = new System.Drawing.Point(227, 178);
            this.resourceNotesTxtBx.Name = "resourceNotesTxtBx";
            this.resourceNotesTxtBx.Size = new System.Drawing.Size(298, 174);
            this.resourceNotesTxtBx.TabIndex = 130;
            this.resourceNotesTxtBx.Text = "Enter any useful notes concerning the resource here.";
            // 
            // updateGroupComboBoxBtn
            // 
            this.updateGroupComboBoxBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.updateGroupComboBoxBtn.Location = new System.Drawing.Point(227, 99);
            this.updateGroupComboBoxBtn.Name = "updateGroupComboBoxBtn";
            this.updateGroupComboBoxBtn.Size = new System.Drawing.Size(298, 41);
            this.updateGroupComboBoxBtn.TabIndex = 129;
            this.updateGroupComboBoxBtn.Text = "Update Location List";
            this.updateGroupComboBoxBtn.UseVisualStyleBackColor = true;
            this.updateGroupComboBoxBtn.Click += new System.EventHandler(this.updateGroupComboBoxBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 128;
            this.label1.Text = "Location of the Resource:";
            // 
            // chooseLocationComboBox
            // 
            this.chooseLocationComboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.chooseLocationComboBox.FormattingEnabled = true;
            this.chooseLocationComboBox.Location = new System.Drawing.Point(227, 66);
            this.chooseLocationComboBox.Name = "chooseLocationComboBox";
            this.chooseLocationComboBox.Size = new System.Drawing.Size(298, 27);
            this.chooseLocationComboBox.TabIndex = 127;
            this.chooseLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseLocationComboBox_SelectedIndexChanged);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(11, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(193, 36);
            this.titleLbl.TabIndex = 124;
            this.titleLbl.Text = "Edit Resource";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.saveBtn.Location = new System.Drawing.Point(859, 331);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(131, 53);
            this.saveBtn.TabIndex = 138;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteLocationBtn
            // 
            this.deleteLocationBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.deleteLocationBtn.Location = new System.Drawing.Point(722, 331);
            this.deleteLocationBtn.Name = "deleteLocationBtn";
            this.deleteLocationBtn.Size = new System.Drawing.Size(131, 53);
            this.deleteLocationBtn.TabIndex = 137;
            this.deleteLocationBtn.Text = "Delete Location";
            this.deleteLocationBtn.UseVisualStyleBackColor = true;
            this.deleteLocationBtn.Click += new System.EventHandler(this.deleteLocationBtn_Click);
            // 
            // discardChangesBtn
            // 
            this.discardChangesBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.discardChangesBtn.Location = new System.Drawing.Point(585, 331);
            this.discardChangesBtn.Name = "discardChangesBtn";
            this.discardChangesBtn.Size = new System.Drawing.Size(131, 53);
            this.discardChangesBtn.TabIndex = 136;
            this.discardChangesBtn.Text = "Discard Changes";
            this.discardChangesBtn.UseVisualStyleBackColor = true;
            this.discardChangesBtn.Click += new System.EventHandler(this.discardChangesBtn_Click);
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(227, 359);
            this.quantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(298, 26);
            this.quantityUpDown.TabIndex = 139;
            this.quantityUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // editResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 394);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteLocationBtn);
            this.Controls.Add(this.discardChangesBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deadtxtbx);
            this.Controls.Add(this.resourceNameTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resourceNotesTxtBx);
            this.Controls.Add(this.updateGroupComboBoxBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseLocationComboBox);
            this.Controls.Add(this.titleLbl);
            this.Name = "editResource";
            this.Text = "Edit Resource";
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label deadtxtbx;
        private System.Windows.Forms.TextBox resourceNameTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox resourceNotesTxtBx;
        private System.Windows.Forms.Button updateGroupComboBoxBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseLocationComboBox;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteLocationBtn;
        private System.Windows.Forms.Button discardChangesBtn;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
    }
}