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
    public partial class addNewGroup : Form
    {
        public static user user = new user();
        string name = "";
        string meetingplace = "";
        string type = "";

        public addNewGroup(user loggedInUser)
        {
            user = loggedInUser;
            InitializeComponent();
        }

        private void addNewScoutBtn_Click(object sender, EventArgs e)
        {
            name = groupNameTxtbx.Text;
            meetingplace = meetingPlaceTxtBx.Text;
            type = ageGroupCBox.Text;
            group newGroup = new group(name, meetingplace, type);
            
            using (var context = new SALAHContext())
            {
                context.Groups.Add(newGroup);
                context.SaveChanges();

                var result = context.Users.SingleOrDefault(b => b.ID == user.ID);
                if (result != null)
                {
                    result.groups.Add(newGroup);
                    context.SaveChanges();
                }
                context.Dispose();
            }

            user.groups.Add(newGroup);

            MessageBox.Show("Group was successfully added.");
            main_screen open_screen = new main_screen(user);
            this.Close();
            open_screen.Show();
        }
    }
}
