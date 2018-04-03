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
            string password;
            string salt = "";

            if (passwordManager.passwordValidation(password1TxtBx.Text, password2TxtBx.Text))
            {
                password = password1TxtBx.Text;
                newUsername = usernameTxtBx.Text;
                password = passwordManager.HashSaltManager.GeneratePasswordHash(password, out salt);
                user User = new user(newUsername, password, salt);
                if (user.AddNewUser(user: User))
                {
                    main_screen openMainScreen = new main_screen();
                    openMainScreen.Show();
                    Visible = false;
                }
                else
                    MessageBox.Show("New user could not be created, please try again");
                
            }
            
            else
                MessageBox.Show("Passwords did not match!");
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
