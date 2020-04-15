using Microsoft.EntityFrameworkCore;
using MVC2.Sakila.Lab2.Models;
using MVC2.Sakila.Lab2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MVC2.Sakila.Lab2.ViewModels.MoviesListViewModel;

namespace MVC2.Sakila.Lab2.Services
{
    public class MovieRepository : IMovieRepository
    {
        private readonly sakilaContext _context;

        public MovieRepository(sakilaContext context)
        {
            _context = context;
        }
        public IQueryable<Film> GetAllMovies()
        {
            return _context.Film;
            
        }

        public MovieViewModel GetMovieByID(int id)
        {
                var viewModel = new MovieViewModel();
                viewModel.movie = _context.Film
                                   .Include(movie => movie.FilmCategory).ThenInclude(category => category.Category)
                                   .Include(movie => movie.FilmActor).ThenInclude(actor => actor.Actor)
                                   .Include(movie => movie.Language)
                                   .Include(movie => movie.Inventory)
                                   .SingleOrDefault(movie => movie.FilmId == id);
                return viewModel;
            
        }
    }
}
