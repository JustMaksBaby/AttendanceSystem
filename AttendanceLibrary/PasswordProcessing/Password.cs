using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography; 

namespace AttendanceLibrary.PasswordProcessing
{

    /// <summary>
    /// Creates  new hashed passwords
    /// Comparares hashed and unhashed passwords
    /// </summary>
    public static class Password
    {
        /// <summary>
        /// Fills in Salt and Hashedpassword properties in user model
        /// </summary>
        public static void CreateHashedPassword(IPasswordInfo passwordInfo)
        {
            passwordInfo.Salt = _CreateRandomSaltUInt();
            passwordInfo.HashedPassword = _ComputeSaltedHash(passwordInfo.OriginalPassword, passwordInfo.Salt);
        }
        public static bool AreEquil(IPasswordInfo userFromDb, IPasswordInfo testedUser)
        {
            string tempHash = _ComputeSaltedHash(testedUser.OriginalPassword, userFromDb.Salt);

            return userFromDb.HashedPassword == tempHash;
        } 

        /// <summary>
        /// Computes hash for password + salt
        /// </summary>
        /// <param name="originalPassword">password enetered by a user</param>
        private static string _ComputeSaltedHash(string originalPassword, string salt)
        {            
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] bytesToHash = encoder.GetBytes(originalPassword + salt);  

            //calculate hash value for password + salt
            SHA256 sha256 = SHA256.Create();
            byte[] computedHash = sha256.ComputeHash(bytesToHash);

            
            return encoder.GetString(computedHash); 
        }

        /// <summary>
        /// Calculates a random integer 
        /// </summary>
        private static string _CreateRandomSaltUInt()
        {
            byte[] randomBytes = new byte[4];
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            rngCsp.GetBytes(randomBytes);
            rngCsp.Dispose();

            //make integer from random bytes
            uint salt = 0;
            for (int i = 0; i < 4; i++)
            {
                int shift = ((3) * 8) - (i * 8); 
                salt += (uint)randomBytes[i] << shift;
            }

            return salt.ToString(); 
        }

    }
}
