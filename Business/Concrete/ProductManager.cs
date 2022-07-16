using Business.Abstract;
using DataAccess.Abstract;
using KonusarakOgrenPreProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> ListAll()
        {
            return _productDal.ListAll();
        }

        public List<Product> ListAllWithIncludes()
        {
            return _productDal.ListAllWithIncludes();
        }

        public void ProductAdd(Product product)
        {
            _productDal.Add(product);
        }

        public void ProductDelete(Product product)
        {
            _productDal.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _productDal.Update(product);
        }
    }
}
