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
        //Sunum katmanından gelen bilgileri gerekli koşullara göre işleyerek veya denetleyerek
        //veri katmanının sağladığı metotları kullanarak veritabanına gönderen aynı şekilde veritabanından da bilgileri alarak gerekli
        //süreçlerden geçirip presentation katmanına gönderen katman.

        //---------------------
        //Mahir AKSIN-22072022
        //---------------------

        Task<Product> GetById(int id);
        Task<List<Product>> GetAll();
        Task<List<Product>> GetAllWithDetails();

    }
}
