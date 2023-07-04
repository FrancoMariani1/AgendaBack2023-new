using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AgendaBack2023.Models.Enum;

namespace AgendaBack2023.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public State state { get; set; } = State.Active;
        public Rol Rol { get; set; } = Rol.User;
    }
}
