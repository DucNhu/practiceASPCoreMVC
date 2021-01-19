using MoviesProjectMini.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProjectMini.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Movie Movie, int quantity)
        {
            CartLine line = Lines
                .Where(p => p.Movie.MovieID == Movie.MovieID)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Movie = Movie,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Movie movie) =>
            Lines.RemoveAll(l => l.Movie.MovieID == movie.MovieID);

        public decimal ComputeTotalValue() =>
            Lines.Sum(e => e.Movie.price * e.Quantity);

        public void Clear() => Lines.Clear();
    }


public class CartLine
{
    public int CartLineID { get; set; }

    public Movie Movie { get; set; }

    public int Quantity { get; set; }

}
}