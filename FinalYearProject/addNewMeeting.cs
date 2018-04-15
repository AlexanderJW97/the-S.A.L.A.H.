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
    public partial class addNewMeeting : Form
    {
        user currentUser;
        group currentGroup;


        public addNewMeeting(user user)
        {
            InitializeComponent();
            currentUser = user;
            clearComboBox(chooseGroupMeetingComboBox);
            updateComboBox(chooseGroupMeetingComboBox);
        }

        private void cancelNewGroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void chooseGroupMeetingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosenGroupString = chooseGroupMeetingComboBox.SelectedItem.ToString();
            currentGroup = group.getGroup(chosenGroupString);
            meetingPlaceTxtBx.Text = currentGroup.meeting_place;
        }

        private void updateComboBox(ComboBox comboBox)
        {

            string[] usersGroups;
            usersGroups = user.getUsersGroups(currentUser);
            user.AddGroupsToComboBox(comboBox, usersGroups);
        }

        private void clearComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
        }

        private void updateComboBoxBtn_Click(object sender, EventArgs e)
        {
            using (var ctx = new SALAHContext())
            {
                var query = from data in ctx.Users //create a query to find the groupIDs of the logged in user
                            where data.ID == currentUser.ID
                            select new { data.groupIDs };

                foreach (var result in query)
                {
                    currentUser.groupIDs = result.groupIDs;
                }

            }
            clearComboBox(chooseGroupMeetingComboBox);
            updateComboBox(chooseGroupMeetingComboBox);
        }

        private void addNewMeetingBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save this meeting?",
                                     "Save Meeting",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    meeting newMeeting = new meeting();
                    newMeeting.Location = meetingPlaceTxtBx.Text;
                    newMeeting.meetingDesc = meetingDescTxtBx.Text;
                    newMeeting.DateTime = meetingDatePicker.Value.ToString();
                    newMeeting.meetingTitle = meetingTitleTxtBx.Text;
                    meeting.addNewMeeting(newMeeting, currentGroup);
                    main_screen open_screen = new main_screen(currentUser);
                    open_screen.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Meeting could not be saved.");
                }
            }
        }

        private void updateGroupComboBoxBtn_Click(object sender, EventArgs e)
        {
            clearComboBox(chooseGroupMeetingComboBox);
            updateComboBox(chooseGroupMeetingComboBox);
        }
    }
}
