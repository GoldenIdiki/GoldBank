using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GoldBankLite.Common
{
    public class Utilities
    {
        // Sanitize the input
        // Select only letters
        public static string Sanitize(string text)
        {
            if (text.Length < 1) return null;

            var cleanUp = text.Where(x => char.IsLetter(x)).ToList();
            var joinCleanUp = string.Join("", cleanUp);
            return joinCleanUp;
        }

        // Check validity of email address
        public static bool IsEmailValid(string email)
        {
            string pattern = @"^[\w\d\.]+@[a-zA-Z]+\.(com||co\.uk)$";
            return Regex.IsMatch(email, pattern);
        }

        // Generate hash
        public static List<byte[]> GenerateHash(string password)
        {
            byte[] passwordSalt, passwordHash;

            // convert password to hash value and generate salt
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hash.Key;
                passwordHash = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            var result = new List<byte[]>();
            result.Add(passwordHash);
            result.Add(passwordSalt);

            return result;
        }


        // compare password hash
        public static bool CompareHash(byte[] passwordSalt, byte[] passwordHash, string password)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var hashGenerated = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < hashGenerated.Length; i++)
                {
                    if (hashGenerated[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
