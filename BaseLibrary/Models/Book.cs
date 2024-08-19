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

        public Category Category { get; set; } = null!;

        [JsonIgnore]
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

    }
}
