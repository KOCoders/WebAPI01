using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_01.Data
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        public byte Discount { get; set; }

        public int? ProductTypeID { get; set; }
        [ForeignKey("ProductTypeID")]
        public ProductType ProductType { get; set; }

    }
}
