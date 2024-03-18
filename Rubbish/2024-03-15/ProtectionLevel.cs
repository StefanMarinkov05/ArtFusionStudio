using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneAccessories
{
    public class ProtectionLevel
    {
        [Key]
        public int Id { get; set; }

        public required string Protection { get; set; }
    }
}
