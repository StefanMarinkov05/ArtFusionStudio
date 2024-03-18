using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures
{
    public class ProductColor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "HexCode is required.")]
        [MaxLength(9, ErrorMessage = "HexCode must not exceed 9 characters.")]
        [RegularExpression(@"^#[a-zA-Z0-9]*$", ErrorMessage = "HexCode must start with '#' followed by alphanumeric characters.")]
        public required string HexCode { get; set; }
    }
}
