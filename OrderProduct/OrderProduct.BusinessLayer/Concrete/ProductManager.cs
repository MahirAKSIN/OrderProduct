using OrderProduct.BusinessLayer.Abstract;
using OrderProduct.DataLayer.Abstract;
using OrderProduct.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<List<Product>> GetAllWithDetails()
        {
            return await _productRepository.GetAllWithDetails();
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepository.GetById(id);
        }
    }
}
