using KonusarakOgrenPreProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> ListAllWithIncludes();
    }
}
