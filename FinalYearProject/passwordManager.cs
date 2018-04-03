using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSALAH
{
    public static class passwordManager
    {
        /// <summary>
        /// Password validation
        /// </summary>
        /// <param name="password1">first password entered by the user</param>
        /// <param name="password2">second password entered by the user</param>
        /// <returns></returns>
        public static bool passwordValidation(string password1, string password2)
        {
            int MAX_PASSWORD_LENGTH = 16;
            int MIN_PASSWORD_LENGTH = 8;
            int MIN_CAPITAL_LETTERS = 1;
            int MIN_NUMBERS = 1;
            int numCapitals = 0;
            int numNumbers = 0;
            string numbsString = "0123456789";
            bool passwordValid = false;
            bool passwordMatch = true;
            bool aNumber = false;
            for (int i = 0; i < password1.Length; i++)
            {
                if (password1[i] != password2[i]) //if at any point two characters of the passwords don't match, then the passwordMatch bool is set to false and a message box is shown to the user
                {
                    passwordMatch = false;
                    MessageBox.Show("Passwords do not match!");
                    break;
                }

            }
            if (passwordMatch == true) //if the two passwords entered match, move onto next part of validation
            {
                if (password1.Length < MAX_PASSWORD_LENGTH && password1.Length > MIN_PASSWORD_LENGTH)
                {
                    foreach (char letter in password1) //checking each character in password1
                    {
                        for (int i = 0; i < numbsString.Length; i++)
                        {
                            if (letter == numbsString[i])
                            {
                                numNumbers++;
                                aNumber = true;
                            }
                            if (aNumber == true)
                                break;
                        }
                        if (aNumber == false)
                        {
                            if (letter.ToString() == char.ToUpper(letter).ToString())//if the letter directly from the string and the letter that has been capitalised match, then the letter from the string must be a capital
                                numCapitals++; //add 1 to number of capitals in the string
                        }
                    }

                    if (numNumbers >= MIN_NUMBERS && numCapitals >= MIN_CAPITAL_LETTERS)
                        passwordValid = true;
                }
            }
            return passwordValid;
        }

        /// <summary>
        /// Encrypts the plain text password entered by the user
        /// </summary>
        public class HashSaltManager
        {
            static HashComputer m_hashcomputer = new HashComputer(); //initialises new hash computer

            public static string GeneratePasswordHash(string password, out string salt)
            {
                salt = SaltGenerator.GetSaltString(); //retrieves and sets the salt from saltGenerator
                string saltedPassword = password + salt; //combines password and salt
                return m_hashcomputer.GetPasswordHashAndSalt(saltedPassword); // hashes salted password

            }

            public bool passwordChecker(string password, string salt, string hash)

            {
                string finalString = password + salt;
                return hash == m_hashcomputer.GetPasswordHashAndSalt(finalString);
            }



            /// <summary>
            /// generates random, unique salt
            /// </summary>
            public static class SaltGenerator
            {
                private static RNGCryptoServiceProvider m_cryptoServiceProvider = null;
                private const int MAX_SALT_SIZE = 24;


                static SaltGenerator()
                {
                    m_cryptoServiceProvider = new RNGCryptoServiceProvider();
                }

                /// <summary>
                /// returns the generated salt string
                /// </summary>
                /// <returns></returns>
                public static string GetSaltString()
                {
                    byte[] saltBytes = new byte[MAX_SALT_SIZE]; //byte array to store salt bytes
                    m_cryptoServiceProvider.GetNonZeroBytes(saltBytes);//generate salt in the new byte array generated above
                    string saltString = Encoding.ASCII.GetString(saltBytes);// convert byte array to a string
                    return saltString;//returns the string

                }

            }

            /// <summary>
            /// generate sha256 hash value for string
            /// </summary>
            public class HashComputer
            {
                public string GetPasswordHashAndSalt(string message)
                {
                    SHA256 sha = new SHA256CryptoServiceProvider(); //using the SHA256 algorithm
                    byte[] databytes = Encoding.ASCII.GetBytes(message); //turns string into bytes
                    byte[] resultbytes = sha.ComputeHash(databytes); //hashes the byte array
                    return Encoding.ASCII.GetString(resultbytes); //converts hashed bytes to string and returns
                }
            }
        }
    }
}
