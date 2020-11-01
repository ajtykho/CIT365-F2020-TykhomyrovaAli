using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int verseStart { get; set; }
        public int verseEnd { get; set; }
        public string Notes { get; set; }

        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }


    }
}