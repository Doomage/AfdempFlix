namespace AfdempFlix.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MoviesContext : DbContext
    {
        
        public MoviesContext()
            : base("name=MoviesContext")
        {
        }

        public virtual DbSet<Movie> MyEntities { get; set; }
    }
}