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

        public DateTime dateOfBirth { get; set; }

        public address Address { get; set; }

        public enum groupType
        {
            Beaver,
            Cub,
            Scout,
            Explorer,
            Network,
        }

        public string parentEmail { get; set; }

        public string parentFirstName { get; set; }

        public string parentSecondName { get; set; }

        public int parentEmergencyNumb { get; set; }

        public string healthInfo { get; set; }

        public scout(string firstName, string secondName, DateTime dateOfBirth, address address, string groupType, string parentEmail, string pFirstName, string pSecondName, int parentNumb, string healthInfo)
        {
            
        }
    }
}
