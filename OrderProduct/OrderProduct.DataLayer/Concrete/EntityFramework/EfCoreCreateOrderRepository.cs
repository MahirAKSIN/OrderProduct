using OrderProduct.DataLayer.Abstract;
using OrderProduct.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.DataLayer.Concrete.EntityFramework
{
    public class EfCoreCreateOrderRepository:EfCoreGenericRepository<CreateOrder>,ICreateOrderRepository

    {
        //EfCoreCreateOrderRepository class EfCoreGenericRepository tarafından imzası atılan methodları implement edildi
        //Eğer Irepository ve GenericRepositoryde olmayan özel methodlar varsa ICreateOrderRepository Interface yazıldığı için 
        //onuda implement ettik

    }
}
