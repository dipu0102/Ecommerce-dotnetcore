using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapicore.Models.Domains
{
    [Table("Category",Schema ="Product")]
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid CategoryId { get; set; }=Guid.NewGuid();
        public string CategoryName { get; set; }
        public Guid? ParentCategoryId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedAt { get; set; }
        [ForeignKey("CategoryId")]
        public Category ParentCategory { get; set; }
        public List<Category> SubCategory { get; set; }=new List<Category>();

    }
}
