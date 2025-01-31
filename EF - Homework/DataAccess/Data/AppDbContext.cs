using EF___Homework.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF___Homework.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
       
        DbSet<Brand> Brands { get; set; }
        DbSet<Model> Models { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<Color> Colors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CIU9UU4\\SQLEXPRESS;Database=PB503CarGallery;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
