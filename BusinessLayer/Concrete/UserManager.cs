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
    public class UserManager : IUserService
    {

        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal; 
        }

        public ApplicationUser GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<ApplicationUser> GetList()
        {
            return _userDal.GetList();
        }

        public void TAdd(ApplicationUser t)
        {
            _userDal.Add(t);
        }

        public void TDelete(ApplicationUser t)
        {
            _userDal.Delete(t);
        }

        public void TUpdate(ApplicationUser t)
        {
            _userDal.Update(t);
        }
    }
}
