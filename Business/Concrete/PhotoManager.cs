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
    public class PhotoManager : IPhotoService
    {
        private readonly IPhotoDal _photoDal;
        public PhotoManager(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }

        public Photo GetById(int id)
        {
            return _photoDal.GetById(id);
        }

        public List<Photo> ListAll()
        {
            return _photoDal.ListAll();
        }


        public void PhotoAdd(Photo photo)
        {
            _photoDal.Add(photo);
        }

        public void PhotoDelete(Photo photo)
        {
            _photoDal.Delete(photo); 
        }

        public void PhotoUpdate(Photo photo)
        {
            _photoDal.Update(photo);
        }
    }
}
