using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Worldperfumluxury.Models;
//using Worldperfumluxury.ViewModels.Pagination;

namespace Worldperfumluxury.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<BestSelling> BestSellings { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Productmulti> Productmultis { get; set; }
        public DbSet<NewCollection> NewCollections { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Womenshop> Womenshops { get; set; }
        public DbSet<Menshop> Menshops { get; set; }


        public virtual DbSet<FullOrder> FullOrders { get; set; }

        public virtual DbSet<BillingAddress> BillingAddresses { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }

        public DbSet<Setting> Settings { get; set; }
        //public DbSet<ProductListVM> ProductListVM { get; set; }
    }
}
