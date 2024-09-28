using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapicore.Models.Domains
{
    [Table("Users",Schema ="System")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }= Guid.NewGuid();
        public String UserName { get; set; }
        public string HashPassword { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string? Phone { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid RoleId { get; set; }

    

        public bool IsActive { get; set; }

        public Guid AddressId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedAt { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        [ForeignKey("RoleId")]
        public Roles Roles { get; set; }

    }
}
