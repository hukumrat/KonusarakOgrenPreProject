using KonusarakOgrenPreProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPhotoService
    {
        void PhotoAdd(Photo photo);
        void PhotoDelete(Photo photo);
        void PhotoUpdate(Photo photo);
        List<Photo> ListAll();
        Photo GetById(int id);
    }
}
