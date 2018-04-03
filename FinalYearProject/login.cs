using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSALAH
{
    public partial class login : Form
    {
        public login()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
        }

        public void newUserBtn_Click(object sender, EventArgs e)
        {
           new_user_screen openScreen = new new_user_screen();
           openScreen.Show();
           Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = usernameTxtBx.Text;
            password = passwordTxtBx.Text;
            user user = new user(username, password);
            user.checkLogin(user);

        }
    }
}
