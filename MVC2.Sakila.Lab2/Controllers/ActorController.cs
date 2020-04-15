using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC2.Sakila.Lab2.Data;
using MVC2.Sakila.Lab2.Services;
using MVC2.Sakila.Lab2.ViewModels;
using static MVC2.Sakila.Lab2.ViewModels.ActorsListViewModel;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC2.Sakila.Lab2.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorRepository _repository;
        private readonly ISortingLogic _sortingLogic;
        //private readonly int PageSize = 10;

        public ActorController(IActorRepository repository, ISortingLogic sortingLogic)
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
            
            var actonListViewModel = new ActorsListViewModel();
            var items = _repository.GetAllActors().Select(actor => new ActorItemViewModel
            {
                ActorId = actor.ActorId,
                FirstName = actor.FirstName,
                LastName = actor.LastName
            });
            items = _sortingLogic.SortActorList(ref sortColumn, ref sortOrder, items);

            var pageCount = (double)items.Count() / pageSizeConverted;
            int currentPage = string.IsNullOrEmpty(page) ? 1 : Convert.ToInt32(page);
            items = items.Skip((currentPage - 1) * pageSizeConverted).Take(pageSizeConverted);

            actonListViewModel.PagingViewModel.MaxPages = (int)Math.Ceiling(pageCount);
            actonListViewModel.PagingViewModel.CurrentPage = currentPage;
            actonListViewModel.PagingViewModel.pageSize = pageSizeConverted.ToString();
            actonListViewModel.Items = items.ToList();
            actonListViewModel.SortColumn = sortColumn;
            actonListViewModel.SortOrder = sortOrder;
            return View(actonListViewModel);
        }
        public IActionResult View(int id)
        {
            var viewModel = _repository.GetActorByID(id);
            return View(viewModel);
        }
    }
}
