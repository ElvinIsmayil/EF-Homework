using EF___Homework.Entities.Common;

namespace EF___Homework.Entities
{
    public class Car : BaseEntity 
    {
        public int ModelId { get; set; }
        public Model Model { get; set; }

    }
}
