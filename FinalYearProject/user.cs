using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;

namespace theSALAH
{
    public class user
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string StoredSalt { get; set; }
        public string groupIDs { get; set; }

        public user()
        {

        }

        public user(string username, string password)
        {
            Name = username;
            Password = password;
            groupIDs = "";

        }

        public user(int userID, string username, string userGroupIDs)
        {
            ID = userID;
            Name = username;
            groupIDs = userGroupIDs;

        }

        public user(string username, string passwordEntered, string salt)
        {
            Name = username;
            Password = passwordEntered;
            StoredSalt = salt;
            ID = ID++;
            groupIDs = "";
        }

        public user(string username, string passwordEntered, string salt, group group)
        {
            Name = username;
            Password = passwordEntered;
            StoredSalt = salt;
            ID = ID++;
            groupIDs = "";

        }
        /// <summary>
        /// Adds a new user to the user database
        /// </summary>
        /// <param name="user">User object to be added </param>
        /// <returns></returns>
        public static bool AddNewUser(user user)
        {
            bool userAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    ctx.Users.Add(user);
                    ctx.SaveChanges();
                }
                userAdded = true;
                return userAdded;

            }
            catch
            {
                userAdded = false;
                return userAdded;
            }
        }

        /// <summary>
        /// checks the username of a new user against existing usernames to ensure there are no users already using that username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool checkUsername(string username)
        {
            bool usernameUsed = false;

            using (var context = new SALAHContext())
            {
                var query = from data in context.Users
                            where data.Name == username
                            select new { data.Name};
                foreach (var result in query)
                {
                    if (result.Name == username)
                    {
                        usernameUsed = true;
                    }
                }
            }

            return usernameUsed;
        }

        /// <summary>
        /// Checks the login details of a user trying to gain access
        /// </summary>
        /// <param name="user">User to be checked</param>
        /// <returns></returns>
        public static bool checkLogin(user userCheck)
        {
            string username = userCheck.Name;
            string password = userCheck.Password;
            string salt = "";
            bool loginCorrect = false;
            bool userExists = false;
            string existingPassword = "";

            using (var context = new SALAHContext())
            {
                var query = from data in context.Users
                            where data.Name == username
                            select new { data.Name, data.Password, data.StoredSalt };
                foreach (var result in query)
                {

                    user user = new user(result.Name, result.Password, result.StoredSalt);
                    salt = user.StoredSalt;
                    existingPassword = user.Password;
                    userExists = true;
                }

                if (userExists == true)
                {
                    int correctChars = 0;
                    password = passwordManager.HashSaltManager.passwordChecker(password, salt);
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (password[i] == existingPassword[i])
                        {
                            correctChars++;
                        }
                    }
                    if (correctChars == password.Length)
                        loginCorrect = true;
                }
            }
            return loginCorrect;

        }

        /// <summary>
        /// adds a groupID into the users groupIDs string
        /// </summary>
        /// <param name="user">the user the group is being added to</param>
        /// <param name="groupID">the groupID of the group being added to the user</param>
        /// <returns></returns>
        public static bool addGroupToUser(user user, int groupID)
        {
            bool groupAddedToUser = false;
            string groupIDString = groupID.ToString();
            using (var ctx = new SALAHContext())
            {
                try
                {
                    user userQuery = ctx.Users.FirstOrDefault(m => m.ID == user.ID);
                    userQuery.groupIDs = userQuery.groupIDs + groupIDString + ",";
                    ctx.SaveChanges();
                    groupAddedToUser = true;
                }
                catch
                {
                    groupAddedToUser = false;
                }
            }
            return groupAddedToUser;
        }

        /// <summary>
        /// gets the group IDs associated with a user and returns them in a string array
        /// </summary>
        /// <param name="user">user the groups belong to</param>
        /// <returns></returns>
        public static string[] getUsersGroups(user user)
        {
            char stringSplitterChar = ',';
            string groupIDs = user.groupIDs;
            string[] groupIDsArray = groupIDs.Split(stringSplitterChar);
            return groupIDsArray;
        }



        /// <summary>
        /// adds the users groups into the combobox for selection
        /// </summary>
        /// <param name="comboBox">target combo box</param>
        /// <param name="groups">string array of groups to be added</param>
        public static void AddGroupsToComboBox(ComboBox comboBox, string[] groups)
        {
            int length = groups.Length; //get length of the groupID array

            int groupID = 0;

            string[] groupNames = new string[length]; //new array to hold the names of the groups

            using (var ctx = new SALAHContext())
            {
                for (int i = 0; i < length; i++)
                {
                    if (groups[i] != "")
                    {
                        groupID = int.Parse(groups[i]); //parse the groupID from the groupID string array into a int variable

                        var query = from data in ctx.Groups //create a query to find the name of the group from the groupID
                                    where data.groupID == groupID
                                    select new { data.group_name };

                        foreach (var result in query)
                        {
                            groupNames[i] = result.group_name; //add the group name into the groupnames array
                        }


                        comboBox.Items.Add(groupNames[i]); //add the latest array entry into the combobox
                    }
                    
                }
            }
        }
    }
}
