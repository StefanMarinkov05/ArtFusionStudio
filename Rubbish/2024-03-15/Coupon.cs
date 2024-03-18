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
        public int Id { get; set; }

        [Required]
        public required string DiscountCode { get; set; }

        [Required]
        public required decimal DiscountPercentage { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}
