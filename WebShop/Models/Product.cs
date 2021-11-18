using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in length.")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Image Link")]
        [StringLength(200, MinimumLength = 15, ErrorMessage = "Must be between {1} and {2} character in length.")]
        public string Img { get; set; }

        [Required]
        [DisplayName("Product Short Description")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Must be between {1} and {2} character in length.")]
        public string Short { get; set; }

        [Required]
        [DisplayName("Product Description")]
        [StringLength(8192, MinimumLength = 40, ErrorMessage = "Must be at least {2} character in length.")]
        public string Description { get; set; }

        [Required]
        [Range(1, 200000, ErrorMessage = "Age must be between {1} and {2}.")]
        public int Price { get; set; }
    }
}
