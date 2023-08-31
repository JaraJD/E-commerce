using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Features.Commands.UserLoginCommands
{
    public class LoginCommand
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
