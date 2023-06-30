using System.ComponentModel.DataAnnotations;

namespace ChatAPI_.Models.DTOs
{
    public class RegistrationModel
    {
        public string? Name { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
