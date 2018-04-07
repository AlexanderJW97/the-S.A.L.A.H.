using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace theSALAH
{
    public partial class new_user_screen : Form
    {
        public new_user_screen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// new user button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void newUserBtn_Click_1(object sender, EventArgs e)
        {
            string newUsername;

            string password = null;

            string salt = null;

            string passwordValid = passwordManager.passwordValidation(password1TxtBx.Text, password2TxtBx.Text);

            switch (passwordValid) //switch provides the user with detailed error messages when trying to create a new user
            {
                case "valid":
                    password = password1TxtBx.Text;
                    newUsername = usernameTxtBx.Text;
                    password = passwordManager.HashSaltManager.GeneratePasswordHash(password, out salt);
                    user User = new user(newUsername, password, salt);
                    MessageBox.Show("New user was created successfully.");
                    if (user.AddNewUser(user: User))
                    {
                        main_screen openMainScreen = new main_screen(User);
                        openMainScreen.Show();
                        Visible = false;
                    }
                    break;
                case "nonAlphaChar":
                    MessageBox.Show("New user could not be created: special character used in password");
                    break;
                case "nonMatch":
                    MessageBox.Show("New user could not be created: passwords did not match");
                    break;
                case "noCaps":
                    MessageBox.Show("New user could not be created: no capital letters included in password");
                    break;
                case "noNums":
                    MessageBox.Show("New user could not be created: no numbers included in password");
                    break;
                case "tooShort":
                    MessageBox.Show("New user could not be created: password incorrect length");
                    break;
            }
            
            
        }
        
        /// <summary>
        /// Adds a new user to the database
        /// </summary>
        /// <param name="user">User object to be added</param>
        



       

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            login previousScreen = new login();
            this.Hide();
            previousScreen.ShowDialog();
            this.Close();
        }

    }
}
