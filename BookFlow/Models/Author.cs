namespace BookFlow.Models
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public string? Biography { get; set; }
        public ICollection<BookAuthor>? BooksAuthor { get; set; }
    }
}
