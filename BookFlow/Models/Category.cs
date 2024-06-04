namespace BookFlow.Models
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; } = new List<BookCategory>();
    }
}
