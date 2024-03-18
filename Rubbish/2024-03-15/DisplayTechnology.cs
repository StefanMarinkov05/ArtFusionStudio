using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Physical
{
    public class DisplayTechnology
    {
        [Key]
        public int Id { get; set; }

        //AMOLED, LCD
        [Required]
        public required string Name { get; set; }
    }
}
