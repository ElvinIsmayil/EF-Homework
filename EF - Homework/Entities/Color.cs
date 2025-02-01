using EF___Homework.Entities.Common;

namespace EF___Homework.Entities
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }
        public List<CarColor> CarColors { get; set; }
    }
}
