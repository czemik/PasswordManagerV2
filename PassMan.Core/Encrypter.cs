using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cryptography;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PassMan.Core
{
    public class Encrypter
    {
        public static string Encrypt(string Key, string Secret)
        {
            string key = GetKey(Key);
            string message = Base64UrlEncoder.Encode(Encoding.Unicode.GetBytes(Secret));
            return Fernet.Encrypt(key, message);
        }

        public static string Decrypt(string Key, string Secret)
        {
            string key = GetKey(Key);
            string encodedSecret = Fernet.Decrypt(key, Secret);
            string message = Encoding.Unicode.GetString(Base64UrlEncoder.DecodeBytes(encodedSecret));
            return message;
        }

        private static string GetKey(string Key)
        {
            using var hashing = SHA256.Create();
            byte[] keyHash = hashing.ComputeHash(Encoding.Unicode.GetBytes(Key));
            string key = Base64UrlEncoder.Encode(keyHash);
            return key;
        }
    }
}
