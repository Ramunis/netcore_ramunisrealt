using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RamunisrealtNET.Models;

namespace RamnisrealtNET.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Servics> Servics { get; set; }
        public DbSet<Districts> Districts { get; set; }

        public DbSet<Cats> Cats { get; set; }
        public DbSet<Reps> Reps { get; set; }

        public DbSet<Contracts> Contracts { get; set; }

        public DbSet<FileModel> Files { get; set; }

        public DbSet<Achives> Achives { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
