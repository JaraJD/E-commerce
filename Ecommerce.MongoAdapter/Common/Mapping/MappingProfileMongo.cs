using AutoMapper;
using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;

namespace Ecommerce.MongoAdapter.Common.Mapping
{
    public class MappingProfileMongo : Profile
    {
        public MappingProfileMongo() 
        {
            CreateMap<Category, CategoryMongo>().ReverseMap();
            CreateMap<Product, ProductMongo>().ReverseMap(); 
            CreateMap<Sale, SaleMongo>().ReverseMap();
            CreateMap<Store, StoreMongo>().ReverseMap();
            CreateMap<User, UserMongo>().ReverseMap();
        }
    }
}
