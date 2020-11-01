using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using myScriptureJournal.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly myScriptureJournal.Data.myScriptureJournalContext _context;

        public IndexModel(myScriptureJournal.Data.myScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        public string ScriptureBook { get; set; }
        



        //sorting method variables
        public string BookSort { get; set; }
        public string DateSort { get; set; }



        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";


            // Use LINQ to get list of titles.
            IQueryable<string> genreQuery = from s in _context.Scripture
                                            orderby s.Book
                                            select s.Book;

            var scriptures = from s in _context.Scripture
                         select s;

            switch (sortOrder)
            {
                case "Date":
                    //Scripture = Scripture.OrderBy(d => d.AddedDate);
                    break;
                case "Book":
                    //Scripture = Scripture.OrderByDescending(s => s.Book);
                    break;
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(DateSort))
            {
                scriptures = scriptures.Where(d => d.AddedDate == Convert.ToDateTime(DateSort));
            }

            Scripture = await _context.Scripture.ToListAsync();
        }
    }
}
