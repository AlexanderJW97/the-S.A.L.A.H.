using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace theSALAH
{
    public class scout
    {
        [Key]
        public int scoutID { get; set; }

        public string firstName { get; set; }

        public string secondName { get; set; }

        public string dateOfBirth { get; set; }

        public address Address { get; set; }

        public string parentEmail { get; set; }

        public string parentFirstName { get; set; }

        public string parentSecondName { get; set; }

        public string parentEmergencyNumb { get; set; }

        public string healthInfo { get; set; }

        public scout()
        { } 

        public scout(string firstN, string secondN, string DOB, address add, string parentE, string pFirst, string pSecond, string parentN, string health)
        {
            scoutID = scoutID++;
            firstName = firstN;
            secondName = secondN;
            dateOfBirth = DOB;
            Address = add;
            parentEmail = parentE;
            parentFirstName = pFirst;
            parentSecondName = pSecond;
            parentEmergencyNumb = parentN;
            healthInfo = health;
        }

        public static bool addNewScout(scout scout)
        {
            bool scoutAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    ctx.Scouts.Add(scout);
                    ctx.SaveChanges();
                }
                scoutAdded = true;
                return scoutAdded;

            }
            catch
            {
                scoutAdded = false;
                return scoutAdded;
            }
        }

        /// <summary>
        /// Gets the first and second names of scouts from their scout IDs
        /// </summary>
        /// <param name="scoutIDs">an array of scout IDs to be foundi wil   </param>
        /// <returns></returns>
        public static string[] getScoutNames(string[] scoutIDs)
        {
            string[] scoutNames = new string[scoutIDs.Length];

            int i = 0;

            using (var ctx = new SALAHContext())
            {
                foreach (string s in scoutIDs)
                {
                    int idInt = 0;
                    if (s != null && s != "")
                        idInt = int.Parse(s);
                    var query = from data in ctx.Scouts //create a query to find the groupIDs of the logged in user
                                where data.scoutID == idInt
                                select new { data.firstName, data.secondName };

                    foreach (var result in query)
                    {
                        scoutNames[i] = result.firstName + " " + result.secondName;
                        i++;
                    }

                }
            }

            return scoutNames;
        }


        public static scout getScout(int idNumber)
        {
            scout Scout = new scout();




            using (var ctx = new SALAHContext())
            {
                    var query = from data in ctx.Scouts //create a query to find the groupIDs of the logged in user
                                where data.scoutID == idNumber 
                                select new { data.firstName, data.secondName, data.Address, data.dateOfBirth, data.healthInfo, data.parentEmail, data.parentEmergencyNumb, data.parentFirstName, data.parentSecondName};

                    foreach (var result in query)
                    {
                    Scout.firstName = result.firstName;
                    Scout.secondName = result.secondName;
                    Scout.Address = result.Address;
                    Scout.dateOfBirth = result.dateOfBirth;
                    Scout.healthInfo = result.healthInfo;
                    Scout.parentEmail = result.parentEmail;
                    Scout.parentEmergencyNumb = result.parentEmergencyNumb;
                    Scout.parentFirstName = result.parentFirstName;
                    Scout.parentSecondName = result.parentSecondName;
                    }

                
            }

            return Scout;
        }

    }
}
