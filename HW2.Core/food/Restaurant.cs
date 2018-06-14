using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HW2.Core.transport
{
    [Table("Restaurants")]
    public class Restaurant
    {
        private bool _isInited = false;

        //public Route(int number,
        //    List<PathElement> path,
        //    DateTime firstDeparture,
        //    DateTime lastDeparture,
        //    int interval)
        //{
        //    _isInited = false;
        //    Number = number;
        //    Path = path;

        //    FirstDeparture = firstDeparture;
        //    LastDeparture = lastDeparture;

        //    Interval = interval;
        //}

        public int Id { get; set; }
        public int RestaurantName { get; set; }

        public virtual List<PathElement> Path { get; set; }
    
        

        public class PathElement
        {
            public PathElement()
            {
            }

            public PathElement(int id, int foodId, Time time, int price)
            {
                Id = id;
                FoodId = foodId;
            
                Time = time;
                Price = price;
            }

            public int Id { get; set; }
            
            public int FoodId { get; set; }

            public Time Time { get; set; }

            public int Price { get; set; }

            [JsonIgnore]
            [ForeignKey("Restaurant")]
            public virtual int RestaurantId { get; set; }

            [JsonIgnore]
            public virtual Restaurant Restaurant { get; set; }
        }

        public class Time
        {
            public string TimeOfEat { get; set; }
        }
            
    }
}