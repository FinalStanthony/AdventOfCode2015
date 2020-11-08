using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Adventofcode_2015
{
    class Day4
    {
        static void main()
        {
           for(int i = 0; i < 10000000; i++)
            {
                string res=Hash("yzbqklnj" + i);
                if (res.Substring(0, 6) == "000000")
                {
                    System.Console.WriteLine(i);
                }
            }
            
        }

        static string Hash(string password)
        {
            // given, a password in a string

            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();

            // encoded contains the hash you want
            return encoded;
        }
    }
}
