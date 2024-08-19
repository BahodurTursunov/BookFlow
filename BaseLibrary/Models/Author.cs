using System.Text.Json.Serialization;

namespace BookFlow.Models
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public string? Biography { get; set; }

        [JsonIgnore]
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    }
}
