using Microsoft.EntityFrameworkCore;
using OrderProduct.DataLayer.DTO;
using OrderProduct.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.DataLayer.Concrete.OrderProductContext
{
    internal class OrderProductContextDb:DbContext
    {
        public DbSet<Order> Orders { get; set; }    
        public DbSet<Product> Products{ get; set; }    
        public DbSet<Category> Categories{ get; set; }    
        public DbSet<CreateOrder> CreateOrders{ get; set; }
        public DbSet<OrderDetail> OrderDetails{ get; set; }


        //database bağlantı yollu Hem Msql hemde sqlite bağlantısı mevcut.
        //Sqlite tercih edildi cunku programı baska pc calıştırırken extra database yolu vermeye gerek yok
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=DESKTOP-8M7D7GE\\SQLEXPRESS;database=OrderProduct;integrated security=true;");
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=DESKTOP-LOIGVJB;Database=OrderProductDb;Trusted_Connection=True;");
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductDTO).Assembly);

        }

    }
}
