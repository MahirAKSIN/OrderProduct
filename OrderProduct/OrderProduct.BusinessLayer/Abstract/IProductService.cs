using OrderProduct.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.BusinessLayer.Abstract
{
    public interface IProductService
    {


        Task<Product> GetById(int id);
        Task<List<Product>> GetAll();
        Task<List<Product>> GetAllWithDetails();

    }
}
