using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProjectMini.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalMovies { get; set; }
        public int MoviesPerpage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalMovies / MoviesPerpage);
    }
}
