using MVC2.Sakila.Lab2.Models;
using MVC2.Sakila.Lab2.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MVC2.Sakila.Lab2.ViewModels.ActorsListViewModel;
using static MVC2.Sakila.Lab2.ViewModels.MoviesListViewModel;

namespace MVC2.Sakila.Lab2.Services
{
    public class SortingLogic : ISortingLogic
    {
        public IQueryable<ActorItemViewModel> SortActorList(ref string sortColumn, ref string sortOrder, IQueryable<ActorItemViewModel> items)
        {
            
            if (string.IsNullOrEmpty(sortOrder))
                sortOrder = "asc";

            if (sortColumn == "FirstName")
            {
                if (sortOrder == "asc")
                    items = items.OrderBy(p => p.FirstName);
                else
                    items = items.OrderByDescending(p => p.FirstName);
            }
            else
            {
                if (sortOrder == "asc")
                    items = items.OrderBy(p => p.LastName);
                else
                    items = items.OrderByDescending(p => p.LastName);

                sortColumn = "LastName";
            }
            
            return items;
        }

        public IQueryable<MovieItemViewModel> SortMovieList(ref string sortColumn, ref string sortOrder, IQueryable<MovieItemViewModel> items)
        {
            if (string.IsNullOrEmpty(sortOrder))
                sortOrder = "asc";

            if (sortColumn == "date")
            {
                if (sortOrder == "asc")
                    items = items.OrderBy(p => p.realeaseYear);
                else
                    items = items.OrderByDescending(p => p.realeaseYear);
            }
            else
            {
                if (sortOrder == "asc")
                    items = items.OrderBy(p => p.title);
                else
                    items = items.OrderByDescending(p => p.title);

                sortColumn = "title";
            }
            
            return items;
            
        }
        
    }
}
