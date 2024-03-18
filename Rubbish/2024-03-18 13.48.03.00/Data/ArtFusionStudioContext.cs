using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArtFusionStudio.Models;

namespace ArtFusionStudio.Data
{
    public class ArtFusionStudioContext : DbContext
    {
        public ArtFusionStudioContext (DbContextOptions<ArtFusionStudioContext> options)
            : base(options)
        {
        }

        public DbSet<ArtFusionStudio.Models.Phone> Phone { get; set; } = default!;
    }
}
