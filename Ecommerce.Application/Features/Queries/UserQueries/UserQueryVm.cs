using Ecommerce.Domain.Common;

namespace Ecommerce.Application.Features.Queries.UserQueries
{
    public class UserQueryVm
    {
        public string UserId { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Enums.Roles Role { get; set; }
        public string? Address { get; set; }
    }
}
