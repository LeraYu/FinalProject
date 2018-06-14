using System;
using System.Collections.Generic;
using HW2.Core.transport;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static HW2.Core.transport.Restaurant;

namespace HW2.Core.json
{
    public class RestaurantWriter : Writer
    {
        public static void Write()
        {
            var caesar = new Food()
            {
                Id = 1,
                FoodName = "Caesar with  chicken"
            };
            var beefSteak = new Food()
            {
                Id = 2,
                FoodName = "Beef Steak"
            };
            var redWine = new Food()
            {
                Id = 3,
                FoodName = "Red Wine"
            };
            var omelette = new Food()
            {
                Id = 4,
                FoodName = "Omelette"
            };
            var porridge = new Food()
            {
                Id = 5,
                FoodName = "Oatmeal porridge"
            };
            var cola = new Food()
            {
                Id = 6,
                FoodName = "Coca-Cola"
            };
            var pizzaPineapple = new Food()
            {
                Id = 7,
                FoodName = "Pizza with pineapples and chicken"
            };
            var pepperoni = new Food()
            {
                Id = 8,
                FoodName = "Pizza with pepperoni"
            };

            var breakfast = new Time()
            {
                TimeOfEat = "Breakfast"
            };

            var Dinner = new Time()
            {
                TimeOfEat = "Dinner"
            };

            var Supper = new Time()
            {
                TimeOfEat = "Supper"
            };




            var json = JsonConvert.SerializeObject(
                new Content(
                    new List<Food>
                    {
                      caesar,
                      beefSteak,
                      redWine,
                      omelette,
                      porridge,
                      cola,
                      pizzaPineapple,
                      pepperoni
                    },
                new List<Restaurant>
                {
                    new Restaurant()
                    {
                        Path = new List<PathElement>
                        {
                            new PathElement()
                            {
                            Id = 1,
                            FoodId = caesar.Id,
                            Time= breakfast,
                            Price=100
                            }


                        }
                    }

                }));
             WriteToFile("hw1.json", json);
        }
    }
}