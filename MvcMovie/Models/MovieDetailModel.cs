using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieDetailModel
    {
        public Movie movie { get; set; }
        public List<Review> reviews { get; set; }
    }
}
