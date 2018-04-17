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
    public partial class editGroup : Form
    {
        group groupToBeEdited;
        user currentUser;
        string groupName = "";
        string groupLocation = "";
        string ageGroup = "";

        public editGroup(group group, user user)
        {
            InitializeComponent();
            groupToBeEdited = group;
            SetUpForm(groupToBeEdited, user);
        }

        public void SetUpForm(group group, user user)
        {
            titleLbl.Text = "Edit Group: " + group.group_name;
            groupNameTxtbx.Text = group.group_name;
            string locationID = group.location_ID;
            
            string locationName = location.getLocationWId(locationID).locationName;
            meetingPlaceTxtBx.Text = locationName;
            ageGroupCBox.Text = group.group_type;
            currentUser = user;
        }

        private void cancelNewGroupBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to discard your changes?",
                                     "Cancel making changes",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                main_screen open_screen = new main_screen(currentUser);
                this.Close();
                open_screen.Show();
            }
        }

        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this group? This action cannot be undone.",
                                               "Delete Group: " + groupToBeEdited.group_name,
                                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    user.groupRemovedFromUser(groupToBeEdited.groupID, currentUser);
                    group.deleteGroup(groupToBeEdited.groupID, currentUser);
                }
                catch
                {
                    MessageBox.Show("Scout could not be deleted. Please check the details and try again.");
                }
            }
        }

        private void editGroupBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save your changes?",
                                                 "Save changes",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int groupId = groupToBeEdited.groupID;

                using (var ctx = new SALAHContext())
                {
                    var result = ctx.Groups.SingleOrDefault(g => g.groupID == groupId);
                    if (result != null)
                    {
                        result.group_name = groupNameTxtbx.Text;
                        bool locationExists = location.checkLocationExists(meetingPlaceTxtBx.Text);
                        if (locationExists == true)
                        {
                            location location = location.getLocationWName(meetingPlaceTxtBx.Text);
                            group.changeLocationOfGroup(groupId, location.locationID);
                            string locationIDString = location.locationID.ToString();
                            result.location_ID = locationIDString;
                        }
                        else
                        {
                            location location = new location(meetingPlaceTxtBx.Text);
                            location.addLocation(location);
                            group.changeLocationOfGroup(groupId, location.locationID);

                        }
                        
                        result.group_type = ageGroupCBox.SelectedItem.ToString();
                    }

                    ctx.SaveChanges();
                    ctx.Dispose();
                }

                main_screen open_screen = new main_screen(currentUser);
                this.Close();
                open_screen.Show();

            }
            return;
        }

    }
}
