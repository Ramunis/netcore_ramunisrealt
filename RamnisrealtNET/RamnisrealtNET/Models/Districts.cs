using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamunisrealtNET.Models
{
    public class Districts
    {
        public int ID { get; set; }
        public string District { get; set; }

        public static implicit operator Districts(string v)
        {
            throw new NotImplementedException();
        }
    }
}
