using ArtFusionStudio.Models;
using ArtFusionStudio.Models.ProductFeatures;
using ArtFusionStudio.Models.ProductFeatures.PhoneAccessories;
using ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Physical;
using ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Virtual;
using ArtFusionStudio.Utility;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace ArtFusionStudio.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        
        public DbSet<Case> Cases { get; set; }
        public DbSet<CaseMaterial> CaseMaterials { get; set; }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<ProtectionLevel> ProtectionLevels { get; set; }

        public DbSet<Charger> Chargers { get; set; }

        public DbSet<Camera> Cameras { get; set; }
        public DbSet<DisplayTechnology> DisplayTechnologies { get; set; }
        public DbSet<StorageCapacity> StorageCapacities { get; set; }
        public DbSet<USB> USBs { get; set; }

        public DbSet<Models.ProductFeatures.PhoneFeatures.Virtual.OperatingSystem> OperatingSystems { get; set; }
        public DbSet<OperatingSystemVersion> OperatingSystemVersions { get; set; }
        public DbSet<OSNameAndVersion> OSNameAndVersions { get; set; }

        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<Ratings> Ratings { get; set; }

        public DbSet<ImageURL> ImageURLs { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Phone" },
                new Category { Id = 2, Name = "Case" },
                new Category { Id = 3, Name = "Charger" }
                );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Iphone", PathD = BrandLogoPath.IPHONE_PATH },
                new Brand { Id = 2, Name = "Huawei", PathD = BrandLogoPath.HUAWEI_PATH },
                new Brand { Id = 3, Name = "Sony", PathD = BrandLogoPath.SONY_PATH },
                new Brand { Id = 4, Name = "Samsung", PathD = BrandLogoPath.SAMSUNG_PATH },
                new Brand { Id = 5, Name = "Nokia", PathD = BrandLogoPath.NOKIA_PATH },
                new Brand { Id = 6, Name = "Accessories", PathD = BrandLogoPath.ACCESSORIES_PATH },
                new Brand { Id = 7, Name = "Custom", PathD = BrandLogoPath.CUSTOM_PATH }
                );

            //modelBuilder.Entity<Phone>().HasData(
            //    //new Phone
            //    //{
            //    //    Id = 1, 
            //    //    Name = "Iphone 15 Pro Max", 
            //    //    BrandId = 1, 
            //    //    CategoryId = 1, 
            //    //    Colors = new
            //    //} 
            //    );
        }
    }
}
