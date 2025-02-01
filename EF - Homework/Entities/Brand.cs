using EF___Homework.Entities.Common;

namespace EF___Homework.Entities
{
    public class Brand : BaseEntity 
    {
        public string Name { get; set; }
        public List<Model> Models { get; set; }
    }
}
