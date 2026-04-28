using System;
using Newtonsoft.Json;

namespace JsonParser
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            // // 1. for parsing json-list
            // dynamic results = JsonConvert.DeserializeObject<dynamic>(Input.StringJson);
            // foreach (var item in results) {
            //     Console.WriteLine($",'{item.id}'");
            // }

            // // 2. for parsing data with new line
            // List<string> results = Input.StringInput.Split(Environment.NewLine).ToList();
            // foreach (var item in results) {
            //     Console.WriteLine($"| {item} |");
            // }

            // // 3. for parsing data from file
            // // Provide Complete file path
            // string filePath = @"C:\...\JsonParser\JsonParser\InputFile.txt";
            // string fileContent = Input.FileAsString(filePath);
            // List<string> results = fileContent.Split(['\n'], StringSplitOptions.RemoveEmptyEntries).ToList();
            // int c=0;
            // foreach (var item in results) {
            //     string id = item.Split(',')[0];
            //     string name = item.Split(',')[1];
            //     string age = item.Split(',')[2];
            //     Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
            //     c++;
            // }
            // Console.WriteLine($"Total lines: {c}");
            // Console.WriteLine(fileContent);

        }
    }
}