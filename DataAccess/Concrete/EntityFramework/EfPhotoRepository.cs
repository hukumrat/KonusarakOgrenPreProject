using DataAccess.Abstract;
using KonusarakOgrenPreProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPhotoRepository : EfGenericRepository<Photo>, IPhotoDal
    {
        
        public EfPhotoRepository(EfDataContext context) : base(context)
        {
            
        }

    }
}
