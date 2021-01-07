using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProjectMini.Models
{
    public class Movie
    {
        public long MovieID { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string NameUser { get; set; }

        public int Views { get; set; }

        public string Time { get; set; }

        public string link { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
    }
}
