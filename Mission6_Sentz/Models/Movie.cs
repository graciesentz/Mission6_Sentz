﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Sentz.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }


        [ForeignKey("CategoryId")]
        [Required]
        public int CategoryId { get; set; }

        [NotMapped]
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex {  get; set; }
        public string? Notes { get; set;}

    }
}
