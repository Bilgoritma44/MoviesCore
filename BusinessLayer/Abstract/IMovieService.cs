using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMovieService:IGenericService<Movie>
    {
        List<Movie> GetList(string p);
        List<Movie> GetListMovieId(int id);
        List<Movie> GetListCategory();
        List<Movie> GetListCategoryDetail(int id);
    }
}
