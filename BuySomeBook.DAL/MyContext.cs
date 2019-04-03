using BuySomeBook.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySomeBook.DAL
{
    public class MyContext:DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
