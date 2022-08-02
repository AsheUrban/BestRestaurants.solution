using System;
using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Diner
    {
        public int DinerId { get; set; }
        public string DinerName { get; set; }
        public bool DinerAllergies { get; set; }
        public DateTime Date { get; set; }
        // public virtual Restaurant Restaurant { get; set; }
        // public virtual Cuisine Cuisine { get; set; }
    }
}