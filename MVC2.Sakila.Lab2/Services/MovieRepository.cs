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
        public MoviesListViewModel GetAllMovies()
        {
            using (sakilaContext context = new sakilaContext())
            {
                var viewModel = new MoviesListViewModel();
                viewModel.Items = context.Film.Select(movie => new MovieItemViewModel
                {
                    FilmId = movie.FilmId,
                    title = movie.Title,
                    realeaseYear = movie.ReleaseYear
                }).ToList();
                return viewModel;
            }
        }

        public MovieViewModel GetMovieByID(int id)
        {
            using (sakilaContext context = new sakilaContext())
            {
                var viewModel = new MovieViewModel();
                viewModel.movie = context.Film
                                   .Include(movie => movie.FilmCategory).ThenInclude(category => category.Category)
                                   .Include(movie => movie.FilmActor).ThenInclude(actor => actor.Actor)
                                   .Include(movie => movie.Language)
                                   .Include(movie => movie.Inventory)
                                   .SingleOrDefault(movie => movie.FilmId == id);
                return viewModel;
            }
        }
    }
}
