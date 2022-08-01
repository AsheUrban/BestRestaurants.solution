using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            this.JoinEntities = new HashSet<Diner>();
        }

        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Diner> JoinEntities { get; }
    }
}