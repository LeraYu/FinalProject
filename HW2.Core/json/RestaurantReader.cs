using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using TP.Core.transport;
using Newtonsoft.Json;


namespace TP.Core.json
{
    public class RestaurantReader : Reader
    {
        public static void Read()
        {
            var json = ReadFromFile("rest.json");

            Content content = JsonConvert.DeserializeObject<Content>(json);

            using (var context = new Context())
            {
               

                context.Food.AddOrUpdate(d => d.Id, content.Food.ToArray());
                context.SaveChanges();

                context.Restaurants.AddOrUpdate(d => d.Id, content.Restaurants.ToArray());
                context.SaveChanges();

                var array = content.Restaurants.SelectMany(restaurant => restaurant.Path).ToArray();
                
                context.PathElements.AddOrUpdate(d => d.Id, array);

                context.SaveChanges();

            }
        }
    }
}