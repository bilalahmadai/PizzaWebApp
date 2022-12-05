using System.ComponentModel.DataAnnotations;

namespace PizzaWebApp.Models
{
    public class Cheff
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Cheff_name { get; set; }
    }
}
