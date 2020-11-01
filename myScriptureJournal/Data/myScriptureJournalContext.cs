using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace myScriptureJournal.Data
{
    public class myScriptureJournalContext : DbContext
    {
        public myScriptureJournalContext (DbContextOptions<myScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.Scripture> Scripture { get; set; }
    }
}
