using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RamnisrealtNET.Models
{
    public class User : IdentityUser
    {
        
        public DateTime Year { get; set; }

       public string F { get; set; }

       public string I { get; set; }

       public string O { get; set; }

       public string Phon { get; set; }

       public string City { get; set; }

       public string Adres { get; set; }

       public string Pic { get; set; }

    }
}
