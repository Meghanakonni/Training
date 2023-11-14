using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_02.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=connectstr")
        { }
        public DbSet<Movie> Movies { get; set; }
    }
}