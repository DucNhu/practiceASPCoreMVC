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
        private IStoreRespository repository;
        public int PageSize = 4;


        public HomeController(IStoreRespository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int ProductPage = 1)
        => View(new MoviesListViewModel
        {
            Movies = repository.Movies
            .Where(p => category == null || p.Category == category)
            .OrderBy(p => p.MovieID)
            .Skip((ProductPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = ProductPage,
                ItemsPerpage = PageSize,
                TotalItems = repository.Movies.Count()
            }
        });
    }
}
