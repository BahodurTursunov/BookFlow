using System.Text.Json.Serialization;

namespace BookFlow.Models
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public string? Biography { get; set; }

        public int BookId { get; set; }
        [JsonIgnore]
        public Book Book { get; set; } = null!;

        [JsonIgnore]
        public List<Book> Books { get; set; } = [];
    }
}
