using System;
using Newtonsoft.Json;

namespace JsonParser
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            dynamic results = JsonConvert.DeserializeObject<dynamic>(Input.json);
            foreach (var item in results) {
                Console.WriteLine($",'{item.id}'");
            }
        }
    }
}