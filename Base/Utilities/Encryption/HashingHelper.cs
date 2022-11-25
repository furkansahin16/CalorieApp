using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Base.Utilities.Encryption
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                passwordHash = (hash.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
            
            //using (var hmac = new System.Security.Cryptography.HMACSHA512())
            //{
            //    passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            //}
        }
        
        public static bool VerifyPasswordHash(string password, byte[] passwordHash)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                //for (int i = 0; i < computedHash.Length; i++)
                //{
                //    if (computedHash[i] != passwordHash[i])
                //    {
                //        return false;
                //    }
                //}

                using (SHA256 hash = SHA256Managed.Create())
                {
                    var computedHash = (hash.ComputeHash(Encoding.UTF8.GetBytes(password)));
                    for (int i = 0; i < computedHash.Length; i++)
                    {
                        if (computedHash[i] != passwordHash[i])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
