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
    public class ActorManager : IActorService
    {
        IActorDal _actorDal;

        public ActorManager(IActorDal actorDal)
        {
            _actorDal = actorDal;
        }

        public Actor GetById(int id)
        {
            return _actorDal.GetById(id);
        }

        public List<Actor> GetList()
        {
            return _actorDal.GetList();
        }

        public void TAdd(Actor t)
        {
            _actorDal.Add(t);
        }

        public void TDelete(Actor t)
        {
            _actorDal.Delete(t); 
        }

        public void TUpdate(Actor t)
        {
            _actorDal.Update(t);
        }
    }
}
