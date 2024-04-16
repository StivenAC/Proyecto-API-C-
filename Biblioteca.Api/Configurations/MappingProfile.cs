using AutoMapper;
using Biblioteca.Api.DTO;
using Biblioteca.Api.Model;

namespace Biblioteca.Api.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Libro, LibroDTO>().ReverseMap();
            CreateMap<Autor, AutorDTO>().ReverseMap();



        }
    }
}
