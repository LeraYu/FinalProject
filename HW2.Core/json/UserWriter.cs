using System.Collections.Generic;
using TP.Core.user;
using Newtonsoft.Json;

namespace TP.Core.json
{
    public class UserWriter : Writer
    {
        public static void Write(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users);

            WriteToFile("users.json", json);
        }
    }
}