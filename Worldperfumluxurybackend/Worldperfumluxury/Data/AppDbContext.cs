using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<BestSelling> BestSellings { get; set; }
        public DbSet<BestSellingDetail> BestSellingDetails { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Productmulti> Productmultis { get; set; }
        public DbSet<NewCollection> NewCollections { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Video> Videos { get; set; }

    }
}
