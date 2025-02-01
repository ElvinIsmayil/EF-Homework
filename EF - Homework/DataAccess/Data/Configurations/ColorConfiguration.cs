using EF___Homework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF___Homework.DataAccess.Data.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.HasMany(c => c.CarColors)
                   .WithOne(cc => cc.Color)
                   .HasForeignKey(cc => cc.ColorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
