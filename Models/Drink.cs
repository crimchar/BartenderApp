using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DrinkName { get; set; }
        [Required]
        public string CustomerName { get; set; }
      
    }


}
