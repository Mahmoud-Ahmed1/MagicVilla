using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Test",
                    Details = "im negan",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 3,
                    Sqft = 4,
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.UtcNow,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Testing",
                    Details = "im Mahmoud",
                    ImageUrl = "",
                    Occupancy = 3,
                    Rate = 4,
                    Sqft = 5,
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.UtcNow,
                },
                new Villa()
                { 
                    Id = 3,
                    Name = "software",
                    Details = "negan",
                    ImageUrl = "",
                    Occupancy = 7,
                    Rate = 9,
                    Sqft = 8,
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.UtcNow,
                });

            //modelBuilder.Entity<Villa>()
            //     .HasOne(p => p.AppUser)
            //     .WithMany(p => p.Villa);
        }

    }
}
