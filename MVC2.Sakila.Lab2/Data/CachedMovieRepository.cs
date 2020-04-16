using Microsoft.AspNetCore.Http;
using MVC2.Sakila.Lab2.Models;
using MVC2.Sakila.Lab2.Services;
using MVC2.Sakila.Lab2.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Sakila.Lab2.Data
{
    public class CachedMovieRepository : IMovieRepository
    {
        private readonly IMovieRepository _innerRepository;
        private readonly IHttpContextAccessor _httpContext;


        public CachedMovieRepository(IMovieRepository innerRepository, IHttpContextAccessor httpContext)
        {
            _innerRepository = innerRepository;
            _httpContext = httpContext;
        }

        public IQueryable<Film> GetAllMovies()
        {
            
            return _innerRepository.GetAllMovies();
        }

        public MovieViewModel GetMovieByID(int id, HttpContext httpContext)
        {
            var jsonget = /*_httpContext.HttpContext.*/httpContext.Request.Cookies[id.ToString()];
            if(jsonget != null)
            {
                return JsonConvert.DeserializeObject<MovieViewModel>(jsonget);
            }
            else
            {
                return CreateCookie(id, httpContext);
            }
            
        }
        private MovieViewModel CreateCookie(int id, HttpContext httpContext)
        {
            var movie = _innerRepository.GetMovieByID(id, httpContext);
            JsonSerializerSettings jss = new JsonSerializerSettings();
            jss.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            string json = JsonConvert.SerializeObject(movie, jss);
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddSeconds(1000);
            options.HttpOnly = true;
            httpContext.Response.Cookies.Append(id.ToString(), json, options);
            var jsonget = httpContext.Request.Cookies[id.ToString()];
            return movie;
        }
    }
}
