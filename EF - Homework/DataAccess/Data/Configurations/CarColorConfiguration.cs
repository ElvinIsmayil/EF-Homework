using EF___Homework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF___Homework.DataAccess.Data.Configurations
{
    public class CarColorConfiguration : IEntityTypeConfiguration<CarColor>
    {
        public void Configure(EntityTypeBuilder<CarColor> builder)
        {
            builder.HasKey(cc => cc.Id); 

            builder.HasOne(cc => cc.Car)  
                   .WithMany(c => c.CarColors)
                   .HasForeignKey(cc => cc.CarId)
                   .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(cc => cc.Color) 
                   .WithMany(c => c.CarColors)
                   .HasForeignKey(cc => cc.ColorId)
                   .OnDelete(DeleteBehavior.Cascade); 

            builder.ToTable("CarColors"); 
        }
    }
}
