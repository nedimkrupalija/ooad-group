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
        
        
        public DbSet<RegisteredUser> RegisteredUser { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<DriversLicence> DriversLicence { get; set; }
        public DbSet<VehicleAddress> VehicleAddress { get; set; }
        public DbSet<CardDetails> CardDetails { get; set; } 
        public DbSet<Discount> Discount { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
            modelBuilder.Entity<RegisteredUser>().ToTable("RegisteredUser")
                .HasMany(c => c.Reservations)
                .WithOne(p => p.RegisteredUser);
            modelBuilder.Entity<RegisteredUser>()
                .Property(e => e.FirstName)
                .HasMaxLength(250);
            modelBuilder.Entity<RegisteredUser>()
                .Property(e => e.LastName)
                .HasMaxLength(250);
            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");

            modelBuilder.Entity<Reservation>().ToTable("Reservation");


            modelBuilder.Entity<VehicleAddress>().ToTable("VehicleAddress");
                
            modelBuilder.Entity<CardDetails>().ToTable("CardDetails")
                .HasOne(c => c.RegisteredUser)
                .WithOne(p => p.CardDetails);
               
            modelBuilder.Entity<Discount>().ToTable("Discount");
            modelBuilder.Entity<DriversLicence>().ToTable("DriversLicence")
                .HasOne(c => c.RegisteredUser)
                .WithOne(p => p.Licence);
            base.OnModelCreating(modelBuilder);
        }

    }
}