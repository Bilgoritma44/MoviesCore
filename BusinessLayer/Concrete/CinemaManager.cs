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
    public class CinemaManager : ICinemaService
    {
        ICinemaDal _cinemaDal;

        public CinemaManager(ICinemaDal cinemaDal)
        {
            _cinemaDal = cinemaDal;     
        }

        public Cinema GetById(int id)
        {
            return _cinemaDal.GetById(id);
        }

        public List<Cinema> GetList()
        {
            return _cinemaDal.GetList();
        }

        public void TAdd(Cinema t)
        {
            _cinemaDal.Add(t);
        }

        public void TDelete(Cinema t)
        {
            _cinemaDal.Delete(t);
        }

        public void TUpdate(Cinema t)
        {
            _cinemaDal.Update(t);
        }
    }
}
