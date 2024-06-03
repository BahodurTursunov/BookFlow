namespace BookFlow.Models
{
    public class Book : BaseEntity
    {
        public string? ISBN { get; set; } // уникальный идентификатор книги
        public string? Title { get; set; } // название книги
        public string[]? Author { get; set; } // автор книги
        public string? Publisher { get; set; } // издательство книги
        public DateTime PublicationDate { get; set; } // дата публикации книги
        public string? Genre { get; set; } // жанр книги
        public string? Description { get; set; } // описание
        public string? Language { get; set; } // язык, на котором написана книга
        public decimal Price { get; set; } // цена
        public int Pages { get; set; } // количество страниц в книге
        public string? CoverType { get; set; } // тип обложки (мягкая, твердая)
        public string? Dimensions { get; set; } // размеры книги (высота, ширина, толщина
        public float Weight { get; set; } // вес книги
        public double Rating { get; set; } // рейтинг книги (если есть отзывы пользователей)
        public int StockQuantity { get; set; } //  количество экземпляров книги на складе
        public string? ImageUrl { get; set; } // ссылка на изображение обложки книги
        public string? Category { get; set; } // категория книги
        public string? Edition { get; set; } // информация об издании
        public string? Series { get; set; } // информация о серии, если книга является частью серии
        public string? Barcode { get; set; } // штрихкод книги
    }
}
