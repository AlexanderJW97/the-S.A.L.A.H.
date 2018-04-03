using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Data.Entity;

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

        public user(string username, string password)
        {
            Name = username;
            Password = password;
        }

        public user(string username, string passwordEntered, string salt)
        {
            Name = username;
            Password = passwordEntered;
            StoredSalt = salt;
            ID = ID++;
            
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
                    break;
                }

                if(query != null)
                {
                    int correctChars = 0;
                    password = passwordManager.HashSaltManager.GeneratePasswordHash(password, out salt);
                    for(int i =0; i <password.Length; i++)
                    {
                        if(password[i] == existingPassword[i])
                        {
                            correctChars++;
                        }
                    }
                    if (correctChars==password.Length)
                        loginCorrect = true;
                }
            }
            return loginCorrect;
            
        }
    }
}
