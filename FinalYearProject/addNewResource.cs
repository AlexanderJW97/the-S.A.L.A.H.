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
    public partial class addNewResource : Form
    {
        public static user currentUser;
        public static location currentLocation;
        public static resource newResource;

        public addNewResource(user user, location location)
        {
            InitializeComponent();
            SetUpForm(user, location);
        }

        public void SetUpForm(user user, location location)
        {
            currentUser = user;
            currentLocation = location;
            updateComboBox(chooseLocationComboBox);
        }

        private void updateComboBox(ComboBox comboBox)
        {
            string[] usersGroups;

            usersGroups = user.getUsersGroups(currentUser);

            string[] locationNames = new string[usersGroups.Length];

            for (int i = 0; i < usersGroups.Length; i++)
            {
                locationNames[i] = group.getGroupLocation(usersGroups[i]);
            }
            location.addLocationsToComboBox(locationNames, comboBox);
        }

        private void clearComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
        }

        private void cancelNewResourceBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel creating a new resource?",
                                         "Cancel New Resource",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                main_screen open_screen = new main_screen(currentUser);
                open_screen.Show();
                this.Close();
            }
        }

        private void addNewResourceBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save this new resource?",
                                         "Save New Resource",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                bool resourceAdded = true;
                try
                {
                    newResource = new resource();
                    newResource.name = resourceNameTxtBx.Text;
                    newResource.notes = resourceNotesTxtBx.Text;
                    newResource.quantity = int.Parse(quantityUpDown.Text);
                    if (!resource.addNewResource(newResource))
                        resourceAdded = false;
                    if (!location.addResourceToLocation(currentLocation.locationID, newResource.resourceID))
                        resourceAdded = false;
                }
                catch
                {
                    resourceAdded = false;
                }
                if(resourceAdded == false)
                {
                    MessageBox.Show("This resource could not be saved, try again please");
                }
                else if (resourceAdded == true)
                {
                    main_screen open_screen = new main_screen(currentUser);
                    open_screen.Show();
                    this.Close();
                }
            }
        }

        private void chooseLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string locationName = chooseLocationComboBox.SelectedItem.ToString();
            currentLocation = location.getLocationWName(locationName);
            
        }
    }
}
