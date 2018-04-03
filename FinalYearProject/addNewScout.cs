﻿using System;   
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
        public addNewScout()
        {
            InitializeComponent();
        }
        
        private void addNewScoutBtn_Click(object sender, EventArgs e)
               {

                    string firstName = "";
                    string secondName = "";
                    DateTime dateOfBirth = DateTime.Parse("1/1/2000 00:00:00 AM");
                    string Group = "";
                    string pEmail = "";
                    string pFName = "";
                    string pSName = "";
                    int pNumb = 0 ;
                    string healthInfo = "";
                    string houseNum = "";
                    string street = "";
                    string city = "";
                    string county = "";
                    string country = "";
                    string postcode = "";
                    address Address;
            
                    scout Scout = getPersonalDetails(firstName,secondName,dateOfBirth, (Address = getAddress(houseNum, street, city, county, country, postcode)), Group, pEmail, pFName, pSName,pNumb, healthInfo);

                addScoutToDB(Scout: Scout, Address: Address);
                
                }
        public scout getPersonalDetails(string firstName, string secondName, DateTime dateOfBirth, address Address, string Group, string pEmail, string pFName, string pSName, int pNumb, string healthInfo)
        {
            firstName = firstNameTxtbx.Text;
            secondName = secondNameTxtBx.Text;
            dateOfBirth = DOBPicker.Value;
            Group = ageGroupCBox.Text;
            pEmail = pEmailTxtBx.Text;
            pFName = pFirstNameTxtBx.Text;
            pSName = pSecondNameTxtBx.Text;
            try
            {
                pNumb = parsePhoneNumber(pContactNumTxtBx.Text);
                
            }
            catch
            {
                MessageBox.Show("The phone number you have entered is incorrect and may contain characters other than numbers. Please ensure it is correctly entered.");
            }
            healthInfo = healthTxtBx.Text;
            scout Scout = new scout(firstName: firstName, secondName: secondName, dateOfBirth: dateOfBirth, address: Address, groupType: Group, parentEmail: pEmail, pFirstName: pFName, pSecondName: pSName, parentNumb: pNumb, healthInfo: healthInfo);
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
            if (phoneNumber.Length > 10)
                MessageBox.Show("Phone number is too long");
            bool result = Int32.TryParse(phoneNumber, out parsedPNumb);
            return parsedPNumb;
            
        }

        public void addScoutToDB(scout Scout, address Address)
        {
                using (var ctx = new SALAHContext())
                {
                ctx.Addresses.Add(Address);
                ctx.Scouts.Add(Scout);
                ctx.SaveChanges();
                }
        }
    }
}