using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace V2Backend.Models
{
    public class Expense
    {
        [Key]
        public int eid { get; set; }
        public string? description { get; set; }
        public string? category { get; set; }

        public float amount { get; set; }
        public DateTime date { get; set; }
    }
}
