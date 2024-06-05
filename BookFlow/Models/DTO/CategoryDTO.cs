using System.Text.Json.Serialization;

namespace BookFlow.Models.DTO
{
    public class CategoryDTO
    {
        public string NameDTO { get; set; }

        [JsonIgnore]
        public List<Book> BookIds { get; set; } = [];
    }
}
