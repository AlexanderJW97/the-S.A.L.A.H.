using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace theSALAH
{
    public class user
    {
        [Key]
        public int userID { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public ICollection<group> groups { get; set; }
        
        public user()
        {

        }

        public user(string username, string passwordEntered)
        {
            name = username;
            password = passwordEntered;
            userID = userID++;
            
        }
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
    }
}
