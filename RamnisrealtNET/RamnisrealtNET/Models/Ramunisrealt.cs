using Microsoft.EntityFrameworkCore;
using RamnisrealtNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamunisrealtNET.Models
{
    public class Ramunisrealt : DbContext
    {
        public Ramunisrealt()            //конструкторы класса
        { }
        public Ramunisrealt(DbContextOptions<Ramunisrealt> options)
        : base(options)
        { }

        public DbSet<User> User { get; set; }
        public DbSet<Servics> Servics { get; set; }
        public DbSet<Districts> Districts { get; set; }

        public DbSet<Cats> Cats { get; set; }
        public DbSet<Reps> Reps { get; set; }

        public DbSet<Contracts> Contracts { get; set; }

        public DbSet<FileModel> Files { get; set; }

        public DbSet<Achives> Achives { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ASUSH510M-K; Database=realtstore; Trusted_Connection = True;");
                //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=111; Trusted_Connection = True; ");
            }
        }

       

    }
}
