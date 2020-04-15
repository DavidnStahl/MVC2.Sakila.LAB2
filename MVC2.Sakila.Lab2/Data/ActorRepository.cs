using Microsoft.EntityFrameworkCore;
using MVC2.Sakila.Lab2.Models;
using MVC2.Sakila.Lab2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MVC2.Sakila.Lab2.ViewModels.ActorsListViewModel;

namespace MVC2.Sakila.Lab2.Data
{
    public class ActorRepository : IActorRepository
    {
        public ActorViewModel GetActorByID(int id)
        {
            using (sakilaContext context = new sakilaContext())
            {
                var viewModel = new ActorViewModel();
                viewModel.Actor = context.Actor.Include(actor => actor.FilmActor)
                                               .ThenInclude(filmActor => filmActor.Film)
                                               .FirstOrDefault(actor => actor.ActorId == id);
                return viewModel;
            }
        }

        public ActorsListViewModel GetAllActors()
        {
            using (sakilaContext context = new sakilaContext())
            {
                var viewModel = new ActorsListViewModel();
                viewModel.Items = context.Actor.Select(actor => new ActorItemViewModel
                {
                    ActorId = actor.ActorId,
                    FirstName = actor.FirstName,
                    LastName = actor.LastName
                }).ToList();
                return viewModel;
            }
        }
    }
}
