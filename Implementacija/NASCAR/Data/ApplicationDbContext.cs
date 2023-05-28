using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NASCAR.Models;
namespace NASCAR.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<User>().ToTable("User")
                .HasDiscriminator<string>("UserType")
                .HasValue<RegisteredUser>("RegisteredUser")
                .HasValue<Admin>("Admin");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<CardDetails>().ToTable("CardDetails");
            modelBuilder.Entity<Discount>().ToTable("Discount");
            modelBuilder.Entity<DriversLicence>().ToTable("DriversLicence");
            
            base.OnModelCreating(modelBuilder);
        }

    }
}