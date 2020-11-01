using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using myScriptureJournal.Data;

namespace myScriptureJournal.Pages.Scriptures
{
    public class DetailsModel : PageModel
    {
        private readonly myScriptureJournal.Data.myScriptureJournalContext _context;

        public DetailsModel(myScriptureJournal.Data.myScriptureJournalContext context)
        {
            _context = context;
        }

        public Scripture Scripture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scripture = await _context.Scripture.FirstOrDefaultAsync(m => m.ID == id);

            if (Scripture == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
