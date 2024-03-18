using ArtFusionStudio.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Physical
{
    public class USB
    {
        [Key]
        public int Id { get; set; }

        //Micro-A, Type-C
        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        [RegularExpression(@"^(?=.*[a-zA-Z])[a-zA-Z\s]+$", ErrorMessage = ErrorMessages.REGEX_AZ_ONLY)]
        [StringLength(32, MinimumLength = 2, ErrorMessage = ErrorMessages.OUT_OF_RANGE + " 2 и 32.")]
        public required string Type { get; set; }
    }
}
