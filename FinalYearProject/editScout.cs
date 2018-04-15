using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSALAH.Properties
{
    public partial class editScout : Form
    {
        public static scout scoutToBeEdited;
        public static group currentGroup;
        public static group newGroup = new group();
        public static user currentUser;
        public static address scoutsAddress;
        public static bool moveGroup = false;

        public editScout(scout scout, group group, user user)
        {
            InitializeComponent();
            scoutToBeEdited = scout;
            currentGroup = group;
            currentUser = user;
            scoutsAddress = scoutToBeEdited.Address;
            updateComboBox();
            setUpForm();

        }

        private void setUpForm()
        {
            titleLbl.Text = "Edit Scout: " + scoutToBeEdited.firstName + " " + scoutToBeEdited.secondName;
            firstNameTxtbx.Text = scoutToBeEdited.firstName;
            secondNameTxtBx.Text = scoutToBeEdited.secondName;
            chooseGroupComboBox.Text = currentGroup.group_name;
            pFirstNameTxtBx.Text = scoutToBeEdited.parentFirstName;
            pSecondNameTxtBx.Text = scoutToBeEdited.parentSecondName;
            pEmailTxtBx.Text = scoutToBeEdited.parentEmail;
            pContactNumTxtBx.Text = scoutToBeEdited.parentEmergencyNumb;
            houseNumbTxtBx.Text = scoutsAddress.houseNumberOrName;
            streetTxtBx.Text = scoutsAddress.street;
            cityTxtBx.Text = scoutsAddress.city;
            countyTxtBx.Text = scoutsAddress.county;
            countryTxtBx.Text = scoutsAddress.country;
            postcodeTxtBx.Text = scoutsAddress.postcode;
            healthTxtBx.Text = scoutToBeEdited.healthInfo;
            DOBPicker.Value = DateTime.Parse(scoutToBeEdited.dateOfBirth);

        }



        private void updateGroupComboBoxBtn_Click(object sender, EventArgs e)
        {
            clearComboBox();
            updateComboBox();
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
            chooseGroupComboBox.Items.Clear();
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

                        if(groupNames[i] != null && groupNames[i] != "")
                            chooseGroupComboBox.Items.Add(groupNames[i]); //add the latest array entry into the combobox
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

        private address GetNewAddress()
        {
            string houseNum = houseNumbTxtBx.Text;
            string street = streetTxtBx.Text;
            string city = cityTxtBx.Text;
            string county = countyTxtBx.Text;
            string country = countryTxtBx.Text;
            string postcode = postcodeTxtBx.Text;
            address newAddress = new address(houseNum, street, city, county, country, postcode);
            return newAddress;
        }


        private void saveChangesBtn_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save your changes?",
                                                 "Save changes",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)

            {

                if (newGroup.group_name == currentGroup.group_name)
                    moveGroup = false;

                group.changeGroupScout(currentGroup, newGroup, scoutToBeEdited, moveGroup);

                int scoutId = scoutToBeEdited.scoutID;

                using (var ctx = new SALAHContext())
                {
                    var result = ctx.Scouts.SingleOrDefault(s => s.scoutID == scoutId);
                    if (result != null)
                    {
                        result.firstName = firstNameTxtbx.Text;
                        result.secondName = secondNameTxtBx.Text;
                        result.Address = GetNewAddress();
                        result.dateOfBirth = DOBPicker.Value.ToString();
                        result.healthInfo = healthTxtBx.Text;
                        result.parentEmail = pEmailTxtBx.Text;
                        result.parentEmergencyNumb = pContactNumTxtBx.Text;
                        result.parentFirstName = pFirstNameTxtBx.Text;
                        result.parentSecondName = pSecondNameTxtBx.Text;
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

        private void chooseGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveGroup = true;
            newGroup.group_name = chooseGroupComboBox.SelectedItem.ToString();
            newGroup = group.getGroup(newGroup.group_name);
            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this scout? This action cannot be undone.",
                                                "Delete Scout: " + scoutToBeEdited.firstName + " " + scoutToBeEdited.secondName,
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    group.RemoveScoutFromGroup(currentGroup, scoutToBeEdited);
                    scout.deleteScout(scoutToBeEdited.scoutID);
                }
                catch
                {
                    MessageBox.Show("Scout could not be deleted. Please check the details and try again.");
                }
            }
        }
    }
}
