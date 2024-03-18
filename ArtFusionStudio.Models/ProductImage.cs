using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArtFusionStudio.Utility;

namespace ArtFusionStudio.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        public required string ImagePath { get; set; }

        [Required(ErrorMessage = ErrorMessages.NO_CHOSEN_ID)]
        public required int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}