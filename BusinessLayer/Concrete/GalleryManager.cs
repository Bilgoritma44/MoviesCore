using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public Gallery GetById(int id)
        {
            return _galleryDal.GetById(id);
        }

        public List<Gallery> GetList()
        {
            return _galleryDal.GetList();
        }

        public void TAdd(Gallery t)
        {
            _galleryDal.Add(t);
        }

        public void TDelete(Gallery t)
        {
            _galleryDal.Delete(t);
        }

        public void TUpdate(Gallery t)
        {
            _galleryDal.Update(t);
        }
    }
}
