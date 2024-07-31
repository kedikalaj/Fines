using Fines.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fines.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Fine> Fine { get; set; }

        public static async Task Initialize(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Check if the user already exists
            if (await userManager.FindByNameAsync("admin@example.com") == null)
            {
                // Create a new user
                var user = new IdentityUser
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com"
                };

                var result = await userManager.CreateAsync(user, "Admin@1234");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Vehicles
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { VehicleId = 1, LicensePlate = "AA 123 BB" },
                new Vehicle { VehicleId = 2, LicensePlate = "BB 456 CC" },
                new Vehicle { VehicleId = 3, LicensePlate = "CC 789 DD" },
                new Vehicle { VehicleId = 4, LicensePlate = "DD 012 EE" },
                new Vehicle { VehicleId = 5, LicensePlate = "EE 345 FF" },
                new Vehicle { VehicleId = 6, LicensePlate = "FF 678 GG" },
                new Vehicle { VehicleId = 7, LicensePlate = "GG 901 HH" },
                new Vehicle { VehicleId = 8, LicensePlate = "HH 234 II" },
                new Vehicle { VehicleId = 9, LicensePlate = "II 567 JJ" },
                new Vehicle { VehicleId = 10, LicensePlate = "JJ 890 KK" }
            );

            modelBuilder.Entity<Fine>().HasData(

                new Fine { Id = 1, DateOfFine = DateTime.Now.AddDays(-1), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 1 },
                new Fine { Id = 2, DateOfFine = DateTime.Now.AddDays(-2), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 1 },
                new Fine { Id = 3, DateOfFine = DateTime.Now.AddDays(-3), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 1 },
                new Fine { Id = 4, DateOfFine = DateTime.Now.AddDays(-4), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 2 },
                new Fine { Id = 5, DateOfFine = DateTime.Now.AddDays(-5), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 2 },
                new Fine { Id = 6, DateOfFine = DateTime.Now.AddDays(-6), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 2 },
                new Fine { Id = 7, DateOfFine = DateTime.Now.AddDays(-7), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 4 },
                new Fine { Id = 8, DateOfFine = DateTime.Now.AddDays(-8), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 4 },
                new Fine { Id = 9, DateOfFine = DateTime.Now.AddDays(-9), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 4 },
                new Fine { Id = 10, DateOfFine = DateTime.Now.AddDays(-10), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 5 },
                new Fine { Id = 11, DateOfFine = DateTime.Now.AddDays(-11), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 5 },
                new Fine { Id = 12, DateOfFine = DateTime.Now.AddDays(-12), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 5 },
                new Fine { Id = 13, DateOfFine = DateTime.Now.AddDays(-13), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 6 },
                new Fine { Id = 14, DateOfFine = DateTime.Now.AddDays(-14), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 6 },
                new Fine { Id = 15, DateOfFine = DateTime.Now.AddDays(-15), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 6 },
                new Fine { Id = 16, DateOfFine = DateTime.Now.AddDays(-16), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 7 },
                new Fine { Id = 17, DateOfFine = DateTime.Now.AddDays(-17), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 7 },
                new Fine { Id = 18, DateOfFine = DateTime.Now.AddDays(-18), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 7 },
                new Fine { Id = 19, DateOfFine = DateTime.Now.AddDays(-19), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 8 },
                new Fine { Id = 20, DateOfFine = DateTime.Now.AddDays(-20), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 8 },
                new Fine { Id = 21, DateOfFine = DateTime.Now.AddDays(-21), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 8 },
                new Fine { Id = 22, DateOfFine = DateTime.Now.AddDays(-22), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 9 },
                new Fine { Id = 23, DateOfFine = DateTime.Now.AddDays(-23), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 9 },
                new Fine { Id = 24, DateOfFine = DateTime.Now.AddDays(-24), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 9 },
                new Fine { Id = 25, DateOfFine = DateTime.Now.AddDays(-25), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 10 },
                new Fine { Id = 26, DateOfFine = DateTime.Now.AddDays(-26), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 10 },
                new Fine { Id = 27, DateOfFine = DateTime.Now.AddDays(-27), Reason = "Mungesë sigurie", Amount = 75, PaymentDate = null, IsPaid = false, VehicleId = 10 },
                new Fine { Id = 28, DateOfFine = DateTime.Now.AddDays(-28), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 1 },
                new Fine { Id = 29, DateOfFine = DateTime.Now.AddDays(-29), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 1 },
                new Fine { Id = 30, DateOfFine = DateTime.Now.AddDays(-30), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 2 },
                new Fine { Id = 31, DateOfFine = DateTime.Now.AddDays(-31), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 2 },
                new Fine { Id = 32, DateOfFine = DateTime.Now.AddDays(-32), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 4 },
                new Fine { Id = 33, DateOfFine = DateTime.Now.AddDays(-33), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 4 },
                new Fine { Id = 34, DateOfFine = DateTime.Now.AddDays(-34), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 5 },
                new Fine { Id = 35, DateOfFine = DateTime.Now.AddDays(-35), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 5 },
                new Fine { Id = 36, DateOfFine = DateTime.Now.AddDays(-36), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 6 },
                new Fine { Id = 37, DateOfFine = DateTime.Now.AddDays(-37), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 6 },
                new Fine { Id = 38, DateOfFine = DateTime.Now.AddDays(-38), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 7 },
                new Fine { Id = 39, DateOfFine = DateTime.Now.AddDays(-39), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 7 },
                new Fine { Id = 40, DateOfFine = DateTime.Now.AddDays(-40), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 8 },
                new Fine { Id = 41, DateOfFine = DateTime.Now.AddDays(-41), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 8 },
                new Fine { Id = 42, DateOfFine = DateTime.Now.AddDays(-42), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 9 },
                new Fine { Id = 43, DateOfFine = DateTime.Now.AddDays(-43), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 9 },
                new Fine { Id = 44, DateOfFine = DateTime.Now.AddDays(-44), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 10 },
                new Fine { Id = 45, DateOfFine = DateTime.Now.AddDays(-45), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 10 },
                new Fine { Id = 46, DateOfFine = DateTime.Now.AddDays(-46), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 1 },
                new Fine { Id = 47, DateOfFine = DateTime.Now.AddDays(-47), Reason = "Shpejtësi e tepërt", Amount = 100, PaymentDate = null, IsPaid = false, VehicleId = 1 },
                new Fine { Id = 48, DateOfFine = DateTime.Now.AddDays(-48), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 2 },
                new Fine { Id = 49, DateOfFine = DateTime.Now.AddDays(-49), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 4 },
                new Fine { Id = 50, DateOfFine = DateTime.Now.AddDays(-50), Reason = "Parkim i paligjshëm", Amount = 50, PaymentDate = null, IsPaid = false, VehicleId = 5 }
            );
        }
    }
}
