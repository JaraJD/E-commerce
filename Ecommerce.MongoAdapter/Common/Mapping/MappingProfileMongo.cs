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
        }
    }
}
