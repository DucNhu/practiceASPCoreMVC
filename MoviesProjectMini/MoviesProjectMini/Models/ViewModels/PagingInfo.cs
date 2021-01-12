using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProjectMini.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; } // tong so lg spham
        public int ItemsPerpage { get; set; } // 1 trag bnhieu sphham
        public int CurrentPage { get; set; } // Trag hien tai

        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerpage); //tong so trang lay tong so lg / spham moi trang
    }
}
