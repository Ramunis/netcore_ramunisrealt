using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamunisrealtNET.Models
{
    public class Cats
    {
        public int ID { get; set; }
        public string Cat { get; set; }

        public static implicit operator Cats(Districts v)
        {
            throw new NotImplementedException();
        }
    }
}
