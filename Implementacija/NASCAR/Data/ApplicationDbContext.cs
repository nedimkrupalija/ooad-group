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
        
        public DbSet<Administrator> Admin { get; set; } 
        public DbSet<RegisteredUser> RegisteredUser { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<DriversLicence> DriversLicence { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<CardDetails> CardDetails { get; set; } 
        public DbSet<Discount> Discount { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Administrator>().ToTable("Admininstrator");
            modelBuilder.Entity<RegisteredUser>().ToTable("RegisteredUser")
                .HasMany(c => c.Reservations)
                .WithOne(p => p.RegisteredUser);
            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");
            modelBuilder.Entity<Reservation>().ToTable("Reservation")
                .HasMany(c => c.Vehicles)
                .WithOne(p => p.Reservation);
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<CardDetails>().ToTable("CardDetails");
               
            modelBuilder.Entity<Discount>().ToTable("Discount");
            modelBuilder.Entity<DriversLicence>().ToTable("DriversLicence")
                .HasOne(c => c.RegisteredUser)
                .WithOne(p => p.Licence);
            base.OnModelCreating(modelBuilder);
        }

    }
}