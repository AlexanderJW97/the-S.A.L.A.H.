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
    public partial class editResource : Form
    {
        public static user currentUser;
        public static location currentLocation;
        public static location newLocation;
        public static resource currentResource;
        public static bool moveLocation = false;

        public editResource(user user, location location, resource resource)
        {
            InitializeComponent();
            SetUpForm(user, location, resource);
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

        public void SetUpForm(user user, location location, resource resource)
        {
            currentUser = user;
            currentLocation = location;
            newLocation = currentLocation;
            currentResource = resource;
            chooseLocationComboBox.Text = location.locationName;
            resourceNameTxtBx.Text = resource.name;
            resourceNotesTxtBx.Text = resource.notes;
            quantityUpDown.Text = resource.quantity.ToString();
            updateComboBox(chooseLocationComboBox);
        }

        private void updateGroupComboBoxBtn_Click(object sender, EventArgs e)
        {
            clearComboBox(chooseLocationComboBox);
            updateComboBox(chooseLocationComboBox);
        }

        private void chooseLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveLocation = true;
            string newLocationName = chooseLocationComboBox.SelectedItem.ToString();
            newLocation = location.getLocationWName(newLocationName);
        }

        private void discardChangesBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to discard the changes you have made?",
                                        "Discard Changes",
                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                main_screen open_screen = new main_screen(currentUser);
                open_screen.Show();
                this.Close();
            }
        }

        private void deleteLocationBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this resource? This action cannot be undone.",
                                                "Delete Meeting: " + currentResource.name,
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    location.RemoveResourceFromLocation(currentLocation, currentResource);
                    resource.DeleteResource(currentResource.resourceID);
                    main_screen open_screen = new main_screen(currentUser);
                    this.Close();
                    open_screen.Show();
                }
                catch
                {
                    MessageBox.Show("Resource could not be deleted. Please check the details and try again.");
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save your changes to this resource?",
                                                "Save Changes",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (newLocation.locationID == currentLocation.locationID)
                    moveLocation = false;

                resource.ChangeLocationOfResource(currentResource.resourceID, currentLocation.locationID, newLocation.locationID, moveLocation);

                int resourceId = currentResource.resourceID;

                using (var ctx = new SALAHContext())
                {
                    var result = ctx.Resources.SingleOrDefault(r => r.resourceID == resourceId);
                    if (result != null)
                    {
                        result.name = resourceNameTxtBx.Text;
                        result.notes = resourceNotesTxtBx.Text;
                        result.quantity = int.Parse(quantityUpDown.Text);
                    }

                    ctx.SaveChanges();
                    ctx.Dispose();
                }

                main_screen open_screen = new main_screen(currentUser);
                this.Close();
                open_screen.Show();
            }
        }
    }
}
