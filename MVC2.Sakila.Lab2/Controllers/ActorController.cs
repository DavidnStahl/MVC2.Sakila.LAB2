using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC2.Sakila.Lab2.Data;
using MVC2.Sakila.Lab2.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC2.Sakila.Lab2.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorRepository _repository;
        private readonly ISortingLogic _sortingLogic;

        public ActorController(IActorRepository repository, ISortingLogic sortingLogic)
        {
            _repository = repository;
            _sortingLogic = sortingLogic;
        }

        public IActionResult Index(string sortColumn, string sortOrder)
        {
            var items = _repository.GetAllActors();
            var viewModel = _sortingLogic.SortActorList(sortColumn, sortOrder, items);
            return View(viewModel);
        }
        public IActionResult View(int id)
        {
            var viewModel = _repository.GetActorByID(id);
            return View(viewModel);
        }
    }
}
