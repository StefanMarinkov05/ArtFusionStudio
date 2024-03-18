using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Physical
{
    public class Camera
    {
        [Key]
        public int Id { get; set; }

        //1, 2, 3, 4
        [Required]
        public required byte CameraCount { get; set; }
    }
}
