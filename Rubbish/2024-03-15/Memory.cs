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

        [Required]
        public int RAM { get; set; }
    }
}
