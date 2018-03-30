using System;

namespace theSALAH
{
    partial class new_user_screen
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
            this.usernameTxtBx = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.password1Lbl = new System.Windows.Forms.Label();
            this.password2Lbl = new System.Windows.Forms.Label();
            this.password1TxtBx = new System.Windows.Forms.TextBox();
            this.password2TxtBx = new System.Windows.Forms.TextBox();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.passwordCritLbl = new System.Windows.Forms.Label();
            this.checkPWLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Location = new System.Drawing.Point(206, 169);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(558, 26);
            this.usernameTxtBx.TabIndex = 0;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(113, 172);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(87, 20);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username:";
            // 
            // password1Lbl
            // 
            this.password1Lbl.AutoSize = true;
            this.password1Lbl.Location = new System.Drawing.Point(118, 202);
            this.password1Lbl.Name = "password1Lbl";
            this.password1Lbl.Size = new System.Drawing.Size(82, 20);
            this.password1Lbl.TabIndex = 2;
            this.password1Lbl.Text = "Password:";
            // 
            // password2Lbl
            // 
            this.password2Lbl.AutoSize = true;
            this.password2Lbl.Location = new System.Drawing.Point(60, 234);
            this.password2Lbl.Name = "password2Lbl";
            this.password2Lbl.Size = new System.Drawing.Size(140, 20);
            this.password2Lbl.TabIndex = 3;
            this.password2Lbl.Text = "Confirm password:";
            // 
            // password1TxtBx
            // 
            this.password1TxtBx.Location = new System.Drawing.Point(206, 199);
            this.password1TxtBx.Name = "password1TxtBx";
            this.password1TxtBx.Size = new System.Drawing.Size(558, 26);
            this.password1TxtBx.TabIndex = 4;
            // 
            // password2TxtBx
            // 
            this.password2TxtBx.Location = new System.Drawing.Point(206, 231);
            this.password2TxtBx.Name = "password2TxtBx";
            this.password2TxtBx.Size = new System.Drawing.Size(558, 26);
            this.password2TxtBx.TabIndex = 5;
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(360, 323);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(199, 42);
            this.newUserBtn.TabIndex = 6;
            this.newUserBtn.Text = "Create new user";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click_1);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(565, 323);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(199, 42);
            this.ReturnBtn.TabIndex = 8;
            this.ReturnBtn.Text = "Return to log in screen";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // passwordCritLbl
            // 
            this.passwordCritLbl.AutoSize = true;
            this.passwordCritLbl.Location = new System.Drawing.Point(202, 264);
            this.passwordCritLbl.Name = "passwordCritLbl";
            this.passwordCritLbl.Size = new System.Drawing.Size(548, 20);
            this.passwordCritLbl.TabIndex = 9;
            this.passwordCritLbl.Text = "Passwords must contain: 8 to 16 characters, 1 capital letter, and one number";
            // 
            // checkPWLbl
            // 
            this.checkPWLbl.AutoSize = true;
            this.checkPWLbl.Location = new System.Drawing.Point(202, 284);
            this.checkPWLbl.Name = "checkPWLbl";
            this.checkPWLbl.Size = new System.Drawing.Size(289, 20);
            this.checkPWLbl.TabIndex = 10;
            this.checkPWLbl.Text = "Make sure your password has all of this!";
            // 
            // new_user_screen
            // 
            this.ClientSize = new System.Drawing.Size(858, 498);
            this.Controls.Add(this.checkPWLbl);
            this.Controls.Add(this.passwordCritLbl);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.password2TxtBx);
            this.Controls.Add(this.password1TxtBx);
            this.Controls.Add(this.password2Lbl);
            this.Controls.Add(this.password1Lbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameTxtBx);
            this.Name = "new_user_screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        
        private System.Windows.Forms.TextBox usernameTxtBx;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label password1Lbl;
        private System.Windows.Forms.Label password2Lbl;
        private System.Windows.Forms.TextBox password1TxtBx;
        private System.Windows.Forms.TextBox password2TxtBx;
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label passwordCritLbl;
        private System.Windows.Forms.Label checkPWLbl;
    }
}