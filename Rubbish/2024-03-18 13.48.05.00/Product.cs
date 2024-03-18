using ArtFusionStudio.Models.ProductFeatures;
using ArtFusionStudio.Utility;
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

        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        [RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\s]+$", ErrorMessage = ErrorMessages.REGEX_AZ_ONLY)]
        [StringLength(64, MinimumLength = 2, ErrorMessage = ErrorMessages.OUT_OF_RANGE + " 2 и  64.")]
        public required string Name { get; set; }

        [AllowNull]
        [StringLength(512, MinimumLength = 2, ErrorMessage = ErrorMessages.OUT_OF_RANGE + " 2 и 512.")]
        public string Description { get; set; }

        [AllowNull]
        [Range(0.0, 100000.0, ErrorMessage = ErrorMessages.NOT_NEGATIVE_NUM + " 100000.")]
        public int OldPrice {  get; set; }

        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        [Range(0.0, 100000.0, ErrorMessage = ErrorMessages.NOT_NEGATIVE_NUM + " 100000.")]
        public required int CurrentPrice { get; set; }
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
