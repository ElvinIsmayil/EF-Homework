using EF___Homework.Entities.Common;

namespace EF___Homework.Entities
{
    public class Model : BaseEntity
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Name { get; set; }

        public List<Car> Cars { get; set; }
    }
}
