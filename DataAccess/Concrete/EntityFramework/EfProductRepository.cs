using DataAccess.Abstract;
using KonusarakOgrenPreProject.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductDal
    {
        private readonly EfDataContext _context;
        public EfProductRepository(EfDataContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ListAllWithIncludes()
        {
            return _context.Products.Include(p => p.Photos).Include(p => p.Comments).ToList();
        }
    }
}
