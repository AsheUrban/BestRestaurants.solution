using System;
using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Diner
  {
    public Diner()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
    
    public int DinerId { get; set; }
    public string DinerName { get; set; }
    public bool NutAllergy { get; set; }
    public bool DairyAllergy { get; set; }
    public bool GlutenAllergy { get; set; }
    public virtual int RestaurantId { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}