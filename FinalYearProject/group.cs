using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace theSALAH
{
    public class group
    {
        [Key]
        public int groupID { get; set; }

        public string group_name { get; set; }
        public string meeting_place { get; set; }
        public string group_type { get; set; }
        public ICollection<scout> Scouts { get; set; }
        public ICollection<resource> Resources { get; set; }

        public group()
        { }

        /*public string get_meeting_place()
        {
            return meeting_place;
        }

        public void set_meeting_place(string new_meeting_place)
        {
            try
            {
                meeting_place = new_meeting_place;
                return;
            }
            catch
            {
                MessageBox.Show("New meeting place could not be set");
                return;
            }
        }*/
    }
}
