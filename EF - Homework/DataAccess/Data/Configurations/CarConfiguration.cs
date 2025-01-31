using EF___Homework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EF___Homework.DataAccess.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
       
            public void Configure(EntityTypeBuilder<Car> builder)
            {
                builder.HasKey(x => x.Id);

            }
        
    }
}
