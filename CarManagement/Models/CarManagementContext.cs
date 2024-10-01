using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarManagement.Models
{
    public class CarManagementContext : IdentityDbContext<Usuario>
    {
        public CarManagementContext(DbContextOptions<CarManagementContext> options) : base(options) 
        {
        
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding Brand
            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Toyota"
                }
            );

            // Seeding Model
            modelBuilder.Entity<Model>().HasData(
                new Model
                {
                    Id = 1,
                    Name = "CH-R",
                    BrandId = 1 // Foreign Key to Brand
                }
            );

            // Seeding Car
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    ModelId = 1,
                    Year = 2020,
                }
            );
        }

    }
}
