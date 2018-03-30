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
            using (var ctx = new SALAHContext())
            {
                user user = new user() { name = "John", password = "Password123" };
                ctx.Users.Add(user);
            }
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

        }
    }
}
