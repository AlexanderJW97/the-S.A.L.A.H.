namespace theSALAH
{
    partial class login
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.usernameTxtBx = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(131, 495);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(214, 51);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.Location = new System.Drawing.Point(351, 431);
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.Size = new System.Drawing.Size(434, 26);
            this.passwordTxtBx.TabIndex = 1;
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(351, 495);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(214, 51);
            this.newUserBtn.TabIndex = 2;
            this.newUserBtn.Text = "New user";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(571, 495);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(214, 51);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Location = new System.Drawing.Point(351, 399);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(434, 26);
            this.usernameTxtBx.TabIndex = 4;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(258, 402);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(87, 20);
            this.usernameLbl.TabIndex = 5;
            this.usernameLbl.Text = "Username:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(258, 434);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(82, 20);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password:";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 861);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameTxtBx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.passwordTxtBx);
            this.Controls.Add(this.loginBtn);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox usernameTxtBx;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
    }
}