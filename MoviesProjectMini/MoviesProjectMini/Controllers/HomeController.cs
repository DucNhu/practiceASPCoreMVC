using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesProjectMini.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
            => View(respository.Movies
                .OrderBy(p => p.MovieID)
                .Skip((moviePage - 1) * PageSize).Take(PageSize));
    }
}
