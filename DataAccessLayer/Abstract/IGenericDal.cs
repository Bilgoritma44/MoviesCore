using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        List<T> GetList();
        T GetById(int id);
        List<T> GetListDetail(Expression<Func<T, bool>> filter);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
    }
}
