using EF___Homework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF___Homework.DataAccess.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MaxSpeed).IsRequired();
            builder.Property(x => x.FuelTankCapacity).IsRequired();
            builder.Property(x => x.Power).IsRequired();
            builder.Property(x => x.DoorCount).IsRequired();

            builder.HasOne(c => c.Model)
                   .WithMany(m => m.Cars)
                   .HasForeignKey(c => c.ModelId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
