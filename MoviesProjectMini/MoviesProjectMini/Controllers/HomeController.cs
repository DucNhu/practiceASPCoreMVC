using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesProjectMini.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MoviesProjectMini.Models.ViewModels;

namespace MoviesProjectMini.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRespository respository;
        public int PageSize = 4;
        public HomeController(IStoreRespository repo)
        {
            respository = repo;
        }

        //Render all:
        //public IActionResult Index() => View(respository.Movies);

        public ViewResult Index(int moviePage = 1)
            => View(new MoviesListViewModel
            {
                Movies = respository.Movies
                .OrderBy(p => p.MovieID)
                .Skip((moviePage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = moviePage,
                    MoviesPerpage = PageSize,
                    TotalMovies = respository.Movies.Count()
                }
            });
    }
}
