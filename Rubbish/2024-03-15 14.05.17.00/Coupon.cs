using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures
{
    public class Coupon
    {
        [Key]
        [Range(0, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public required string DiscountCode { get; set; }

        [Required]
        [Range(0.0,99.9)]
        public required decimal DiscountPercentage { get; set; }

        [Range(0, int.MaxValue)]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}
