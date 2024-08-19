using System.Text.Json.Serialization;

namespace BookFlow.Models
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }

        [JsonIgnore]
        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
