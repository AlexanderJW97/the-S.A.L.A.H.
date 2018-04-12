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


        public address()
        { }


        public address(string houseNum, string st, string cty, string cnty, string cntry, string pcode)
        {
            addressIdentifier = addressIdentifier++;
            houseNumberOrName = houseNum;
            street = st;
            city = cty;
            county = cnty;
            country = cntry;
            postcode = pcode;

        }
    }
}
