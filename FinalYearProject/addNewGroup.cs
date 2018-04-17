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
        bool groupNameValid = true;

        public addNewGroup(user loggedInUser)
        {
            user = loggedInUser;
            InitializeComponent();
        }

        private void addNewGroupBtn_Click(object sender, EventArgs e)
        {
            name = groupNameTxtbx.Text;
            meetingplace = meetingPlaceTxtBx.Text;
            type = ageGroupCBox.Text;
            groupNameValid = true;
            foreach (string s in group.getGroupNames(user))
            {
                if (name == s)
                {
                    MessageBox.Show("This group name is already taken.");
                    groupNameValid = false;
                    break;
                }
            }
            if (groupNameValid)
            {
                location location = new location(meetingplace);
                location.addLocation(location);
                string locationIDString = location.locationID.ToString();
                group newGroup = new group(name, locationIDString, type);
                bool userAdded = group.AddNewGroup(newGroup, user);
                
                if (userAdded)
                {
                    MessageBox.Show("Group was successfully added.");
                    main_screen open_screen = new main_screen(user);
                    this.Close();
                    open_screen.Show();
                }
                if (!userAdded)
                {
                    MessageBox.Show("Group was not added. Please try again.");
                }
            }
        }
    }
}
