using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.EntityLayer
{

    //Product için bilgilerinin ve diğer entity classlarının admin olan ilişkileri burada tutuyor.
    //Encapsulation yapılmıştır
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<CreateOrder> CreateOrders { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }


    }
}
