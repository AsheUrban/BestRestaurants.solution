using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
    {
        public Cuisine()
        {
            this.JoinEntities = new HashSet<Diner>();
        }

        public int CuisineId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Diner> JoinEntities { get; set; }
    }
}