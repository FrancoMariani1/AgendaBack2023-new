using System.ComponentModel.DataAnnotations;

namespace AgendaBack2023.Models.DTO
{
    public class AuthenticationRequestBody
    {
        [Required]
        public string? email { get; set; }
        [Required]
        public string? password { get; set; }
    }
}
