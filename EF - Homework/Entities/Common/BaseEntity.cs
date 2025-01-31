namespace EF___Homework.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedData { get; set; }
        public bool IsDeleted { get; set; } 


    }
}
