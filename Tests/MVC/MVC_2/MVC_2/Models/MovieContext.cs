using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_2.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext():base("name=connectstr")
        { }
        public DbSet<Movie> Movies { get; set; }
    }
}