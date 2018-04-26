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
    public partial class registerScreen : Form
    {

        public static user mCurrentUser;
        public static group mCurrentGroup;
        public static meeting mCurrentMeeting;
        public static int mNumberOfScoutsInGroup;

        public registerScreen(user currentUser, group currentGroup)
        {
            InitializeComponent();
            mCurrentUser = currentUser;
            mCurrentGroup = currentGroup;
            SetUpForm();
        }

        public void SetUpForm()
        {
            updateComboBox(meetingsChooseGroupCmbBx);
            
        }

        private void updateComboBox(ComboBox comboBox)
        {
            string[] groupsMeetings;
            string[] meetingNames;
            groupsMeetings = group.getMeetingIDs(mCurrentGroup);
            meetingNames = meeting.getMeetingNames(groupsMeetings);
            meeting.addMeetingsToComboBox(meetingNames, meetingsChooseGroupCmbBx);
        }

        private void clearComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
        }

        private void meetingsChooseGroupCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            mNumberOfScoutsInGroup = 0;

            registerCheckedListBox1.Items.Clear();

            string[] scoutIds = group.getScoutIDs(mCurrentGroup);
            string[] scoutNames = scout.getScoutNames(scoutIds);

            string chosenMeetingName = meetingsChooseGroupCmbBx.SelectedItem.ToString();
            meeting selectedMeeting = meeting.getMeetingWName(chosenMeetingName);
            mCurrentMeeting = selectedMeeting;

            int p = 0;

            foreach (string s in scoutNames)
            {

                string nameAndId = s;
                nameAndId = scoutIds[p] + ") " + s;
                if (scoutIds[p] != "" && scoutIds != null)
                {
                    int scoutId = int.Parse(scoutIds[p]);

                    if (s != null && s != "")
                    {
                        if (meeting.wasScoutAtMeeting(mCurrentMeeting.meetingID, scoutId))
                        {
                            registerCheckedListBox1.Items.Add(nameAndId, true);
                            mNumberOfScoutsInGroup++;
                        }
                        else
                        {
                            registerCheckedListBox1.Items.Add(nameAndId, false);
                            mNumberOfScoutsInGroup++;
                        }
                    }
                    p++;
                }
            }

            meetingNotesRTxtBx.Text = selectedMeeting.meetingDesc;
            meetingTitle.Text = selectedMeeting.meetingTitle;
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save the changes you have made?",
                                           "Save Changes to " + mCurrentMeeting.meetingTitle,
                                           MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                for (int i = 0; i < mNumberOfScoutsInGroup; i++)
                {
                    if (registerCheckedListBox1.GetItemCheckState(i) == CheckState.Checked)
                    {
                        string nameAndId = registerCheckedListBox1.Items[i].ToString();
                        string[] nameAndIdArray = nameAndId.Split(')');
                        int id = int.Parse(nameAndIdArray[0]);
                        if (!meeting.wasScoutAtMeeting(mCurrentMeeting.meetingID, id))
                        {
                            meeting.addScoutToMeeting(mCurrentMeeting.meetingID, id);
                        }
                    }
                    else if (registerCheckedListBox1.GetItemCheckState(i) == CheckState.Unchecked)
                    {
                        string nameAndId = registerCheckedListBox1.Items[i].ToString();
                        string[] nameAndIdArray = nameAndId.Split(')');
                        int id = int.Parse(nameAndIdArray[0]);
                        if (meeting.wasScoutAtMeeting(mCurrentMeeting.meetingID, id))
                        {
                            meeting.removeScoutsFromMeeting(mCurrentMeeting.meetingID, id);
                        }
                    }
                }

                main_screen open_screen = new main_screen(mCurrentUser);
                open_screen.Show();
                this.Close();
            }
        }

        private void discardChangesBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to discard the changes you have made?",
                                        "Discard Changes",
                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                main_screen open_screen = new main_screen(mCurrentUser);
                open_screen.Show();
                this.Close();
            }
        }
    }
}
