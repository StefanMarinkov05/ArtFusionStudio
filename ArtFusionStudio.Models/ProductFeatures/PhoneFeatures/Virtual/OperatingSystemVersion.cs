using ArtFusionStudio.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Virtual
{
    public class OperatingSystemVersion
    {
        [Key]
        public int Id { get; set; }

        //13.20
        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        //[Column(TypeName = "decimal(2, 2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = ErrorMessages.INVALID_DECIMAL)]
        [Range(0, 99, ErrorMessage = ErrorMessages.OUT_OF_RANGE_NUM + " и по-малко от 99.")]
        public required decimal OSVersion { get; set; }
    }
}
