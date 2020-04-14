using MVC2.Sakila.Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Sakila.Lab2.ViewModels
{
    public class MovieViewModel
    {
        public Film movie { get; set; }

        public MovieViewModel()
        {
            movie = new Film();
        }
    }
}
