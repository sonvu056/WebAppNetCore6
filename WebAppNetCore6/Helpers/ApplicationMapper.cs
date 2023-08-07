using AutoMapper;
using WebAppNetCore6.Data;
using WebAppNetCore6.Models;

namespace WebAppNetCore6.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() {
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
