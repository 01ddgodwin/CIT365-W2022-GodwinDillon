using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string Book { get; set; } = string.Empty;

        [Range(1, 100)]
        [Column(TypeName = "int()")]
        public int Chapter { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "int()")]
        public int Verse { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(500)]
        public string Note { get; set; }

    }
}
