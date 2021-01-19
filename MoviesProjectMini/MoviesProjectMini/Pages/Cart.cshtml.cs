using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesProjectMini.Models;
using MoviesProjectMini.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MoviesProjectMini.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRespository respository;

        public CartModel(IStoreRespository repo)
        {
            respository = repo;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long MovieId, string returnUrl)
        {
            Movie movie = respository.Movies.FirstOrDefault(
                p => p.MovieID == MovieId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(movie, 1);

            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { ReturnUrl = ReturnUrl });
        }

    }
}
