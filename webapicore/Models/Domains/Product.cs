using System.ComponentModel.DataAnnotations.Schema;

namespace webapicore.Models.Domains
{
    [Table("Product",Schema ="product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }= Guid.NewGuid();
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int StockQuantity { get; set; }
       public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }
        public Guid BandId { get; set; }
        [ForeignKey("BandId")]
        public Band Band { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedAt { get; set; }


    }
}
