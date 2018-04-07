using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace theSALAH
{
    public class address
    {
        [Key]
        public int addressIdentifier { get; set; }

        public string houseNumberOrName { get; set; }

        public string street { get; set; }

        public string city { get; set; }

        public string county { get; set; }

        public string country { get; set; }

        public string postcode { get; set; }

        public List<scout> scouts { get; set; }

        public address(string houseNumberOrName, string street, string city, string county, string country, string postcode)
        {

        }
    }
}
