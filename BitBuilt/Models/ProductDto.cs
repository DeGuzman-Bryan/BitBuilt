using System.ComponentModel.DataAnnotations;

namespace BitBuilt.Models
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]

        public string Brand { get; set; } = "";

        [Required]

        public string Category { get; set; } = "";

        [Required]

        public string Price { get; set; } = "";

        [Required]

        public string Description { get; set; } = "";

        public IFormFile? ImageFile { get; set; }
    }
}
