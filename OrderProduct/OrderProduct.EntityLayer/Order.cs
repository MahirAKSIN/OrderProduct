using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.EntityLayer
{

    //Order için bilgilerinin ve diğer entity classlarının admin olan ilişkileri burada tutuyor.
    //Encapsulation yapılmıştır

    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string  CustomerName { get; set; }
        public string  CustomerEmail { get; set; }
        public string  CustomerGSM { get; set; }
        public double  TotalAmount { get; set; }
        public List<CreateOrder> CreateOrders { get; set; }

    }
}
