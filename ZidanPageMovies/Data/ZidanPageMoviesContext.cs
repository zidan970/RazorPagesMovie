#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZidanPageMovies.Models;

namespace ZidanPageMovies.Data
{
    public class ZidanPageMoviesContext : DbContext
    {
        public ZidanPageMoviesContext (DbContextOptions<ZidanPageMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<ZidanPageMovies.Models.Movie> Movie { get; set; }
    }
}
