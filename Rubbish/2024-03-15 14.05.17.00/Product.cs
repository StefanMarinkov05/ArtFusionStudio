using ArtFusionStudio.Models.ProductFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public required string Name { get; set; }

        [AllowNull]
        [MaxLength(256)]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int BrandId { get; set; }

        public int RatingId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }

        [ForeignKey("RatingId")]
        public Ratings? Ratings { get; set; }

        public List<ProductColor> Colors { get; set; } = new List<ProductColor>();

        public List<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
    }
}
