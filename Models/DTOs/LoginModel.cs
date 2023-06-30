using System.ComponentModel.DataAnnotations;

namespace ChatAPI_.Models.DTOs
{
    public class LoginModel
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
