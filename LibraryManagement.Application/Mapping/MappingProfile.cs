using AutoMapper;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Book;
using LibraryManagement.DTO.Category;

namespace LibraryManagement.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Book Mapping
            CreateMap<Book, GetAllBookResponse>()  
                .ForMember(dto => dto.CategoryName, opt => opt.MapFrom(b => b.Category.Name));
            CreateMap<CreateBookDTO, Book>();

            //Category Mapping
            CreateMap<Category, CategoryDTO>().ReverseMap();


        }
    }
}
