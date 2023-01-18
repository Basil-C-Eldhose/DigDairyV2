using System.ComponentModel.DataAnnotations;

namespace V2Backend.Models
{
    public class Categoryy
    {
        [Key]
        
        public int cid { get; set; }
        public string? category { get; set; }
    }
}
