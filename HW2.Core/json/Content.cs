using TP.Core.transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Core.json
{
    class Content
    {
        public Content(List<Food> foods, List<Restaurant> restaurants)
        {
            Food = foods;
            Restaurants = restaurants;
        }

        public List<Food> Food { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}
