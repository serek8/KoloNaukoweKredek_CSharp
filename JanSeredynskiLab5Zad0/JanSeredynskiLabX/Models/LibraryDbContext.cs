using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JanSeredynskiLabX.Models
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext() : base("DefaultContext") { }
        public virtual DbSet<Movie> Movies{set; get;}
    }
}