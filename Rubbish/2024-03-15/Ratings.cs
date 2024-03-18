using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures
{
    public class Ratings
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [AllowedValues(1,2,3,4,5)]
        public required byte Rate { get; set; }

        [Required]
        public required DateTime ReviewTime { get; set; }

        [AllowNull]
        public required string Review { get; set; }
    }
}
