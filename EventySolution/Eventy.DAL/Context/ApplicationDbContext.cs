using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventy.DAL.Entities.EventModule;
using Eventy.DAL.Entities.UserModule;
using Eventy.DAL.Entities.VolunteerModule;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eventy.DAL.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<EventyEvent> EventyEvents { get; set; }
        public DbSet<Commitee> Commitees { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
