using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using theSALAH.Properties;

namespace theSALAH
{
    public partial class main_screen : Form
    {
        public string username = "";
        public ICollection<group> groups;
        public static user loggedInUser = new user();
        public static group selectedGroup;
        public static location selectedLocation;

        public main_screen(user user)
        {
            InitializeComponent();
            main_screen_tmr.Start();
            loggedInUser = user;
            username = loggedInUser.Name;
            welcome_text_lbl.Text = "Welcome, " + username; //displays the username at the top of the main screen

        }


        private void main_screen_Load(object sender, EventArgs e)
        {   
            updateComboBox(groupComboBoxGroups);
            updateComboBox(meetingsChooseGroupCmbBx);
            updateLocationsComboBox(locationCmbBx);
        }
        /// <summary>
        /// displays clock on main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.home_screen_time_lbl.Text = dateTime.ToString();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void new_scout_bttn_Click(object sender, EventArgs e)
        {
            addNewScout openScreen = new addNewScout(loggedInUser);
            openScreen.Show();
            this.Close();
        }


        private void log_out_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out?",
                                     "Log out",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                login open_screen = new login();
                this.Close();
                open_screen.Show();
            }
        }

        private void new_group_bttn_Click(object sender, EventArgs e)
        {
            addNewGroup open_screen = new addNewGroup(loggedInUser);
            this.Close();
            open_screen.Show();
        }

        private void updateComboBox(ComboBox comboBox)
        {

            string[] usersGroups;
            usersGroups = user.getUsersGroups(loggedInUser);
            user.AddGroupsToComboBox(comboBox, usersGroups);
        }

        private void updateLocationsComboBox(ComboBox comboBox)
        {
            string[] usersGroups;

            usersGroups = user.getUsersGroups(loggedInUser);

            string[] locationNames = new string[usersGroups.Length];

            for (int i = 0; i < usersGroups.Length; i++)
            {
                locationNames[i] = group.getGroupLocation(usersGroups[i]);
            }
            location.addLocationsToComboBox(locationNames, locationCmbBx);
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
                            where data.Name == username
                            select new { data.groupIDs };

                foreach (var result in query)
                {
                    loggedInUser.groupIDs = result.groupIDs;
                }

            }
            clearComboBox(groupComboBoxGroups);
            updateComboBox(groupComboBoxGroups);
        }

        private void newYoungPersonBtn_Click(object sender, EventArgs e)
        {
            addNewScout open_screen = new addNewScout(loggedInUser);
            this.Close();
            open_screen.Show();
        }

        private void groupComboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayScoutsDGV.Columns.Clear();


            string chosenGroupString = groupComboBoxGroups.SelectedItem.ToString();


            group chosenGroup = group.getGroup(chosenGroupString);

            selectedGroup = chosenGroup;

            if (group.checkForScoutIDs(chosenGroup))
            {
                string[] scoutIDs = group.getScoutIDs(chosenGroup);

                string[] scoutNames = scout.getScoutNames(scoutIDs);

                int i = 0;

                displayScoutsDGV.Columns.Add("Index", "Scout ID Number");
                displayScoutsDGV.Columns.Add("Name", "Scout Name");

                foreach (string s in scoutNames)
                {
                    displayScoutsDGV.Rows.Add(scoutIDs[i], s);
                    i++;
                }
            }
        }

        private void displayScoutsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (displayScoutsDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                scout Scout = scout.getScout(int.Parse(displayScoutsDGV.Rows[e.RowIndex].Cells[0].Value.ToString()));
                editScout open_screen = new editScout(Scout, selectedGroup, loggedInUser);
                this.Close();
                open_screen.Show();
            }

        }

        private void editGroupBtn_Click(object sender, EventArgs e)
        {
            if (selectedGroup != null)
            {
                editGroup open_screen = new editGroup(selectedGroup, loggedInUser);
                this.Close(); ;
                open_screen.Show();
            }
            else
            {
                MessageBox.Show("Please select a group to edit.");
            }
        }
            

        private void planMeetingBtn_Click(object sender, EventArgs e)
        {
            addNewMeeting open_screen = new addNewMeeting(loggedInUser);
            this.Close(); ;
            open_screen.Show();
        }


        private void meetingsChooseGroupCmbBx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            displayMeetingsDGV.Columns.Clear();


            string chosenGroupString = meetingsChooseGroupCmbBx.SelectedItem.ToString();


            group chosenGroup = group.getGroup(chosenGroupString);

            selectedGroup = chosenGroup;

            if (group.checkForMeetingIDs(chosenGroup))
            {
                string[] meetingIDs = group.getMeetingIDs(chosenGroup);

                string[] meetingNames = meeting.getMeetingNames(meetingIDs);

                DateTime[] meetingDates = meeting.GetMeetingDateTime(meetingIDs); 

                int i = 0;

                displayMeetingsDGV.Columns.Add("Index", "Meeting ID Number");
                displayMeetingsDGV.Columns.Add("Name", "Meeting Title");
                displayMeetingsDGV.Columns.Add("Date", "Date of Meeting");

                foreach (string s in meetingNames)
                {
                    if (s == null || s == "")
                    {
                        displayMeetingsDGV.Rows.Add(meetingIDs[i], "No meeting name given", meetingDates[i]);
                        i++;
                    }
                    if (s != null && s != "")
                    {
                        displayMeetingsDGV.Rows.Add(meetingIDs[i], s, meetingDates[i]);
                        i++;
                    }
                }
                displayMeetingsDGV.Sort(displayMeetingsDGV.Columns[2], ListSortDirection.Ascending);
            }
        }

        private void displayMeetingsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (displayMeetingsDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                meeting Meeting = meeting.getMeeting(int.Parse(displayMeetingsDGV.Rows[e.RowIndex].Cells[0].Value.ToString()));
                editMeeting open_screen = new editMeeting(loggedInUser, selectedGroup, Meeting);
                this.Close();
                open_screen.Show();
            }
        }

        private void addLocationBtn_Click(object sender, EventArgs e)
        {
            addNewLocation open_screen = new addNewLocation(loggedInUser);
            this.Close();
            open_screen.Show();
        }

        private void locationCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            resourcesDGV.Columns.Clear();

            string chosenLocationString = locationCmbBx.SelectedItem.ToString();

            location chosenLocation = location.getLocationWName(chosenLocationString);

            selectedLocation = chosenLocation;

            if (location.checkResources(selectedLocation))
            {
                string[] resourceIDs = location.getLocationResources(selectedLocation);
                string[] resourceNames = resource.getResourceNames(resourceIDs);
                int[] resourceQuantities = resource.getResourceQuantities(resourceIDs);
                string[] resourceNotes = resource.getResourceNotes(resourceIDs);



                resourcesDGV.Columns.Add("Index", "Resource ID Number");
                resourcesDGV.Columns.Add("Name", "Resource Name");
                resourcesDGV.Columns.Add("Quant", "Quantity");
                resourcesDGV.Columns.Add("Note", "Notes");

                for (int i = 0; i <resourceIDs.Length;i++)
                {
                    string name = resourceNames[i];
                    string id = resourceIDs[i];
                    int quantity = resourceQuantities[i];
                    string notes = resourceNotes[i];

                    if (notes != null && notes != "")
                    {
                        resourcesDGV.Rows.Add(id, name, quantity, notes);
                        i++;
                    }
                    else if (notes == null || notes == "")
                    {
                        notes = "No notes.";
                        resourcesDGV.Rows.Add(id, name, quantity, notes);
                        i++;
                    }
                }
            }
            
        }

        private void updateGroupListLocationsBtn_Click(object sender, EventArgs e)
        {
            clearComboBox(locationCmbBx);
            updateLocationsComboBox(locationCmbBx);
        }

        private void editLocationBtn_Click(object sender, EventArgs e)
        {
            location editLocation = new location();
            if (locationCmbBx.SelectedItem.ToString() != null)
            { editLocation.locationName = locationCmbBx.SelectedItem.ToString();
            editLocation = location.getLocationWName(editLocation.locationName);
            group locationsGroup = group.GetGroupWLocation(editLocation.locationID);
            editLocation open_screen = new editLocation(loggedInUser, editLocation, locationsGroup);
            open_screen.Show();
            this.Close();
            }
            else
            {
                MessageBox.Show("Please select a location to edit.");
            }
            
        }

        private void addResourceBtn_Click(object sender, EventArgs e)
        {
            addNewResource open_screen = new addNewResource(loggedInUser, location.getLocationWName(locationCmbBx.SelectedItem.ToString()));
            open_screen.Show();
            this.Close();
        }

        private void resourcesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (resourcesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                resource resource = resource.GetResource(int.Parse(resourcesDGV.Rows[e.RowIndex].Cells[0].Value.ToString()));
                editResource open_screen = new editResource(loggedInUser, selectedLocation, resource);//create this method
                this.Close();
                open_screen.Show();
            }
        }
    }
}
