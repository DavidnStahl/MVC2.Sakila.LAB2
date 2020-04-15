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
        private readonly sakilaContext _context;

        public ActorRepository(sakilaContext context)
        {
            _context = context;
        }
        public ActorViewModel GetActorByID(int id)
        {            
                var viewModel = new ActorViewModel();
                viewModel.Actor = _context.Actor.Include(actor => actor.FilmActor)
                                               .ThenInclude(filmActor => filmActor.Film)
                                               .FirstOrDefault(actor => actor.ActorId == id);
                return viewModel;           
        }

        public IQueryable<Actor> GetAllActors()
        {
            return _context.Actor;
        }
    }
}
