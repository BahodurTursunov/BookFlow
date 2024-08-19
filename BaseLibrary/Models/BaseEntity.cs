using System.Text.Json.Serialization;

namespace BookFlow.Models
{
    public class BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
