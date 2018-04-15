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
    public partial class editMeeting : Form
    {

        public static user currentUser;
        public static group currentGroup;
        public static group newGroup;
        public static meeting currentMeeting;
        public static bool moveGroup = false;


        public editMeeting(user user, group group, meeting meeting)
        {
            InitializeComponent();
            SetUpForm(user, meeting, group);
        }

        private void SetUpForm(user user, meeting meeting, group group)
        {
            currentUser = user;
            currentGroup = group;
            newGroup = new group();
            currentMeeting = meeting;
            titleLbl.Text += meeting.meetingTitle;
            meetingTitleTxtBx.Text = meeting.meetingTitle;
            meetingDescTxtBx.Text = meeting.meetingDesc;
            meetingPlaceTxtBx.Text = meeting.Location;
            try
            {
                meetingDatePicker.Value = DateTime.Parse(meeting.DateTime);
            }
            catch
            {
                MessageBox.Show("No date was set for this meeting. Please set one before saving.");
            }
            updateComboBox();
            chooseGroupMeetingComboBox.Text = group.group_name;

        }

        
            
        

        private void updateComboBox()
        {
            string[] usersGroups;
            usersGroups = user.getUsersGroups(currentUser);
            ComboBox chooseGroupComboBox = new ComboBox();
            AddGroupsToComboBox(usersGroups);
        }

        private void clearComboBox()
        {
            chooseGroupMeetingComboBox.Items.Clear();
        }

        private void updateGroupComboBoxBtn_Click(object sender, EventArgs e)
        {
            clearComboBox();
            updateComboBox();
        }

        public void AddGroupsToComboBox(string[] groups)
        {
            int length = groups.Length; //get length of the groupID array

            int groupID = 0;

            string[] groupNames = new string[length]; //new array to hold the names of the groups

            using (var ctx = new SALAHContext())
            {
                for (int i = 0; i < length; i++)
                {
                    if (groups[i] != "")
                    {
                        groupID = int.Parse(groups[i]); //parse the groupID from the groupID string array into a int variable

                        var query = from data in ctx.Groups //create a query to find the name of the group from the groupID
                                    where data.groupID == groupID
                                    select new { data.group_name };

                        foreach (var result in query)
                        {
                            groupNames[i] = result.group_name; //add the group name into the groupnames array
                        }

                        if (groupNames[i] != null && groupNames[i] != "")
                            chooseGroupMeetingComboBox.Items.Add(groupNames[i]); //add the latest array entry into the combobox
                    }

                }
            }
        }

        private void discardChangesBtn_Click(object sender, EventArgs e)
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


        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save your changes?",
                                                "Save changes",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)

            {

                if (newGroup.group_name == currentGroup.group_name)
                    moveGroup = false;

                group.changeGroupMeeting(currentGroup, newGroup, currentMeeting, moveGroup);

                int meetingId = currentMeeting.meetingID;

                using (var ctx = new SALAHContext())
                {
                    var result = ctx.Meetings.SingleOrDefault(m => m.meetingID == meetingId);
                    if (result != null)
                    {
                        result.meetingTitle = meetingTitleTxtBx.Text;
                        result.meetingDesc = meetingDescTxtBx.Text;
                        result.Location = meetingPlaceTxtBx.Text;
                        result.DateTime = meetingDatePicker.Value.ToString();
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

        private void deleteMeetingBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this scout? This action cannot be undone.",
                                                "Delete Meeting: " + currentMeeting.meetingTitle,
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    group.RemoveMeetingFromGroup(currentGroup, currentMeeting);
                    meeting.deleteMeeting(currentMeeting.meetingID);
                    main_screen open_screen = new main_screen(currentUser);
                    this.Close();
                    open_screen.Show();
                }
                catch
                {
                    MessageBox.Show("Scout could not be deleted. Please check the details and try again.");
                }
            }
        }

        private void chooseGroupMeetingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveGroup = true;
            newGroup.group_name = chooseGroupMeetingComboBox.SelectedItem.ToString();
            newGroup = group.getGroup(newGroup.group_name);
            return;
        }
    }
}
