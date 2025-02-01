using EF___Homework.Entities.Common;

namespace EF___Homework.Entities
{
    public class Car : BaseEntity 
    {
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public List<CarColor> CarColors { get; set; }
        public double MaxSpeed { get; set; }
        public double FuelTankCapacity { get; set; }
        public int Power { get; set; }
        public int DoorCount { get; set; }

    }
}
