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
    public class ProducerManager : IProducerService
    {

        IProducerDal _producerDal;

        public ProducerManager(IProducerDal producerDal)
        {
            _producerDal = producerDal;
        }

        public Producer GetById(int id)
        {
            return _producerDal.GetById(id);
        }

        public List<Producer> GetList()
        {
            return _producerDal.GetList();
        }

        public void TAdd(Producer t)
        {
            _producerDal.Add(t);
        }

        public void TDelete(Producer t)
        {
            _producerDal.Delete(t);
        }

        public void TUpdate(Producer t)
        {
            _producerDal.Update(t);
        }
    }
}
