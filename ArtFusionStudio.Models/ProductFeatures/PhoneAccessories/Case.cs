using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneAccessories
{
    public class Case : Product
    {
        public int ProtectionLevelId { get; set; }

        [ForeignKey("ProtectionLevelId")]
        public ProtectionLevel? ProtectionLevel { get; set; }

        public List<CaseMaterial> CaseMaterial { get; set; } = new List<CaseMaterial>();

        public List<CaseType> CaseType { get; set; } = new List<CaseType>();
    }
}
