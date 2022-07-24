using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderProduct.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.DataLayer.DTO
{
    public class ProductDTO : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

            new Product()
            {
                Id = 1,
                Description = "Meyve ve Sebze",
                CategoryId = 1,
                Unit = "kg",
                UnitPrice = 124.2
            },
               new Product()
               {
                   Id = 2,
                   Description = "Meyvesuyu ve ayran",
                   CategoryId = 2,
                   Unit = "ml",
                   UnitPrice = 24.2
               }, new Product()
               {
                   Id = 3,
                   Description = "Daire ve Dukkan",
                   CategoryId = 3,
                   Unit = "m^2",
                   UnitPrice = 1200.500
               }, new Product()
               {
                   Id = 4,
                   Description = "Insaat Malzemeleri",
                   CategoryId = 4,
                   Unit = "cm",
                   UnitPrice = 234.2
               }, new Product()
               {
                   Id = 5,
                   Description = "Motorlu tasıt",
                   CategoryId = 5,
                   Unit = "km",
                   UnitPrice = 2540.2
               }




            );

        }
    }
}




