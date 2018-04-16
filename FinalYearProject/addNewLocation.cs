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
    public partial class addNewLocation : Form
    {
        user currentUser;
        location newlocation;
        group currentGroup;
        address locationAddress;


        public addNewLocation(user user)
        {
            InitializeComponent();
            currentUser = user;
            clearComboBox(chooseGroupLocationComboBox);
            updateComboBox(chooseGroupLocationComboBox);
            newlocation = new location();
        }

        private void addNewLocationBtn_Click(object sender, EventArgs e)
        {
            newlocation.locationName = locationNameTxtBx.Text;
            newlocation.Address = createAddress();
            newlocation.venueNotes = venueNotesTxtBx.Text;
            location.addLocation(newlocation);
            group.changeLocationOfGroup(currentGroup.groupID, newlocation.locationID);
            main_screen open_screen = new main_screen(currentUser);
            open_screen.Show();
            this.Close();
        }

        private void cancelNewLocationBtn_Click(object sender, EventArgs e)
        {
            main_screen open_screen = new main_screen(currentUser);
            open_screen.Show();
            this.Close();
        }

        private void updateGroupComboBoxBtn_Click(object sender, EventArgs e)
        {
            string username = currentUser.Name;
            using (var ctx = new SALAHContext())
            {
                var query = from data in ctx.Users //create a query to find the groupIDs of the logged in user
                            where data.Name == username
                            select new { data.groupIDs };

                foreach (var result in query)
                {
                    currentUser.groupIDs = result.groupIDs;
                }

            }
            clearComboBox(chooseGroupLocationComboBox);
            updateComboBox(chooseGroupLocationComboBox);
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

        private void chooseGroupLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = chooseGroupLocationComboBox.Text;
            using (var ctx = new SALAHContext())
            {
                var result = ctx.Groups.SingleOrDefault(g => g.group_name == name);
                currentGroup = result;
            }
        }

        private address createAddress()
        {
            locationAddress = new address();
            locationAddress.houseNumberOrName = houseNumbTxtBx.Text;
            locationAddress.street = streetTxtBx.Text;
            locationAddress.city = cityTxtBx.Text;
            locationAddress.county = countyTxtBx.Text;
            locationAddress.country = countryTxtBx.Text;
            locationAddress.postcode = postcodeTxtBx.Text;
            return locationAddress;
        }
    }
}
