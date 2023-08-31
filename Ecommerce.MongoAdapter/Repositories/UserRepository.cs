using AutoMapper;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.Domain.Entities;
using Ecommerce.MongoAdapter.EntitiesMongo;
using MongoDB.Driver;

namespace Ecommerce.MongoAdapter.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<UserMongo> coleccionUser;
        private readonly IMapper _mapper;

        public async Task<List<User>> GetAllUsersAsync()
        {
            var users = await coleccionUser.FindAsync(Builders<UserMongo>.Filter.Eq(b => b.IsDeleted, false));
            var userList = users.ToEnumerable().Select(x => _mapper.Map<User>(x)).ToList();
            if (userList.Count == 0)
            {
                throw new Exception("Users not found.");
            }

            return userList;
        }
    }
}
