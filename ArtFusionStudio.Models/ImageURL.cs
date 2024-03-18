using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models
{
    public class ImageURL
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        [NotMapped]
        public Product? Product { get; set; }

        public required string ImagePath { get; set; }
    }
}
