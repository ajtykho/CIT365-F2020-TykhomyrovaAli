using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using myScriptureJournal.Data;
using MyScriptureJournal.Models;
using System;
using System.Linq;

namespace RazorPagesScripture.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new myScriptureJournalContext(
                serviceProvider.GetRequiredService<DbContextOptions<myScriptureJournalContext>>()))
            {
                // Look for any scriptures
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Psalms",
                        Chapter = 119,
                        verseStart = 105,
                        verseEnd = 105,
                        Notes = "Old Testiment Scripture Mastery",
                        AddedDate = DateTime.Parse("2019-3-02")
                    },

                    new Scripture
                    {
                        Book = "Acts",
                        Chapter = 3,
                        verseStart = 19,
                        verseEnd = 21,
                        Notes = "Old Testiment Scripture Mastery",
                        AddedDate = DateTime.Parse("2010-8-23")
                    },

                    new Scripture
                    {
                        Book = "Mosiah",
                        Chapter = 4,
                        verseStart = 30,
                        verseEnd = 30,
                        Notes = "Book of Mormon Scripture Mastery",
                        AddedDate = DateTime.Parse("2017-12-15")
                    },

                    new Scripture
                    {
                        Book = "Section",
                        Chapter = 46,
                        verseStart = 33,
                        verseEnd = 33,
                        Notes = "Doctrine and Covenants Scripture Mastery",
                        AddedDate = DateTime.Parse("2020-1-30")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}