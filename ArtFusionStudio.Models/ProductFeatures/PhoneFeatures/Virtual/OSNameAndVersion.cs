using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Virtual
{
    public class OSNameAndVersion
    {
        [Key]
        public int Id { get; set; }

        public int OSNameId { get; set; }
        [ForeignKey("OSNameId")]
        public OperatingSystem? OperatingSystem { get; set; }

        public int OSVersionId { get; set; }
        [ForeignKey("OSVersionId")]
        public OperatingSystemVersion? OperatingSystemVersion { get; set;}

        public string OSNamePlusVersion
        {
            get
            {
                return $"{OperatingSystem?.OSName} {OperatingSystemVersion?.OSVersion}";
            }
        }
    }
}
