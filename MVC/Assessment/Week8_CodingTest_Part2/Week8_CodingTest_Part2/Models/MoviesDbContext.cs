using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Week8_CodingTest_Part2.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext() : base("name=connectstr") { }

        public DbSet<Movies> Movie { get; set; }
    }
}
