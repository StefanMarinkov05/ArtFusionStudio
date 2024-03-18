using ArtFusionStudio.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Physical
{
    public class StorageCapacity
    {
        [Key]
        public int Id { get; set; }

        //512GB, 0,0036GB
        [Required(ErrorMessage = ErrorMessages.NO_BLANK_SPACE)]
        [Range(0,2048, ErrorMessage = ErrorMessages.NOT_NEGATIVE_NUM + " 2048.")]
        public required decimal CapacityGB { get; set; }
    }
}
