﻿using ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Physical;
using ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Virtual;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFusionStudio.Models
{
    public class Phone : Product
    {
        [Key]
        public int Id { get; set; } 
        public int CameraId { get; set; }
        public int DisplayTechnologyId { get; set; }
        public int MemoryId { get; set; }
        public int StorageCapacityId { get; set; }
        public int USBId { get; set; }
        public int OSNameAndVersionId { get; set; }

        [ForeignKey("CameraId")]
        public Camera? Camera { get; set; }

        [ForeignKey("DisplayTechnologyId")]
        public DisplayTechnology? DisplayTechnology { get; set; }

        [ForeignKey("MemoryId")]
        public Memory? Memory { get; set; }

        [ForeignKey("StorageCapacityId")]
        public StorageCapacity? StorageCapacity { get; set; }

        [ForeignKey("USBId")]
        public USB? USB { get; set; }

        [ForeignKey("OSNameAndVersionId")]
        public OSNameAndVersion? OSNameAndVersion { get; set; }
    }
}
