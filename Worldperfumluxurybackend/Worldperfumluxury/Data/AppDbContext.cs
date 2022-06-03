using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
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
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<FullOrder> FullOrders { get; set; }
        public virtual DbSet<BasketItem> BasketItems { get; set; }
        public virtual DbSet<BillingAddress> BillingAddresses { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
