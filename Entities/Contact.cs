using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaBack2023.Entities
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string? avatar { get; set; }
        public string description { get; set; }
        public string? email { get; set; }
        public long celularNumber { get; set; }
        public long? telephoneNumber { get; set; }

        [ForeignKey("Userid")]
        //public User user { get; set; }
        public int Userid { get; set; }

        public Location location { get; set; }
    }
}
