using System.Text.Json.Serialization;

namespace BookFlow.Models.DTO
{
    public class BookDTO
    {
        public string? ISBNDTO { get; set; } // уникальный идентификатор книги
        public string? TitleDTO { get; set; } // название книги
        public string? GenreDTO { get; set; } // жанр книги
        public string? DescriptionDTO { get; set; } // описание
        public decimal PriceDTO { get; set; } // цена
        public string? ImageUrlDTO { get; set; } // ссылка на изображение обложки книги
        public int CategoryIdDTO { get; set; } // ID категории

        [JsonIgnore]
        public List<int> AuthorIds { get; set; } = new List<int>(); // Список ID авторов

        [JsonIgnore]
        public CategoryDTO CategoryDTO { get; set; } = null!; // Категория книги
    }


}
