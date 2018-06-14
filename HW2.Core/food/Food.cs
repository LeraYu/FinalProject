using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace HW2.Core.transport
{
    [Table("Food")]
    public class Food
    {
        //public Station(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //}

        public int Id { get; set; }
        public string FoodName { get; set; }

        public override bool Equals(object obj)
        {
            var food = obj as Food;
            return food != null &&
                   Id == food.Id &&
                   FoodName == food.FoodName;
        }

        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FoodName);
            return hashCode;
        }
    }
}