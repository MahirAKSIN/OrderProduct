using Microsoft.EntityFrameworkCore;
using OrderProduct.DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.DataLayer.Concrete.EntityFramework
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public async Task CreateAsync(TEntity entity)
        {
            using (var c = new OrderProductContext.OrderProductContextDb())
            {
                await c.Set<TEntity>().AddAsync(entity);
                await c.SaveChangesAsync();

            }
        }

        public async Task<List<TEntity>> GetAll()
        {

            using (var c = new OrderProductContext.OrderProductContextDb())
            {
              return   await c.Set<TEntity>().ToListAsync();

            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (var c = new OrderProductContext.OrderProductContextDb())
            {
                return await c.Set<TEntity>().FindAsync(id);

            }
        }
    }
    
    }

