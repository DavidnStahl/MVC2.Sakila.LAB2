using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC2.Sakila.Lab2.Models;
using MVC2.Sakila.Lab2.Services;
using MVC2.Sakila.Lab2.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC2.Sakila.Lab2.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repository;
        private readonly ISortingLogic _sortingLogic;

        public MovieController(IMovieRepository repository, ISortingLogic sortingLogic)
        {
            _repository = repository;
            _sortingLogic = sortingLogic;
        }

        public ISortingLogic SortingLogic { get; }

        public IActionResult Index(string sortColumn, string sortOrder)
        {
            var items = _repository.GetAllMovies();
            var viewModel = _sortingLogic.SortMovieList(sortColumn, sortOrder,items);
            return View(viewModel);
        }
        public IActionResult View(int id)
        {
            var viewModel = _repository.GetMovieByID(id);
            return View(viewModel);
        }

    }
}
