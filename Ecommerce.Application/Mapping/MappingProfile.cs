using AutoMapper;
using Ecommerce.Application.Features.Commands.CategoryCommands;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        }
    }
}
