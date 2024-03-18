using ArtFusionStudio.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneAccessories
{
    public class CaseMaterial
    {
        [Key]
        public int Id { get; set; }

        //Leather, silicone, PVC
        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        [StringLength(32, MinimumLength = 2, ErrorMessage = ErrorMessages.OUT_OF_RANGE + "2 и 32.")]
        public required string Name { get; set; }
    }
}
