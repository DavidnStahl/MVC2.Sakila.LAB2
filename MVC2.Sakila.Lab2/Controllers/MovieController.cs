using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC2.Sakila.Lab2.Models;
using MVC2.Sakila.Lab2.Services;
using MVC2.Sakila.Lab2.ViewModels;
using static MVC2.Sakila.Lab2.ViewModels.MoviesListViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC2.Sakila.Lab2.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repository;
        private readonly ISortingLogic _sortingLogic;
        //private readonly int PageSize = 40;

        public MovieController(IMovieRepository repository, ISortingLogic sortingLogic)
        {
            _repository = repository;
            _sortingLogic = sortingLogic;
        }

        public IActionResult Index(string sortColumn, string sortOrder, string page, string pageSize)
        {
            var pageSizeConverted = 0;
            if (string.IsNullOrEmpty(pageSize))
            {
                if (string.IsNullOrEmpty(HttpContext.Session.GetString("pageSize")))
                {
                    pageSizeConverted = 50;
                    HttpContext.Session.SetString("pageSize", pageSizeConverted.ToString());

                }
                else
                {
                    pageSizeConverted = Convert.ToInt32(HttpContext.Session.GetString("pageSize"));
                }
                //pageSizeConverted = 50;
            }
            else
            {
                HttpContext.Session.SetString("pageSize", pageSize.ToString());
                pageSizeConverted = Convert.ToInt32(pageSize);
            }
            var movieListViewModel = new MoviesListViewModel();
            var items = _repository.GetAllMovies().Select(movie => new MovieItemViewModel
            {
                FilmId = movie.FilmId,
                title = movie.Title,
                realeaseYear = movie.ReleaseYear
            });

            items = _sortingLogic.SortMovieList(ref sortColumn, ref sortOrder, items);          
            var pageCount = (double)items.Count() / pageSizeConverted;
            int currentPage = string.IsNullOrEmpty(page) ? 1 : Convert.ToInt32(page);
            items = items.Skip((currentPage - 1) * pageSizeConverted).Take(pageSizeConverted);

            movieListViewModel.PagingViewModel.MaxPages = (int)Math.Ceiling(pageCount);
            movieListViewModel.PagingViewModel.CurrentPage = currentPage;
            movieListViewModel.PagingViewModel.pageSize = pageSizeConverted.ToString();
            movieListViewModel.Items = items.ToList();
            movieListViewModel.SortColumn = sortColumn;
            movieListViewModel.SortOrder = sortOrder;
            return View(movieListViewModel);
        }
        public IActionResult View(int id)
        {
            var viewModel = _repository.GetMovieByID(id);
            return View(viewModel);
        }
        

    }
}
