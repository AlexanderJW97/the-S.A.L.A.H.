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
    public partial class attendanceStatistics : Form
    {
        public static user mCurrentUser;
        public static group mCurrentGroup;



        public attendanceStatistics(user user, group group)
        {
            InitializeComponent();
            mCurrentUser = user;
            mCurrentGroup = group;
            SetUpForm();
        }

        public void SetUpForm()
        {
            updateComboBox(chooseGroupCmbBx);
            chooseGroupCmbBx.Text = mCurrentGroup.group_name;
            totalMeetingsRun();
            averageNumberAttendance();
            totalScouts();
            lowestAttendance();
            highestAttendance();
        }

        private void updateComboBox(ComboBox comboBox)
        {
            string[] usersGroups;
            usersGroups = user.getUsersGroups(mCurrentUser);
            user.AddGroupsToComboBox(comboBox, usersGroups);
        }

        private void clearComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
        }

        private void chooseGroupCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string groupName = chooseGroupCmbBx.SelectedItem.ToString();
            mCurrentGroup = group.getGroup(groupName);
            totalMeetingsRun();
            averageNumberAttendance();
            totalScouts();
            lowestAttendance();
            highestAttendance();
        }

        public void totalMeetingsRun()
        {
            if (mCurrentGroup.meetingIDs != null)
            {
                string[] meetingIDs = group.getMeetingIDs(mCurrentGroup);
                int meetingsRun = 0;
                foreach (string s in meetingIDs)
                {
                    if (s != null && s != "")
                    {
                        int sInt = int.Parse(s);
                        meeting meeting = meeting.getMeeting(sInt);
                        DateTime meetingDate = DateTime.Parse(meeting.DateTime);
                        if (meetingDate < DateTime.Today)
                        {
                            meetingsRun++;
                        }
                    }
                }
                totalNumMeetingsValueLbl.Text = meetingsRun.ToString();
            }
            else
            {
                totalNumMeetingsValueLbl.Text = "No meetings run yet.";
            }
        }

        public void averageNumberAttendance()
        {
            if (mCurrentGroup.meetingIDs != null)
            {
                string[] meetingIDs = group.getMeetingIDs(mCurrentGroup);

                int[] meetingsAttendance = new int[meetingIDs.Length];

                int i = 0;

                int sumOfAttendance = 0;

                int avgAttendance;

                foreach (string s in meetingIDs)
                {
                    if (s != null && s != "")
                    {
                        int sInt = int.Parse(s);

                        meeting meeting = meeting.getMeeting(sInt);

                        DateTime meetingDate = DateTime.Parse(meeting.DateTime);

                        if (meetingDate < DateTime.Today)
                        {
                            meetingsAttendance[i] = meeting.attendance;
                            i++;
                        }
                    }
                }



                foreach (int j in meetingsAttendance)
                {
                    sumOfAttendance = sumOfAttendance + j;
                }

                if (i != 0)
                {
                    avgAttendance = sumOfAttendance / i;

                    AvgAttValueLblAvgAttValueLbl.Text = avgAttendance.ToString();
                }
                else
                {
                    AvgAttValueLblAvgAttValueLbl.Text = "No meetings attended yet";
                }
            }
            else
            {
                AvgAttValueLblAvgAttValueLbl.Text = "No meetings run yet";
            }
        }

        public void totalScouts()
        {
            if (mCurrentGroup.scoutID != null)
            {
                string[] scoutIds = group.getScoutIDs(mCurrentGroup);
                int numScouts = scoutIds.Length;
                totalNumScoutsValueLbl.Text = numScouts.ToString();
            }
            else
            {
                totalNumScoutsValueLbl.Text = "No scouts belong to this group";
            }
        }

        public void lowestAttendance()
        {
            if (mCurrentGroup.meetingIDs != null)
            {

                string[] meetingIDs = group.getMeetingIDs(mCurrentGroup);
                int lowestAttendance = 0;
                foreach (string s in meetingIDs)
                {
                    if (s != null && s != "")
                    {
                        int sInt = int.Parse(s);
                        meeting meeting = meeting.getMeeting(sInt);
                        if (meeting.attendance < lowestAttendance || lowestAttendance == 0)
                        {
                            lowestAttendance = meeting.attendance;
                        }
                    }
                }

                lowAttenMeetingValueLbl.Text = lowestAttendance.ToString();
            }
            else
            {
                lowAttenMeetingValueLbl.Text = "No meetings run yet";
            }
        }
        public void highestAttendance()
        {
            if (mCurrentGroup.meetingIDs != null)
            {
                string[] meetingIDs = group.getMeetingIDs(mCurrentGroup);
                int highestAttendance = 0;
                foreach (string s in meetingIDs)
                {
                    if (s != null && s != "")
                    {
                        int sInt = int.Parse(s);
                        meeting meeting = meeting.getMeeting(sInt);
                        if (meeting.attendance > highestAttendance || highestAttendance == 0)
                        {
                            highestAttendance = meeting.attendance;
                        }
                    }
                }

                highAttenMeetingValueLbl.Text = highestAttendance.ToString();
            }
            else
            {
                highAttenMeetingValueLbl.Text = "No meetings run yet";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_screen open_screen = new main_screen(mCurrentUser);
            open_screen.Show();
            this.Close();
        }
    }
}
