using System.ComponentModel.DataAnnotations;
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
        public CategoryInst CategoryInst { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; }
        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex {  get; set; }
        public string? Notes { get; set;}

    }
}
