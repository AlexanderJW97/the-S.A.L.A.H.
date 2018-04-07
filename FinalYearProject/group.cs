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
        public int groupID{ get; set; }

        public string group_name { get; set; }
        public string meeting_place { get; set; }
        public string group_type { get; set; }
        public List<int> scoutID { get; set; }
        public List<int> resourceID { get; set; }

        public group()
        { }

        public group(string name, string place, string type)
        {
            
            group_name = name;
            meeting_place = place;
            group_type = type;
        }

        public static bool AddNewGroup(group newGroup, user user)
        {
            bool groupAdded = false;
            bool groupAddedToUser = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    ctx.Groups.Add(newGroup);
                    ctx.SaveChanges();
                }
                
                groupAddedToUser = user.addGroupToUser(user, newGroup.groupID);
                if (groupAddedToUser)
                {
                    groupAdded = true;
                }
                return groupAdded;

            }
            catch
            {
                groupAdded = false;
                return groupAdded;
            }
        }
    }
}
