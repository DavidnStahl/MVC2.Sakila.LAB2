﻿using MVC2.Sakila.Lab2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MVC2.Sakila.Lab2.ViewModels.MoviesListViewModel;

namespace MVC2.Sakila.Lab2.Services
{
    public class SortingLogic : ISortingLogic
    {
        public MoviesListViewModel SortMovieList(string sortColumn, string sortOrder, MoviesListViewModel movieList)
        {
            if (string.IsNullOrEmpty(sortOrder))
                sortOrder = "asc";

            if (sortColumn == "date")
            {
                if (sortOrder == "asc")
                    movieList.Items = movieList.Items.OrderBy(p => p.realeaseYear).ToList();
                else
                    movieList.Items = movieList.Items.OrderByDescending(p => p.realeaseYear).ToList();
            }
            else
            {
                if (sortOrder == "asc")
                    movieList.Items = movieList.Items.OrderBy(p => p.title).ToList();
                else
                    movieList.Items = movieList.Items.OrderByDescending(p => p.title).ToList();

                sortColumn = "title";
            }
            movieList.SortColumn = sortColumn;
            movieList.SortOrder = sortOrder;
            return movieList;
            
        }
    }
}
