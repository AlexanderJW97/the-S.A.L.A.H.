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
    public partial class addNewScout : Form
    {
        public static user currentUser = new user();

        public addNewScout(user loggedInUser)
        {
            currentUser = loggedInUser;
            InitializeComponent();
            updateComboBox();
        }

        private void addNewScoutBtn_Click(object sender, EventArgs e)
        {

            string firstName = "";
            string secondName = "";
            string dateOfBirth = "";
            string pEmail = "";
            string pFName = "";
            string pSName = "";
            int pNumb = 0;
            string healthInfo = "";
            string houseNum = "";
            string street = "";
            string city = "";
            string county = "";
            string country = "";
            string postcode = "";
            address Address;

            scout Scout = getPersonalDetails(firstName, secondName, dateOfBirth, (Address = getAddress(houseNum, street, city, county, country, postcode)), pEmail, pFName, pSName, pNumb, healthInfo);
            try
            {
                scout.addNewScout(Scout);
                string groupName = getGroupName();
                group.addScoutToGroup(groupName, Scout.scoutID);
            }
            catch
            {
                MessageBox.Show("New scout could not be created. Please try again.");
            }

        }

        /// <summary>
        /// returns a string containing the name of the group the new scout is to be added to
        /// </summary>
        /// <returns></returns>
        public string getGroupName()
        {
            string groupName = chooseGroupComboBox.SelectedItem.ToString();
            return groupName;
        }


        /// <summary>
        /// gets the personal details for the new scout that has been entered in the form and returns a scout object
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="secondName">surname</param>
        /// <param name="dateOfBirth">date of birth</param>
        /// <param name="Address">address</param>
        /// <param name="pEmail">parents email</param>
        /// <param name="pFName">parents first name</param>
        /// <param name="pSName">parent surname</param>
        /// <param name="pNumb">parent phone #</param>
        /// <param name="healthInfo">health information for scout</param>
        /// <returns></returns>
        public scout getPersonalDetails(string firstName, string secondName, string dateOfBirth, address Address, string pEmail, string pFName, string pSName, int pNumb, string healthInfo)
        {
            try
            {
                firstName = firstNameTxtbx.Text;
                secondName = secondNameTxtBx.Text;
                dateOfBirth = DOBPicker.Text;
                pEmail = pEmailTxtBx.Text;
                pFName = pFirstNameTxtBx.Text;
                pSName = pSecondNameTxtBx.Text;
                healthInfo = healthTxtBx.Text;
            }
            catch
            {
                MessageBox.Show("New scout could not be created. Please try again.");
            }
            try
            { 
                pNumb = parsePhoneNumber(pContactNumTxtBx.Text);

            }
            catch
            {
                MessageBox.Show("The phone number you have entered is incorrect and may contain characters other than numbers. Please try again.");
            }
            
            scout Scout = new scout(firstName: firstName, secondName: secondName, dateOfBirth: dateOfBirth, address: Address, parentEmail: pEmail, pFirstName: pFName, pSecondName: pSName, parentNumb: pNumb, healthInfo: healthInfo);
            return Scout;
        }
        public address getAddress(string houseNum, string street, string city, string county, string country, string postcode)
        {
            houseNum = houseNumbTxtBx.Text;
            street = streetTxtBx.Text;
            city = cityTxtBx.Text;
            county = countyTxtBx.Text;
            country = countryTxtBx.Text;
            postcode = postcodeTxtBx.Text;
            address Address = new address(houseNumberOrName: houseNum, street: street, city: city, county: county, country: country, postcode: postcode);
            return Address;
        }


        public int parsePhoneNumber(string phoneNumber)
        {
            int parsedPNumb = 0;
            if (phoneNumber.Length != 11)
                MessageBox.Show("Phone number is incorrect length");
            bool result = Int32.TryParse(phoneNumber, out parsedPNumb);
            return parsedPNumb;

        }

        public void addScoutToDB(scout Scout, address Address)
        {
            try
            {
                using (var ctx = new SALAHContext())
                {
                    ctx.Addresses.Add(Address);
                    ctx.Scouts.Add(Scout);
                    ctx.SaveChanges();
                }
                MessageBox.Show("Scout was successfully added.");
                main_screen open_screen = new main_screen(currentUser);
                this.Close();
                open_screen.Show();
            }
            catch
            {
                MessageBox.Show("Unable to add scout. Please ensure all information is correct and try again.");
            }
        }

        private void cancelNewScoutBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel?",
                                     "Cancel adding new scout",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                main_screen open_screen = new main_screen(currentUser);
                this.Close();
                open_screen.Show();
            }
        }

        private void updateComboBox()
        {
            string[] usersGroups;
            usersGroups = user.getUsersGroups(currentUser);
            ComboBox chooseGroupComboBox = new ComboBox();
            user.AddGroupsToComboBox(chooseGroupComboBox, usersGroups);
        }
    }
}
