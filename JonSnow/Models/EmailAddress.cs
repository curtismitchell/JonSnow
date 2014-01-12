using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JonSnow.Models
{
    public class Email
    {
        [EmailAddress]
        public string Address { get; set; }
        public Email(string email)
        {
            Address = email;
        }

        public override string ToString()
        {
            return Address;
        }
    }
}