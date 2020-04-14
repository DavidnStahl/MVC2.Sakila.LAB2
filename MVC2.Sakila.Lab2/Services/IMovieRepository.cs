﻿using MVC2.Sakila.Lab2.Models;
using MVC2.Sakila.Lab2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Sakila.Lab2.Services
{
    public interface IMovieRepository
    {
        MoviesListViewModel GetAllMovies();

        MovieViewModel GetMovieByID(int id);
    }
}
