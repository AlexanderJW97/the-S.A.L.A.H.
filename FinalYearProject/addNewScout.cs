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
            string pNumb = "";
            string healthInfo = "";
            address Address = new address();
            string groupName = "";
            bool groupChosen = false;


            scout Scout = getPersonalDetails(firstName, secondName, dateOfBirth, Address, pEmail, pFName, pSName, pNumb, healthInfo);

            try
            {
                groupName = getGroupName();
                groupChosen = true;
            }
            catch (Exception e2)
            {
                MessageBox.Show("New scout could not be created: Please select a group to add the scout to.");
            }
            try
            {
                if (groupChosen)
                {
                    scout.addNewScout(Scout);
                    MessageBox.Show("New scout was created.");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("New scout could not be created. Please try again.");
            }
            try
            {
                if (groupChosen)
                    group.addScoutToGroup(groupName, Scout.scoutID);
                main_screen open_screen = new main_screen(currentUser);
                open_screen.Show();
                this.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show("New scout created, but not added to group");
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
        public scout getPersonalDetails(string firstName, string secondName, string dateOfBirth, address Address, string pEmail, string pFName, string pSName, string pNumb, string healthInfo)
        {
            scout Scout = new scout();

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

            bool phoneNumberCheck = checkPhoneNumber(pContactNumTxtBx.Text);

            if (phoneNumberCheck)
            {
                pNumb = pContactNumTxtBx.Text;
                
                Scout = new scout(firstName, secondName,dateOfBirth,Address, pEmail, pFName, pSName, pNumb,healthInfo);
                Address = getAddress(Scout.scoutID);
                Scout.Address = Address;
            }
            if (!phoneNumberCheck)
            {
                Scout = new scout();
            }
                return Scout;
        }

        /// <summary>
        /// gets the details of the address from the form and creates and returns an address object
        /// </summary>
        /// <returns></returns>
        public address getAddress(int scoutID)
        {
            string houseNum = houseNumbTxtBx.Text;
            string street = streetTxtBx.Text;
            string city = cityTxtBx.Text;
            string county = countyTxtBx.Text;
            string country = countryTxtBx.Text;
            string postcode = postcodeTxtBx.Text;
            address Address = new address(houseNum,street,city,county,country, postcode, scoutID);
            return Address;
        }

        /// <summary>
        /// Checks that the phone number entered it correct
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public bool checkPhoneNumber(string phoneNumber)
        {

            bool numberOk = true;
            if (phoneNumber.Length != 11)
                MessageBox.Show("Phone number could not be saved: Is incorrect length");
            
            foreach (char c in phoneNumber)
            {
                if (c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != '0')
                {
                    MessageBox.Show("Phone number could not be saved: Contains characters that are not digits.");
                    numberOk = false;
                    break;
                }
            }
            return numberOk;

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
            AddGroupsToComboBox(usersGroups);
        }

        private void clearComboBox()
        {
            chooseGroupComboBox.Items.Clear();
        }

        private void updateGroupComboBoxBtn_Click(object sender, EventArgs e)
        {
            clearComboBox();
            updateComboBox();
        }

        public void AddGroupsToComboBox( string[] groups)
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


                        chooseGroupComboBox.Items.Add(groupNames[i]); //add the latest array entry into the combobox
                    }

                }
            }
        }
    }
}
