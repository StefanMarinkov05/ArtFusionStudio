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
        [Required]
        public required string Name { get; set; }
    }
}
