using Microsoft.EntityFrameworkCore;
using OrderProduct.DataLayer.Abstract;
using OrderProduct.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.DataLayer.Concrete.EntityFramework
{
    public class EfCoreProductRepository:EfCoreGenericRepository<Product>,IProductRepository
    {
        //EfCoreProductRepository class EfCoreGenericRepository tarafından imzası atılan methodları implement edildi
        //Eğer Irepository ve GenericRepositoryde olmayan özel methodlar varsa IProductRepository Interface yazıldığı için 
        //onuda implement ettik

        public async Task<List<Product>> GetAllWithDetails()
        {
            using (var c = new OrderProductContext.OrderProductContextDb())
            {
                var d = await c.Products.Include(x => x.Category).ToListAsync();
                return d;
            }
        }
    }
}
