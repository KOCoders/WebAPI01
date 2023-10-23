using System.ComponentModel.DataAnnotations;

namespace WebAPI_01.Models
{
    public class ProductTypeModel
    {
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
