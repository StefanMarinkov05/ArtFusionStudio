using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Virtual
{
    public class OperatingSystem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string OSName { get; set; }
    }
}
