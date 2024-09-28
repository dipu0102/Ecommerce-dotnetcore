using System.ComponentModel.DataAnnotations.Schema;

namespace webapicore.Models.Domains
{
    [Table("Band",Schema ="product")]
    public class Band
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BandId { get; set; }=Guid.NewGuid();
        public string BandName { get; set; }
        public string? BandDescription { get; set;}

        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime? LastUpdatedAt { get;  set; }
        public List<Product> Products { get; set; }
    }
}
