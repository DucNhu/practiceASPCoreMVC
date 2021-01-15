using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesProjectMini.Models;

namespace MoviesProjectMini.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRespository repository;

        public NavigationMenuViewComponent(IStoreRespository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Movies
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
