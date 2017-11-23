using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models.Accounts;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class MvcMovieContext : IdentityDbContext<ApplicationUser>
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
        public DbSet<MvcMovie.Models.Review> Review { get; set; }
        public DbSet<MvcMovie.Models.Accounts.ApplicationUser> ApplicationUser { get; set; }
    }
}

