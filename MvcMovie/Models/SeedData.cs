using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Best Two Years",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Baptists at Our Barbeque",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Romantic Comedy",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Charlie",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}