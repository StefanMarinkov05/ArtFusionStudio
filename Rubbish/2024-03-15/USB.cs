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
        [Required]
        public required string Type { get; set; }
    }
}
