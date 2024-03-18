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
        [Required]
        [Column(TypeName = "decimal(2, 2)")]
        public required decimal OSVersion { get; set; }
    }
}
