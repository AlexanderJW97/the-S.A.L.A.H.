using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace theSALAH
{
    public class resource
    {
        [Key]
        public int resourceID { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string notes { get; set; }
    }
}
