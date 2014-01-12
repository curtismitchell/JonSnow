using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace JonSnow.Models
{
    public class Hashword
    {
        private byte[] pwd;
        private Encoding encoding = Encoding.Default;
        public Hashword(string password)
        {
            CreateHash(password);
        }

        void CreateHash(string plainText)
        {
            var hasher = SHA256Cng.Create();
            pwd = hasher.ComputeHash(encoding.GetBytes(plainText));
        }
        public bool IsSameAs(Hashword pwd2)
        {
            return ToString().Equals(pwd2.ToString(), StringComparison.InvariantCulture);
        }

        public override string ToString()
        {
            return encoding.GetString(pwd);
        }
    }
}