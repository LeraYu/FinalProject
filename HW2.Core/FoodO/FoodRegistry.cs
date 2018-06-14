using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TP.Core.transport
{
    public class FoodRegistry
    {
        private readonly List<Food> foods;
        private readonly Dictionary<int, List<Restaurant>> foodToRestaurants;

        public FoodRegistry()
        {
            using (var context = new Context())
            {
                foods = context.Food.ToList();
                foodToRestaurants = new Dictionary<int, List<Restaurant>>();
                foreach (var restaurant in context.Restaurants.ToList())
                {

                    foreach (var pathElement in restaurant.Path)
                    {
                        if (foodToRestaurants.TryGetValue(pathElement.FoodId, out List<Restaurant> foodRestaurant))
                        {
                            foodRestaurant.Add(restaurant);
                        }
                        else
                        {
                            foodToRestaurants.Add(pathElement.FoodId, new List<Restaurant>() { restaurant });
                        }
                    }
                }
            }
        }

        public List<Food> GetFoods()
        {
            return foods;
        }

        public Food GetFoodById(int id)
        {
            return foods.Find(food => food.Id == id);
        }

        public Food GetFoodByName(string foodName)
        {
            return foods.Find(food => food.FoodName.Equals(foodName));
        }

        public List<Restaurant> GetRestaurantByFood(Food food)
        {
            List<Restaurant> result = new List<Restaurant>();
            Console.WriteLine(foodToRestaurants);
            if (foodToRestaurants.TryGetValue(food.Id, out result))
            {
                Console.WriteLine("Reult");
                return result;
            }
            else
            {
                Console.WriteLine("null");

                return null;
            }
        }
    }
}
