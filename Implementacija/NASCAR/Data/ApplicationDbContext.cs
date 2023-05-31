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
        public DbSet<Admin> Admin { get; set; } 
        public DbSet<RegisteredUser> RegisteredUser { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<DriversLicence> DriversLicence { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<CardDetails> CardDetails { get; set; } 
        public DbSet<Discount> Discount { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<RegisteredUser>().ToTable("RegisteredUser");
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