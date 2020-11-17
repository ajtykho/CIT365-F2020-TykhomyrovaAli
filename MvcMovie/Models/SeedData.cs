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
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy/Religion",
                        Rating = "PG",
                        Price = 7.99M,
                        ImgPath = "thrm.JPG"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = "Comedy/Drama",
                        Rating = "PG",
                        Price = 8.99M,
                        ImgPath = "best2years.JPG"
                    },

                    new Movie
                    {
                        Title = "Baptists at Our Barbeque",
                        ReleaseDate = DateTime.Parse("2004-10-08"),
                        Genre = "Romantic Comedy",
                        Rating = "PG",
                        Price = 9.99M,
                        ImgPath = "baptists.JPG"
                    },

                    new Movie
                    {
                        Title = "Charly",
                        ReleaseDate = DateTime.Parse("2002-11-20"),
                        Genre = "Drama/Comedy/Romance",
                        Rating = "PG",
                        Price = 3.99M,
                        ImgPath = "charly.JPG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}