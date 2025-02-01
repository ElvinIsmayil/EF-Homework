using EF___Homework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF___Homework.DataAccess.Data.Configurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder.HasOne(m => m.Brand)
                   .WithMany(b => b.Models)
                   .HasForeignKey(m => m.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Cars)
                   .WithOne(c => c.Model)
                   .HasForeignKey(c => c.ModelId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
