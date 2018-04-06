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
        public static string passwordValidation(string password1, string password2)
        {
            int MAX_PASSWORD_LENGTH = 16;
            int MIN_PASSWORD_LENGTH = 8;
            int MIN_CAPITAL_LETTERS = 1;
            int MIN_NUMBERS = 1;
            int numCapitals = 0;
            int numNumbers = 0;
            string numbsString = "0123456789";
            string charsString = "abcdefghijklmnopqrstuvwxyz";
            string passwordValid = "";
            bool passwordMatch = true;
            bool aNumber = false;
            bool aLetter = false;
            bool aCapLetter = false;
            bool nonAlphanumericChar = false;
            for (int i = 0; i < password1.Length; i++)
            {
                if (password1[i] != password2[i]) //if at any point two characters of the passwords don't match, then the passwordMatch bool is set to false and a message box is shown to the user
                {
                    passwordMatch = false;
                    break;
                }

            }
            if (passwordMatch == true) //if the two passwords entered match, move onto next part of validation
            {
                int passwordLength = password1.Length; //gets length of password

                if (passwordLength <= MAX_PASSWORD_LENGTH && passwordLength >= MIN_PASSWORD_LENGTH) //is the password the correct length
                {
                    foreach (char letter in password1) //checking each character in password1
                    {
                        
                        for (int i = 0; i < numbsString.Length; i++) //looping through all number chars
                        {
                            char number = numbsString[i];

                            if (letter == number) //is the character a number
                            {
                                numNumbers++;
                                aNumber = true; //yes its a number
                            }
                            
                            if (aNumber == true) //if its a number, break from loop
                                break;
                        }
                        
                        if (aNumber == false) //if its not a number
                        {
                            for (int i = 0; i < charsString.Length; i++) //looping through all letter chars
                            {
                                char letterIterator = charsString[i];

                                char capLetterIterator = char.ToUpper(charsString[i]);

                                if (letter == letterIterator) //is the character a letter
                                {
                                    aLetter = true; //yes, its a letter
                                    break;
                                }
                                if (letter == capLetterIterator) //is it a capital 
                                {
                                    aCapLetter = true; //yes its a capital letter
                                    numCapitals++; 
                                    break;
                                }
                            }
                        }
                        if (aCapLetter == false && aLetter == false && aNumber == false) //if the character is not a letter, capital letter, or number
                        {
                            nonAlphanumericChar = true; //not an alphanumeric character
                            break;
                        }
                        aNumber = false; //reset bool variables
                        aLetter = false;
                        aCapLetter = false;
                        
                    }


                    if (numNumbers < MIN_NUMBERS) //not enough numbers in password
                        passwordValid = "noNums";

                    if (numCapitals < MIN_CAPITAL_LETTERS) //not enough capitals
                        passwordValid = "noCaps";

                    if (nonAlphanumericChar == true) //contains alphanumeric character
                        passwordValid = "nonAlphaChar";

                    if (numNumbers >= MIN_NUMBERS && numCapitals >= MIN_CAPITAL_LETTERS && nonAlphanumericChar == false) //password is valid!
                        passwordValid = "valid";
                }

                if (passwordLength > MAX_PASSWORD_LENGTH || passwordLength < MIN_PASSWORD_LENGTH) //password is too short
                    passwordValid = "tooShort"; 


            }
            if (passwordMatch == false) //passwords entered do not match
                    passwordValid = "nonMatch";

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
                string saltedPassword = salt + password; //combines password and salt
                
                return m_hashcomputer.GetPasswordHashAndSalt(saltedPassword); // hashes salted password

            }

            public static string passwordChecker(string password, string salt)

            {
                string saltedPassword = salt + password; //combines password and salt
                return m_hashcomputer.GetPasswordHashAndSalt(saltedPassword);
            }



            /// <summary>
            /// generates random, unique salt
            /// </summary>
            public static class SaltGenerator
            {
                private static RNGCryptoServiceProvider m_cryptoServiceProvider = null;
                private const int MAX_SALT_SIZE = 8;


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
                    char[] chars = new char[62];
                    chars = "abcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
                    byte[] saltBytes = new byte[MAX_SALT_SIZE]; //byte array to store salt bytes
                    using (m_cryptoServiceProvider)
                    {
                        m_cryptoServiceProvider.GetNonZeroBytes(saltBytes);
                        saltBytes = new byte[MAX_SALT_SIZE];
                        m_cryptoServiceProvider.GetNonZeroBytes(saltBytes);
                    }
                    StringBuilder result = new StringBuilder(MAX_SALT_SIZE);
                    foreach (byte b in saltBytes)
                    {
                        result.Append(chars[b % (chars.Length)]);
                    }

                    
                    return result.ToString();//returns the string

                }

                

            }

            /// <summary>
            /// generate sha256 hash value for string
            /// </summary>
            public class HashComputer
            {
                public string GetPasswordHashAndSalt(string message)
                {
                    using (var sha256 = SHA256.Create())//using the SHA256 algorithm
                    {
                        var hashedbytes = sha256.ComputeHash(Encoding.ASCII.GetBytes(message));//turns string into bytes, hashes the byte array
                        var hash = BitConverter.ToString(hashedbytes).Replace("-", "").ToLower();//converts hashed bytes to string and returns
                        return hash;
                    }
                }
            }
        }
    }
}
