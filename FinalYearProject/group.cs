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
        public string scoutID { get; set; }

        public group()
        { }

        public group(string name, string place, string type)
        {
            
            group_name = name;
            meeting_place = place;
            group_type = type;
        }

        /// <summary>
        /// Add a scout to a group
        /// </summary>
        /// <param name="groupName">name of the group</param>
        /// <param name="newScoutID">id of the new scout</param>
        /// <returns></returns>
        public static bool addScoutToGroup(string groupName, int newScoutID)
        {
            bool scoutAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    var query = from data in ctx.Groups //create a query to find the name of the group from the groupID
                                where data.group_name == groupName
                                select new { data.scoutID };
                    foreach (var result in query)
                    {
                        string scoutIDs = result.scoutID;
                        scoutIDs = scoutIDs + newScoutID + ",";
                        ctx.SaveChanges();
                        scoutAdded = true;
                    }
                }
            }
            catch
            {
                scoutAdded = false;
            }
            return scoutAdded;
        }

        /// <summary>
        /// add a new group to the database and then to the user
        /// </summary>
        /// <param name="newGroup">the new group to be added</param>
        /// <param name="user">the user the group is to be added to</param>
        /// <returns></returns>
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
