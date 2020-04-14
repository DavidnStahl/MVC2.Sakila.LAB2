using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Sakila.Lab2.ViewModels
{
    public class MoviesListViewModel
    {
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
        public List<MovieItemViewModel> Items { get; set; } = new List<MovieItemViewModel>();
        public class MovieItemViewModel
        {
            public int FilmId { get; set; }
            public string title { get; set; }
            public string realeaseYear { get; set; }
        }
        
    }
}
