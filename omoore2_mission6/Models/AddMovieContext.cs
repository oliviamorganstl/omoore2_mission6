using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace omoore2_mission6.Models
{
    public class AddMovieContext : DbContext
    {
        public AddMovieContext (DbContextOptions<AddMovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<AddResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddResponse>().HasData(
                new AddResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Serenity",
                    Year = 2005,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new AddResponse
                {
                    MovieID = 2,
                    Category = "Action/Adventure",
                    Title = "Snatch",
                    Year =2001,
                    Director = "Guy Ritchie",
                    Rating = "R",
                    Edited = true,
                    Lent = "",
                    Notes = ""
                },
                new AddResponse
                {
                    MovieID = 3,
                    Category = "Action/Adventure",
                    Title = "Sneakers",
                    Year = 1992,
                    Director = "Phil Alden Robinson",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                }
           );
        }
    }
}
