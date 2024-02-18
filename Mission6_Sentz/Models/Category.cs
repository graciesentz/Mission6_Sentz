using System.ComponentModel.DataAnnotations;

namespace Mission6_Sentz.Models
{
    public class CategoryInst
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category {  get; set; }
    }
}
