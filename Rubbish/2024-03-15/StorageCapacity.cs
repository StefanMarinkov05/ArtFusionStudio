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
        [Required]
        public required decimal CapacityGB { get; set; }
    }
}
