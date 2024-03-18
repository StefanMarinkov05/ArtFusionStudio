using ArtFusionStudio.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Physical
{
    public class Memory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        [Range(0, 32, ErrorMessage = ErrorMessages.NOT_NEGATIVE_NUM + "32GB.")]
        public int RAM { get; set; }
    }
}
