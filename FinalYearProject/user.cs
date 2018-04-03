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
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string StoredSalt { get; set; }

        public ICollection<group> groups { get; set; }
        
        public user()
        {

        }

        public user(string username, string passwordEntered, string salt)
        {
            Name = username;
            Password = passwordEntered;
            StoredSalt = salt;
            ID = ID++;
            
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
