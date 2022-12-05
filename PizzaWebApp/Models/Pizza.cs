using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaWebApp.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]  //after authentication process update dataBase
        public int Price { get; set; }
        [Required]
        public string Url { get; set; }


        // get chef Pid here as Fid  notes--5.1
        [ForeignKey("PizzaCheff")]
        public int CheffFID { get; set; }
        public virtual Cheff PizzaCheff { get; set; }
    }
}

/*
 * form with MVC
 * search form
 * Authentication
 * update price M DB V 
 * entity relation with new MODEL (cheff)
 * virtual to refrence to anther table like cheff to Pizza not a table in this Model
 * 
 
 */
