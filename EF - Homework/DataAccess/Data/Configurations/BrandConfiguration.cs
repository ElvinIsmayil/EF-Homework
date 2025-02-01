using EF___Homework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF___Homework.DataAccess.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder.HasMany(b => b.Models)
                   .WithOne(m => m.Brand)
                   .HasForeignKey(m => m.BrandId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
