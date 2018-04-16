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
        public int location_ID { get; set; }
        public string group_type { get; set; }
        public string scoutID { get; set; }
        public string meetingIDs { get; set; }

        public group()
        { }

        public group(string name, int locationID, string type)
        {

            group_name = name;
            location_ID = locationID;
            group_type = type;
            scoutID = "";
        }

        /// <summary>
        /// Add a scout to a group
        /// </summary>
        /// <param name="groupName">name of the group</param>
        /// <param name="newScoutID">id of the new scout</param>
        /// <returns></returns>
        public static bool addScoutToGroup(int groupID, int newScoutID)
        {
            bool scoutAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    group groupQuery = ctx.Groups.FirstOrDefault(g => g.groupID == groupID);
                    if (groupQuery.scoutID != null)
                    {
                        string[] groupsScouts = groupQuery.scoutID.Split(',');

                        foreach (string s in groupsScouts)
                        {
                            groupQuery.scoutID = "";

                            if (s != "" && s != null)
                            {
                                groupQuery.scoutID = groupQuery.scoutID + s + ",";
                            }


                        }
                        groupQuery.scoutID += newScoutID + ",";
                    }
                    if (groupQuery.scoutID == null)
                    {
                        groupQuery.scoutID = newScoutID + ",";
                    }

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


        public static string getGroupLocation(string groupId)
        {

            string groupLocation;
            try
            {
                int intGroupId = int.Parse(groupId);
                group groupQuery = new group();

                using (var ctx = new SALAHContext())
                {
                    groupQuery = ctx.Groups.FirstOrDefault(m => m.groupID == intGroupId);
                    groupLocation = location.getLocationWId(groupQuery.location_ID).locationName;
                    return groupLocation;
                }
            }
            catch (Exception e)
            {
                groupLocation = null;
                return groupLocation;
            }

        }

        public static bool changeLocationOfGroup(int groupID, int newLocationID)
        {
            bool locationAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    group groupQuery = ctx.Groups.FirstOrDefault(g => g.groupID == groupID);


                    groupQuery.location_ID = newLocationID;

                    ctx.SaveChanges();

                    locationAdded = true;

                }
            }
            catch
            {
                locationAdded = false;
            }
            return locationAdded;
        }

        public static bool addMeetingToGroup(int groupID, int newMeetingID)
        {
            bool meetingAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    group groupQuery = ctx.Groups.FirstOrDefault(g => g.groupID == groupID);
                    if (groupQuery.meetingIDs != null)
                    {
                        string[] groupsMeetings = groupQuery.meetingIDs.Split(',');

                        groupQuery.meetingIDs = "";

                        foreach (string s in groupsMeetings)
                        {


                            if (s != "" && s != null)
                            {
                                groupQuery.meetingIDs = groupQuery.meetingIDs + s + ",";
                            }


                        }
                        groupQuery.meetingIDs += newMeetingID + ",";
                    }
                    if (groupQuery.meetingIDs == null)
                    {
                        groupQuery.meetingIDs = newMeetingID + ",";
                    }

                    ctx.SaveChanges();
                    meetingAdded = true;

                }
            }
            catch
            {
                meetingAdded = false;
            }
            return meetingAdded;
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
        /// Checks the group to see if it has scouts
        /// </summary>
        /// <param name="group">group to be checked</param>
        /// <returns>bool value</returns>
        public static bool checkForScoutIDs(group group)
        {
            bool hasScouts = false;

            if (group.scoutID != "" && group.scoutID != null)
                hasScouts = true;

            return hasScouts;
        }

        public static bool checkForMeetingIDs(group group)
        {
            bool hasMeetings = false;

            if (group.meetingIDs != "" && group.meetingIDs != null)
                hasMeetings = true;

            return hasMeetings;
        }

        public static string[] getMeetingIDs(group group)
        {
            string[] meetingIDsArray = group.meetingIDs.Split(',');

            int count = 0;
            foreach (string s in meetingIDsArray)
            {
                if (s != null && s != "")
                {
                    count++;
                }
            }
            string[] meetingsIDs = new string[count];
            int i = 0;
            foreach (string s in meetingIDsArray)
            {
                if (s != null && s != "")
                {
                    meetingsIDs[i] = s;
                    i++;
                }
            }

            return meetingsIDs;
        }


        /// <summary>
        /// Gets all of the scouts that are part of a specified group
        /// </summary>
        /// <param name="group">The group that the scouts belong to</param>
        /// <returns></returns>
        public static string[] getScoutIDs(group group)
        {
            string[] scoutIDsArray = new string[100];
            char stringSplitterChar = ',';
            if (group.scoutID != null)
            {
                string scoutIDs = group.scoutID;
                scoutIDsArray = scoutIDs.Split(stringSplitterChar);
            }
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

        public static string[] getGroupNames(user user)
        {

            string[] userGroups = user.groupIDs.Split(',');
            string[] existingGroupNames = new string[userGroups.Length - 1];
            int i = 0;

            try
            {
                using (var ctx = new SALAHContext())
                {
                    foreach (string s in userGroups)
                    {
                        int groupID;
                        if (s != "")
                        {
                            groupID = int.Parse(s);

                            group groupNamesQuery = ctx.Groups.FirstOrDefault(g => g.groupID == groupID);
                            if (groupNamesQuery != null)
                            {
                                existingGroupNames[i] = groupNamesQuery.group_name;
                                i++;
                            }
                            if (groupNamesQuery == null)
                                user.groupRemovedFromUser(groupID, user);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("New group could not be created. Please try again with a different group name");
            }
            return existingGroupNames;
        }

        public static int getGroupID(string groupName)
        {
            group groupQuery = new group();

            int groupId = 0;

            try
            {
                using (var ctx = new SALAHContext())
                {
                    groupQuery = ctx.Groups.FirstOrDefault(m => m.group_name == groupName);
                    groupId = groupQuery.groupID;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Group could not be found.");
            }
            return groupId;
        }

        public static bool deleteGroup(string groupname)
        {
            bool groupDeleted = false;
            group groupQuery = new group();

            using (var ctx = new SALAHContext())
            {
                try
                {
                    groupQuery = ctx.Groups.FirstOrDefault(m => m.group_name == groupname);
                    ctx.Groups.Remove(groupQuery);
                    ctx.SaveChanges();
                    ctx.Dispose();
                    groupDeleted = true;
                }
                catch
                {
                    groupDeleted = false;
                }
            }
            return groupDeleted;
        }

        /// <summary>
        /// change which group the scout belongs to
        /// </summary>
        /// <param name="oldGroup">group the scout currently belongs to</param>
        /// <param name="newGroup">group the scout is going to belong to</param>
        /// <param name="scout">the scout to be moved</param>
        /// <param name="moveGroup">if the scout needs to be moved</param>
        public static void changeGroupScout(group oldGroup, group newGroup, scout scout, bool moveGroup)
        {
            if (moveGroup == true)
            {
                using (var ctx = new SALAHContext())
                {
                    var result = ctx.Groups.SingleOrDefault(g => g.groupID == newGroup.groupID);


                    if (result != null)
                    {
                        newGroup = result;
                    }

                    string[] oldGroupScouts = oldGroup.scoutID.Split(',');

                    for (int i = 0; i < oldGroupScouts.Length; i++)
                    {
                        if (oldGroupScouts[i] == scout.scoutID.ToString())
                        {
                            var result1 = ctx.Groups.SingleOrDefault(g => g.groupID == oldGroup.groupID);
                            if (result1 != null)
                            {
                                result1.scoutID = "";

                                for (int j = 0; j < oldGroupScouts.Length - 1; j++)
                                {
                                    if (i != j)
                                    {
                                        result1.scoutID += oldGroupScouts[j] + ",";
                                    }
                                }
                            }
                        }
                    }
                    group.addScoutToGroup(newGroup.groupID, scout.scoutID);
                    ctx.SaveChanges();
                    ctx.Dispose();

                }
            }


        }

        /// <summary>
        /// change which group the scout belongs to
        /// </summary>
        /// <param name="oldGroup">group the scout currently belongs to</param>
        /// <param name="newGroup">group the scout is going to belong to</param>
        /// <param name="scout">the scout to be moved</param>
        /// <param name="moveGroup">if the scout needs to be moved</param>
        public static void changeGroupMeeting(group oldGroup, group newGroup, meeting meeting, bool moveGroup)
        {
            if (moveGroup == true)
            {
                using (var ctx = new SALAHContext())
                {
                    var result = ctx.Groups.SingleOrDefault(g => g.groupID == newGroup.groupID);


                    if (result != null)
                    {
                        newGroup = result;
                    }

                    string[] oldGroupMeetings = oldGroup.meetingIDs.Split(',');

                    for (int i = 0; i < oldGroupMeetings.Length; i++)
                    {
                        if (oldGroupMeetings[i] == meeting.meetingID.ToString())
                        {
                            var result1 = ctx.Groups.SingleOrDefault(g => g.groupID == oldGroup.groupID);
                            if (result1 != null)
                            {
                                result1.meetingIDs = "";

                                for (int j = 0; j < oldGroupMeetings.Length - 1; j++)
                                {
                                    if (i != j)
                                    {
                                        result1.meetingIDs += oldGroupMeetings[j] + ",";
                                    }
                                }
                            }
                        }
                    }
                    group.addMeetingToGroup(newGroup.groupID, meeting.meetingID);
                    ctx.SaveChanges();
                    ctx.Dispose();

                }
            }


        }

        public static bool RemoveMeetingFromGroup(group group, meeting meeting)
        {
            bool meetingRemovedFromGroup = false;

            using (var ctx = new SALAHContext())
            {
                try
                {
                    var result = ctx.Groups.SingleOrDefault(g => g.group_name == group.group_name);
                    if (result != null)
                    {
                        group = result;
                    }

                    string[] oldGroupMeetings = group.meetingIDs.Split(',');

                    for (int i = 0; i < oldGroupMeetings.Length; i++)
                    {
                        if (oldGroupMeetings[i] == meeting.meetingID.ToString())
                        {
                            var result1 = ctx.Groups.SingleOrDefault(g => g.group_name == group.group_name);
                            if (result1 != null)
                            {
                                result1.meetingIDs = "";

                                for (int j = 0; j < oldGroupMeetings.Length - 1; j++)
                                {
                                    if (i != j)
                                    {
                                        result1.meetingIDs += oldGroupMeetings[j] + ",";
                                    }
                                }
                            }
                        }
                    }
                    meetingRemovedFromGroup = true;
                    ctx.SaveChanges();
                    ctx.Dispose();
                }
                catch
                {
                    meetingRemovedFromGroup = false;
                }
            }
            return meetingRemovedFromGroup;
        }

        public static bool RemoveScoutFromGroup(group group, scout scout)
        {
            bool userRemovedFromGroup = false;

            using (var ctx = new SALAHContext())
            {
                try
                {
                    var result = ctx.Groups.SingleOrDefault(g => g.group_name == group.group_name);
                    if (result != null)
                    {
                        group = result;
                    }

                    string[] oldGroupScouts = group.scoutID.Split(',');

                    for (int i = 0; i < oldGroupScouts.Length; i++)
                    {
                        if (oldGroupScouts[i] == scout.scoutID.ToString())
                        {
                            var result1 = ctx.Groups.SingleOrDefault(g => g.group_name == group.group_name);
                            if (result1 != null)
                            {
                                result1.scoutID = "";

                                for (int j = 0; j < oldGroupScouts.Length - 1; j++)
                                {
                                    if (i != j)
                                    {
                                        result1.scoutID += oldGroupScouts[j] + ",";
                                    }
                                }
                            }
                        }
                    }
                    userRemovedFromGroup = true;
                }
                catch
                {
                    userRemovedFromGroup = false;
                }
            }
            return userRemovedFromGroup;
        }


        public static bool deleteGroup(int groupID, user currentUser)
        {
            bool groupDeleted = false;
            group groupQuery = new group();

            using (var ctx = new SALAHContext())
            {
                try
                {
                    groupQuery = ctx.Groups.FirstOrDefault(m => m.groupID == groupID);
                    ctx.Groups.Remove(groupQuery);
                    ctx.SaveChanges();
                    ctx.Dispose();
                    if (user.groupRemovedFromUser(groupID, currentUser))
                        groupDeleted = true;
                }
                catch
                {
                    groupDeleted = false;
                }
            }
            return groupDeleted;
        }
    }
}
