using MVC2.Sakila.Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Sakila.Lab2.ViewModels
{
    public class ActorViewModel
    {
        public Actor Actor { get; set; }

        public ActorViewModel()
        {
            Actor = new Actor();
        }
    }
}
