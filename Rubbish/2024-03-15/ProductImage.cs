using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtFusionStudio.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        public required string ImagePath { get; set; }

        public required int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}