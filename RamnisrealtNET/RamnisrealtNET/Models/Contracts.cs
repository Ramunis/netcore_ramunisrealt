using RamnisrealtNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamunisrealtNET.Models
{
    public class Contracts
    {
        public int ID { get; set; }

        public DateTime DZ { get; set; }

        public string Client { get; set; }

        public string Realtor { get; set; }
        public Cats Categor { get; set; }

        public Districts District { get; set; }

        public string City { get; set; }

        public string Adres { get; set; }

        public string About { get; set; }

        public Servics Service { get; set; }

        public int Sq { get; set; }

        public int Level { get; set; }

        public DateTime DS { get; set; }

        public int Term { get; set; }

        public decimal Price { get; set; }

        public string Pay { get; set; }

        public Reps Repair { get; set; }

        public string Pic { get; set; }

    }
}
