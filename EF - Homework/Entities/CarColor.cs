using EF___Homework.Entities.Common;

namespace EF___Homework.Entities
{
    public class CarColor : BaseEntity
    {
        public int CarId { get; set; }                      
        public Car Car { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
