using MVC2.Sakila.Lab2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MVC2.Sakila.Lab2.ViewModels.ActorsListViewModel;
using static MVC2.Sakila.Lab2.ViewModels.MoviesListViewModel;

namespace MVC2.Sakila.Lab2.Services
{
    public interface ISortingLogic
    {
        IQueryable<MovieItemViewModel> SortMovieList(ref string sortColumn, ref string sortOrder, IQueryable<MovieItemViewModel> items);
        IQueryable<ActorItemViewModel> SortActorList(ref string sortColumn, ref string sortOrder, IQueryable<ActorItemViewModel> items);
    }
}
