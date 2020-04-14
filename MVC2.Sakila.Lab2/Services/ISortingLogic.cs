using MVC2.Sakila.Lab2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MVC2.Sakila.Lab2.ViewModels.MoviesListViewModel;

namespace MVC2.Sakila.Lab2.Services
{
    public interface ISortingLogic
    {
        MoviesListViewModel SortMovieList(string sortColumn, string sortOrder, MoviesListViewModel movieList);
    }
}
