using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProjectMini.Models.ViewModels
{
    public class MoviesListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public PagingInfo PagingInfo { get; set; } // Phan trang
        public string CurrentCategory { get; set; }
    }
}
