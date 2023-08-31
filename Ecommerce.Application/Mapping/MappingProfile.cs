using AutoMapper;
using Ecommerce.Application.Features.Commands.CategoryCommands;
using Ecommerce.Application.Features.Commands.ProductCommands;
using Ecommerce.Application.Features.Commands.SaleCommands;
using Ecommerce.Application.Features.Commands.StoreCommands;
using Ecommerce.Application.Features.Commands.UserCommands;
using Ecommerce.Application.Features.Queries.CategoryQueries;
using Ecommerce.Application.Features.Queries.ProductQueries;
using Ecommerce.Application.Features.Queries.SaleQueries;
using Ecommerce.Application.Features.Queries.StoreQueries;
using Ecommerce.Application.Features.Queries.UserQueries;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, CategoryQueryVm>().ReverseMap();

            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, ProductQueryVm>().ReverseMap();

            CreateMap<Sale, CreateSaleCommand>().ReverseMap();
            CreateMap<Sale, SaleQueryVm>().ReverseMap();

            CreateMap<Store, CreateStoreCommand>().ReverseMap();
            CreateMap<Store, StoreQueryVm>().ReverseMap();

            CreateMap<User, CreateUserCommand>().ReverseMap();
            CreateMap<User, UserQueryVm>().ReverseMap();
        }
    }
}
