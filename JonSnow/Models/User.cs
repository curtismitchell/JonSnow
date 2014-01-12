using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JonSnow.Models
{
    public class User
    {
        public virtual Email Email { get; set; }
        public virtual Hashword Hashword { get; set; }
    }
}