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

        public string firstName { get; set;}

        public string secondName { get; set; }

        public string dateOfBirth { get; set; }

        public address Address { get; set; }
        
        public string parentEmail { get; set; }

        public string parentFirstName { get; set; }

        public string parentSecondName { get; set; }

        public int parentEmergencyNumb { get; set; }

        public string healthInfo { get; set; }

        public scout(string firstName, string secondName, string dateOfBirth, address address, string parentEmail, string pFirstName, string pSecondName, int parentNumb, string healthInfo)
        {
            
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
    }
}
