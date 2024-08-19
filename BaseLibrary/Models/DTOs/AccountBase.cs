using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookFlow.Models.DTOs
{
    public class AccountBase
    {
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [PasswordPropertyText]
        [Required]
        public string? Password { get; set; }
    }
}

