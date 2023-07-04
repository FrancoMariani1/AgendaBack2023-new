using AgendaBack2023.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace AgendaBack2023.Models.DTO
{
    public class CreateAndUpdateUserDTO
    {   
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }


        public Rol Rol { get; set; } = Rol.User;
    }
}
