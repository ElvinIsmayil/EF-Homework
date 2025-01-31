using EF___Homework.Entities.Common;

namespace EF___Homework.Entities
{
    public class Brand : BaseEntity 
    {

        public List<Model> Models { get; set; }
    }
}
