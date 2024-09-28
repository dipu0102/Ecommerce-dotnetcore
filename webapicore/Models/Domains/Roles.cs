using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapicore.Models.Domains
{
    [Table("Roles",Schema ="System")]
    public class Roles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid RoleId { get; set; }= Guid.NewGuid();
        public String RoleName { get; set; }
        public String? RoleDescription { get; set; }
        public string? Permission {  get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedAt { get; set; }

        public User User { get; set; }

    }
}
