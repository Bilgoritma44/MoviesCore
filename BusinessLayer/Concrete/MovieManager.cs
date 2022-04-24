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
    public class MovieManager : IMovieService
    {

        IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public Movie GetById(int id)
        {
            return _movieDal.GetById(id);
        }

        public List<Movie> GetList()
        {
            return _movieDal.GetList();
        }

        public List<Movie> GetList(string p)
        {
            return _movieDal.GetListDetail(x => x.MovieName.Contains(p));
        }

        public List<Movie> GetListCategory()
        {
            return _movieDal.GetListCategoryMovie();
        }

        public List<Movie> GetListCategoryDetail(int id)
        {
            return _movieDal.GetListCategoryMovieDetail(id);
        }

        public List<Movie> GetListMovieId(int id)
        {
            return _movieDal.GetListDetail(x => x.MovieId == id);
        }

        public void TAdd(Movie t)
        {
            _movieDal.Add(t);
        }

        public void TDelete(Movie t)
        {
            _movieDal.Delete(t);
        }

        public void TUpdate(Movie t)
        {
            _movieDal.Update(t);
        }
    }
}
