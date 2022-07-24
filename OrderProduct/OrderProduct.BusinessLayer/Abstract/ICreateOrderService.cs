using OrderProduct.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.BusinessLayer.Abstract
{
    public interface ICreateOrderService
    {
        Task CreateAsync(CreateOrder entity);
        Task<CreateOrder> GetById(int id);

    }
}
