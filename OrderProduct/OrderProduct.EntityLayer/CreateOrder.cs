using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct.EntityLayer
{
    public class CreateOrder
    {
        [Key]
        public int Id { get; set; }

        //public string CustormerName{ get; set; }
        //public string CustormerEmai{ get; set; }
        //public string CustormerGSM{ get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }


    }
}
