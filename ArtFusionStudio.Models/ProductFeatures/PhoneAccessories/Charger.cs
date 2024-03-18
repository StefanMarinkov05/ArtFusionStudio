using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models.ProductFeatures.PhoneAccessories
{
    public class Charger : Product
    {
        
        public int OutputVoltage { get; set; } 
        public int OutputCurrent { get; set; }
        public bool FastChargingSupported { get; set; }
    }
}
