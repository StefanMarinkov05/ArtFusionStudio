using System.ComponentModel.DataAnnotations;

namespace ArtFusionStudio.Models
{
    //Example categories:
    //Phones, Phone cases
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }


    }
}
