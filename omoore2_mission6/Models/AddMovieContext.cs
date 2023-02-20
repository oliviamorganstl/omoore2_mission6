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

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
                 );

            mb.Entity<AddResponse>().HasData(
                new AddResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
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
                    CategoryID = 2,
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
                    CategoryID = 3,
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
