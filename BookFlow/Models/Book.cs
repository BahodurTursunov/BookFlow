namespace BookFlow.Models
{
    public class Book : BaseEntity
    {
        public string? ISBN { get; set; } // уникальный идентификатор книги
        public string? Title { get; set; } // название книги
        public string[]? AuthorId { get; set; } // автор книгиBook
        public string? Publisher { get; set; } // издательство книги
        public DateTime PublicationDate { get; set; } // дата публикации книги
        public string? Genre { get; set; } // жанр книги
        public string? Description { get; set; } // описание
        public string? Language { get; set; } // язык, на котором написана книга
        public decimal Price { get; set; } // цена
        public int Pages { get; set; } // количество страниц в книге
        public string? CoverType { get; set; } // тип обложки (мягкая, твердая)
        public float Weight { get; set; } // вес книги
        public double Rating { get; set; } // рейтинг книги (если есть отзывы пользователей)
        public string? ImageUrl { get; set; } // ссылка на изображение обложки книги
        public string? CategoryId { get; set; } // категория книги
    }
}
