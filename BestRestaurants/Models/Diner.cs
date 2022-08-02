namespace BestRestaurants.Models
{
  public class Diner
    {
        public int DinerId { get; set; }
        public int RestaurantId { get; set; }
        public int CuisineId { get; set; }

        public string Name { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual Cuisine Cuisine { get; set; }
    }
}