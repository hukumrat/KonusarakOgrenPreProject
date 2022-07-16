using KonusarakOgrenPreProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        void ProductAdd(Product product);
        void ProductDelete(Product product);
        void ProductUpdate(Product product);
        List<Product> ListAll();
        List<Product> ListAllWithIncludes();
        Product GetById(int id);

    }
}
