using AutoMapper;
using BookFlow.Models;
using BookFlow.Models.DTO;

namespace BookFlow.Mapper
{
    public class BookDTOBook : Profile
    {
        public BookDTOBook()
        {
            CreateMap<BookDTO, Book>()
                .ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBNDTO))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.TitleDTO))
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.GenreDTO))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.DescriptionDTO))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.PriceDTO))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrlDTO))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryIdDTO))
                .ReverseMap();
        }
    }
}
