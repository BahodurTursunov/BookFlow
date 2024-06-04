namespace BookFlow.Models
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Book>? Books { get; set; } = new List<Book>();
    }
}
