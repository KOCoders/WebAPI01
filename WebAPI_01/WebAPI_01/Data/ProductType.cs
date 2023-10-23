using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_01.Data
{
    [Table("ProductType")]
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
        public string Description { get; set; }
       
        public virtual ICollection<Product> Products { get; set; }
    }
}
