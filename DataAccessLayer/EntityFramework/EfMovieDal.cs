using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMovieDal:GenericRepository<Movie>,IMovieDal
    {
        public List<Movie> GetListCategoryMovie()
        {
            using(var c=new Context())
            {
                return c.Movies.Include(x => x.Category).Include(x => x.Cinema).ToList();
            }
        }

        public List<Movie> GetListCategoryMovieDetail(int id)
        {
            using (var c = new Context())
            {
                return c.Movies.Include(x => x.Category).Include(x => x.Actor).Include(x => x.Cinema).Include(x => x.Producer).Where(x=>x.MovieId==id).ToList();
            }
        }
    }
}
