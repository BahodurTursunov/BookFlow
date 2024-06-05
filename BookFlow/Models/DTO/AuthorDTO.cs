using System.Text.Json.Serialization;

namespace BookFlow.Models.DTO
{
    public class AuthorDTO
    {
        public string? NameDTO { get; set; }
        public string? BiographyDTO { get; set; }
        [JsonIgnore]
        public ICollection<Book> BookIds { get; set; } = new List<Book>();
        [JsonIgnore]
        public ICollection<BookAuthor> BookAuthorIds { get; set; } = new HashSet<BookAuthor>();
    }
}
