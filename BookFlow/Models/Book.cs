using System.Text.Json.Serialization;

namespace BookFlow.Models
{
    public class Book : BaseEntity
    {
        public string? ISBN { get; set; } // уникальный идентификатор книги
        public string? Title { get; set; } // название книги
        public string? Genre { get; set; } // жанр книги
        public string? Description { get; set; } // описание
        public decimal Price { get; set; } // цена
        public string? ImageUrl { get; set; } // ссылка на изображение обложки книги
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category Category { get; set; } = null!;
        public int AuthorId { get; set; }

        [JsonIgnore]
        public Author Author { get; set; } = null!;

        [JsonIgnore]
        public List<Author> Authors { get; set; } = [];

    }
}
