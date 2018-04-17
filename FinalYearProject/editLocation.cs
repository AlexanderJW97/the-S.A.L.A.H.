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
    public partial class editLocation : Form
    {
        public static user currentUser;
        public static location currentLocation;
        public static group currentGroup;
        public static group newGroup;
        public static address currentAddress;
        public static bool moveGroup;




        public editLocation(user user, location location, group group)
        {
            InitializeComponent();
            SetUpForm(user, location, group);
        }

        public void SetUpForm(user user, location location, group group)
        {
            currentUser = user;
            currentLocation = location;
            currentGroup = group;
            currentAddress = location.Address;
            if (currentAddress != null)
            {
                houseNumbTxtBx.Text = currentAddress.houseNumberOrName;
                streetTxtBx.Text = currentAddress.street;
                cityTxtBx.Text = currentAddress.city;
                countyTxtBx.Text = currentAddress.county;
                countryTxtBx.Text = currentAddress.country;
                postcodeTxtBx.Text = currentAddress.postcode;
            }
            titleLbl.Text += currentLocation.locationName;
            chooseGroupLocationComboBox.Text = currentGroup.group_name;
            locationNameTxtBx.Text = currentLocation.locationName;
            venueNotesTxtBx.Text = currentLocation.venueNotes;
            newGroup = new group();
            updateComboBox(chooseGroupLocationComboBox);
        }

        private void updateGroupComboBoxBtn_Click(object sender, EventArgs e)
        {
            clearComboBox(chooseGroupLocationComboBox);
            updateComboBox(chooseGroupLocationComboBox);
        }
        private void clearComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
        }
        private void updateComboBox(ComboBox comboBox)
        {

            string[] usersGroups;
            usersGroups = user.getUsersGroups(currentUser);
            user.AddGroupsToComboBox(comboBox, usersGroups);
        }

        private void discardChangesBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to discard your changes?",
                                                 "Discard changes",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                main_screen open_screen = new main_screen(currentUser);
                this.Close();
                open_screen.Show();
            }
        }

        private void deleteLocationBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this location: " + currentLocation.locationName + "?",
                                             "Delete " + currentLocation.locationName,
                                             MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    location.DeleteLocation(currentLocation, currentGroup);
                    main_screen open_screen = new main_screen(currentUser);
                    this.Close();
                    open_screen.Show();
                }
                catch
                {
                    MessageBox.Show("Location could not be deleted. Please check the details and try again.");
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save your changes?",
                                         "Save changes",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                if (newGroup.group_name == currentGroup.group_name || newGroup.group_name == null)
                    moveGroup = false;

                location.changeLocationsGroup(currentLocation, currentGroup, newGroup, moveGroup);

                int locationId = currentLocation.locationID;

                using (var ctx = new SALAHContext())
                {
                    var result = ctx.Locations.SingleOrDefault(l => l.locationID == locationId);
                    if (result != null)
                    {
                        result.locationName = locationNameTxtBx.Text;
                        result.venueNotes = venueNotesTxtBx.Text;
                        result.Address = CreateAddress();
                    }

                    ctx.SaveChanges();
                    ctx.Dispose();
                }

                main_screen open_screen = new main_screen(currentUser);
                this.Close();
                open_screen.Show();

            }
        }

        private void chooseGroupLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveGroup = true;
            newGroup = new group();
            newGroup.group_name = chooseGroupLocationComboBox.SelectedItem.ToString();
            newGroup = group.getGroup(newGroup.group_name);
            return;
        }

        public address CreateAddress()
        {
            address newAddress = new address();
            newAddress.houseNumberOrName = houseNumbTxtBx.Text;
            newAddress.street = streetTxtBx.Text;
            newAddress.city = streetTxtBx.Text;
            newAddress.county = countyTxtBx.Text;
            newAddress.country = countryTxtBx.Text;
            newAddress.postcode = postcodeTxtBx.Text;
            return newAddress;
        }
    }
}
