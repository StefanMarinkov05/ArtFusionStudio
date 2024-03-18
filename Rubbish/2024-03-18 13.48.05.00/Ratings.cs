using ArtFusionStudio.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures
{
    public class Ratings
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        [Range(1,5, ErrorMessage = ErrorMessages.OUT_OF_RANGE_NUM + " 1 и 5.")]
        public required byte Rate { get; set; }

        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "2020-01-01", "{0:yyyy-MM-dd}", ErrorMessage = ErrorMessages.INVLID_DATE)]
        public required DateTime ReviewTime { get; set; }

        [AllowNull]
        public required string Review { get; set; }
    }
}
