namespace BookFlow.Models
{
    public class BookCategory : BaseEntity
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public Book? Book { get; set; }
        public Category? Category { get; set; }
    }
}
