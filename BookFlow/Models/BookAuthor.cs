using System.Text.Json.Serialization;

namespace BookFlow.Models
{
    public class BookAuthor : BaseEntity
    {
        public int BookId { get; set; }

        [JsonIgnore]
        public Book Book { get; set; } = null!;

        public int AuthorId { get; set; }

        [JsonIgnore]
        public Author Author { get; set; } = null!;

    }
}
