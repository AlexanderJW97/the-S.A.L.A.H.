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
        public string scoutID { get; set; }

        public group()
        { }

        public group(string name, string place, string type)
        {

            group_name = name;
            meeting_place = place;
            group_type = type;
            scoutID = "";
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
                    group groupQuery = ctx.Groups.FirstOrDefault(m => m.group_name == groupName);
                    groupQuery.scoutID = groupQuery.scoutID + newScoutID + ",";
                    ctx.SaveChanges();
                    scoutAdded = true;

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

        /// <summary>
        /// Gets all of the scouts that are part of a specified group
        /// </summary>
        /// <param name="group">The group that the scouts belong to</param>
        /// <returns></returns>
        public static string[] getScoutIDs(group group)
        {
            char stringSplitterChar = ',';
            string scoutIDs = group.scoutID;
            string[] scoutIDsArray = scoutIDs.Split(stringSplitterChar);
            return scoutIDsArray;

        }

        /// <summary>
        /// Gets a group object from a specified group name
        /// </summary>
        /// <param name="groupName">name of the group to be found</param>
        /// <returns></returns>
        public static group getGroup(string groupName)
        {
            group groupQuery = new group();
            try
            {
                using (var ctx = new SALAHContext())
                {
                    groupQuery = ctx.Groups.FirstOrDefault(m => m.group_name == groupName);
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Group could not be found.");
            }
            return groupQuery;
        }
    }
}
