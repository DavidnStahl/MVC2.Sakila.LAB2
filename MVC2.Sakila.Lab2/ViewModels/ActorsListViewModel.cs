using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Sakila.Lab2.ViewModels
{
    public class ActorsListViewModel
    {
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
        public List<ActorItemViewModel> Items { get; set; } = new List<ActorItemViewModel>();
        public class ActorItemViewModel
        {
            public int ActorId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
