namespace BookFlow.Models
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public string? Biography { get; set; }
        public ICollection<Book>? Books { get; set; } = new List<Book>();
    }
}
