using OrderProduct.BusinessLayer.Abstract;
using OrderProduct.EntityLayer;
using OrderProduct.DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.BusinessLayer.Concrete
{
    public class CreateOrderManager : ICreateOrderService
    {
        ICreateOrderRepository _createOrderRepository;

        public CreateOrderManager(ICreateOrderRepository createOrderRepository)
        {
            _createOrderRepository = createOrderRepository;
        }

        public async Task CreateAsync(CreateOrder entity)
        {
            await _createOrderRepository.CreateAsync(entity);
        }
        public async Task<CreateOrder> GetById(int id)
        {
            return await _createOrderRepository.GetById(id);
        }
    }
}
