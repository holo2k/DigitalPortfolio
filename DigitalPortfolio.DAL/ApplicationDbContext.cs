using DigitalPortfolio.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPortfolio.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
            //Database.EnsureDeleted();
        }

        public DbSet<User> User { get; set; }
        public DbSet<Work> Work { get; set; }
        public DbSet<Profile> Profile { get; set; }

    }
}
