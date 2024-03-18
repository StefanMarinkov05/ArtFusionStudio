using System.ComponentModel.DataAnnotations;

namespace ArtFusionStudio.Models
{
    //Example categories:
    //Phones, Phone cases
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public required string Name { get; set; }


    }
}
