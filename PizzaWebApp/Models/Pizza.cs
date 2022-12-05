using System.ComponentModel.DataAnnotations;

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
        //[Required]  after authentication process update dataBase
        //public int Price { get; set; }
        [Required]
        public string Url { get; set; }
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
