namespace BookFlow.Models
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public Book? Book { get; set; }
        public BookAuthor? Author { get; set; }
    }
}
