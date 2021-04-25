using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeXiecheng.API.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace FakeXiecheng.API.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TouristRoute>().HasData(
            //    new TouristRoute
            //    {
            //        Id = Guid.NewGuid(),
            //        Title = "黄山",
            //        Description = "黄山真好玩",
            //        OriginalPrice = 1299,
            //        Features = "<p>吃住行娱乐购买</p>",
            //        Fees = "<p>交通费用自理</p>",
            //        Notes = "<p>小心危险</p>",
            //        CreatedTime = DateTime.UtcNow
            //    },
            //     new TouristRoute
            //     {
            //         Id = Guid.NewGuid(),
            //         Title = "华山",
            //         Description = "华山真好玩",
            //         OriginalPrice = 1299,
            //         Features = "<p>吃住行娱乐购买</p>",
            //         Fees = "<p>交通费用自理</p>",
            //         Notes = "<p>小心危险</p>",
            //         CreatedTime = DateTime.UtcNow
            //     }); 

            var touristRouteJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutesMockData.json");
            IList<TouristRoute> touristRoutes = JsonConvert.DeserializeObject<IList<TouristRoute>>(touristRouteJsonData);
            modelBuilder.Entity<TouristRoute>().HasData(touristRoutes);

            var touristRoutePicturesJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutePicturesMockData.json");
            IList<TouristRoutePicture> touristRoutePictures = JsonConvert.DeserializeObject<IList<TouristRoutePicture>>(touristRoutePicturesJsonData);
            modelBuilder.Entity<TouristRoutePicture>().HasData(touristRoutePictures);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
