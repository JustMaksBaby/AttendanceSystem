using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; 

namespace AttendanceSystem.PasswordGeneration
{
    public static class PasswordGen
    {
        // set max amount of number for salt that is an integer.
        // min length is 1, max 4 
        private const int SALT_INT_LENTH = 4; 
        public static void CreateHashedPassword(IPasswordInfo passwordInfo)
        {
            passwordInfo.Salt = _CreateRandomIntSalt();
            passwordInfo.HashedPassword = ComputeSaltedHashInt(passwordInfo.OriginalPassword, passwordInfo.Salt);
        }

        /// <summary>
        /// Computes hash for password + salt
        /// Salte is int
        /// </summary>
        /// <param name="originalPassword">password enetered by a user</param>
        /// <param name="salt">salt calculated in _CreateRandomIntSalt</param>
        /// <returns></returns>
        private static string ComputeSaltedHashInt(string originalPassword, int salt)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] passwordBytes = encoder.GetBytes(originalPassword);

            byte[] saltBytes = new byte[SALT_INT_LENTH];
            for(int i = 0; i < SALT_INT_LENTH; i++)
            { 
                int shift = ((SALT_INT_LENTH - 1) * 8) - (i * 8); // first shift 24, second shift is 16 and so on
                saltBytes[i] = (byte)(salt >> shift);  
            }

            byte[] hashedPassword = new byte[passwordBytes.Length + saltBytes.Length];
            Array.Copy(passwordBytes, 0, hashedPassword, 0, passwordBytes.Length);
            Array.Copy(saltBytes, 0, hashedPassword, passwordBytes.Length, saltBytes.Length);

            SHA256 sha1 = SHA256.Create();
            byte[] computedHash = sha1.ComputeHash(hashedPassword);

            return encoder.GetString(computedHash); 
        }

        /// <summary>
        /// Calculates a random salt for user`s passoword
        /// Salt is generated with random numbers
        /// </summary>
        /// <param name="usersPassword">password entered by a user</param>
        /// <returns></returns>
        private static int _CreateRandomIntSalt()
        {
            byte[] randomBytes = new byte[SALT_INT_LENTH];
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            rngCsp.GetBytes(randomBytes);
            rngCsp.Dispose();

            int salt = 0;
            for (int i = 0; i < SALT_INT_LENTH; i++)
            {
                int shift = ((SALT_INT_LENTH - 1) * 8) - (i * 8); 
                salt = (int)randomBytes[i] << shift;
            }

            return salt; 
        }
       
    }
}
