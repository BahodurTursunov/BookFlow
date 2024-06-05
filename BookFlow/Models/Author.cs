using System.Text.Json.Serialization;

namespace BookFlow.Models
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public string? Biography { get; set; }

        [JsonIgnore]
        public List<BookAuthor> BookAuthors { get; set; } = [];

        [JsonIgnore]
        public List<Book> Books { get; set; } = [];
    }
}
