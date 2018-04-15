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
            updateComboBox(groupComboBoxMeetings);
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

            if(group.checkForScoutIDs(chosenGroup))
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
                //MessageBox.Show(displayScoutsDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                scout Scout = scout.getScout(int.Parse(displayScoutsDGV.Rows[e.RowIndex].Cells[0].Value.ToString()));
                editScout open_screen = new editScout(Scout, selectedGroup, loggedInUser);
                this.Close();
                open_screen.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            editGroup open_screen = new editGroup(selectedGroup, loggedInUser);
            this.Close(); ;
            open_screen.Show();
        }

        private void planMeetingBtn_Click(object sender, EventArgs e)
        {
            addNewMeeting open_screen = new addNewMeeting(loggedInUser);
            this.Close(); ;
            open_screen.Show();
        }
    }
}
