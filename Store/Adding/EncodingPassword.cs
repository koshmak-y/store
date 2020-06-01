using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Adding
{
    public static class EncodingPassword
    {
        public static string Encryption(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            for (int i = 0; i < bytes.Length; i++) bytes[i] ^= 0x5a;
            return Convert.ToBase64String(bytes);
        }
        public static string Decryption(string password)
        {
            var bytes = Convert.FromBase64String(password);
            for (int i = 0; i < bytes.Length; i++) bytes[i] ^= 0x5a;
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
