namespace Ecommerce.Domain.Entities
{
    public class User
    {
        public string UserId { get; set; }
        public string? FullName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set;}
        public string? Address { get; set; }
        public bool IsDeleted { get; set; }
    }
}
