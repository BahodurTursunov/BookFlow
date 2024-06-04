namespace BookFlow.Models
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public Book? Books { get; set; }
        public int AuthorId { get; set; }
        public BookAuthor? Authors { get; set; }
    }
}
