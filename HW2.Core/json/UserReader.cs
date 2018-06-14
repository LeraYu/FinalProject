using System.Collections.Generic;
using TP.Core.user;
using Newtonsoft.Json;

namespace TP.Core.json
{
    public class UserReader : Reader
    {
        public static List<User> Read()
        {
            var json = ReadFromFile("../../../users.json");

            return JsonConvert.DeserializeObject<List<User>>(json);
        }
    }
}