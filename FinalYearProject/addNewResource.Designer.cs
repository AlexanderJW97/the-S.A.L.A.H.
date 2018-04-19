namespace theSALAH
{
    partial class addNewResource
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
            this.deadtxtbx = new System.Windows.Forms.Label();
            this.resourceNotesTxtBx = new System.Windows.Forms.RichTextBox();
            this.updateGroupComboBoxBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseLocationComboBox = new System.Windows.Forms.ComboBox();
            this.cancelNewResourceBtn = new System.Windows.Forms.Button();
            this.addNewResourceBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resourceNameTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // deadtxtbx
            // 
            this.deadtxtbx.AutoSize = true;
            this.deadtxtbx.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.deadtxtbx.Location = new System.Drawing.Point(14, 186);
            this.deadtxtbx.Name = "deadtxtbx";
            this.deadtxtbx.Size = new System.Drawing.Size(124, 19);
            this.deadtxtbx.TabIndex = 121;
            this.deadtxtbx.Text = "Resource Notes:";
            // 
            // resourceNotesTxtBx
            // 
            this.resourceNotesTxtBx.Location = new System.Drawing.Point(227, 182);
            this.resourceNotesTxtBx.Name = "resourceNotesTxtBx";
            this.resourceNotesTxtBx.Size = new System.Drawing.Size(298, 174);
            this.resourceNotesTxtBx.TabIndex = 106;
            this.resourceNotesTxtBx.Text = "Enter any relevant notes about your resource here.";
            // 
            // updateGroupComboBoxBtn
            // 
            this.updateGroupComboBoxBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.updateGroupComboBoxBtn.Location = new System.Drawing.Point(227, 103);
            this.updateGroupComboBoxBtn.Name = "updateGroupComboBoxBtn";
            this.updateGroupComboBoxBtn.Size = new System.Drawing.Size(298, 41);
            this.updateGroupComboBoxBtn.TabIndex = 105;
            this.updateGroupComboBoxBtn.Text = "Update Location List";
            this.updateGroupComboBoxBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 104;
            this.label1.Text = "Location of the Resource:";
            // 
            // chooseLocationComboBox
            // 
            this.chooseLocationComboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.chooseLocationComboBox.FormattingEnabled = true;
            this.chooseLocationComboBox.Location = new System.Drawing.Point(227, 70);
            this.chooseLocationComboBox.Name = "chooseLocationComboBox";
            this.chooseLocationComboBox.Size = new System.Drawing.Size(298, 27);
            this.chooseLocationComboBox.TabIndex = 103;
            this.chooseLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseLocationComboBox_SelectedIndexChanged);
            // 
            // cancelNewResourceBtn
            // 
            this.cancelNewResourceBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.cancelNewResourceBtn.Location = new System.Drawing.Point(752, 327);
            this.cancelNewResourceBtn.Name = "cancelNewResourceBtn";
            this.cancelNewResourceBtn.Size = new System.Drawing.Size(117, 53);
            this.cancelNewResourceBtn.TabIndex = 102;
            this.cancelNewResourceBtn.Text = "Cancel";
            this.cancelNewResourceBtn.UseVisualStyleBackColor = true;
            this.cancelNewResourceBtn.Click += new System.EventHandler(this.cancelNewResourceBtn_Click);
            // 
            // addNewResourceBtn
            // 
            this.addNewResourceBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.addNewResourceBtn.Location = new System.Drawing.Point(875, 327);
            this.addNewResourceBtn.Name = "addNewResourceBtn";
            this.addNewResourceBtn.Size = new System.Drawing.Size(117, 53);
            this.addNewResourceBtn.TabIndex = 101;
            this.addNewResourceBtn.Text = "OK";
            this.addNewResourceBtn.UseVisualStyleBackColor = true;
            this.addNewResourceBtn.Click += new System.EventHandler(this.addNewResourceBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(11, 15);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(193, 36);
            this.titleLbl.TabIndex = 100;
            this.titleLbl.Text = "Add Resource";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "Name of Resource:";
            // 
            // resourceNameTxtBx
            // 
            this.resourceNameTxtBx.Location = new System.Drawing.Point(227, 150);
            this.resourceNameTxtBx.Name = "resourceNameTxtBx";
            this.resourceNameTxtBx.Size = new System.Drawing.Size(298, 26);
            this.resourceNameTxtBx.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.label2.Location = new System.Drawing.Point(13, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 122;
            this.label2.Text = "Quantity of Resource:";
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(227, 363);
            this.quantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(298, 26);
            this.quantityUpDown.TabIndex = 124;
            this.quantityUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addNewResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 394);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deadtxtbx);
            this.Controls.Add(this.resourceNameTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resourceNotesTxtBx);
            this.Controls.Add(this.updateGroupComboBoxBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseLocationComboBox);
            this.Controls.Add(this.cancelNewResourceBtn);
            this.Controls.Add(this.addNewResourceBtn);
            this.Controls.Add(this.titleLbl);
            this.Name = "addNewResource";
            this.Text = "Add New Resource";
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deadtxtbx;
        private System.Windows.Forms.RichTextBox resourceNotesTxtBx;
        private System.Windows.Forms.Button updateGroupComboBoxBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseLocationComboBox;
        private System.Windows.Forms.Button cancelNewResourceBtn;
        private System.Windows.Forms.Button addNewResourceBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resourceNameTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
    }
}