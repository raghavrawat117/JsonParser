using System;
using Newtonsoft.Json;

namespace JsonParser
{
    public class ListProgram
    {
        static string list1Path = @"C:\...\JsonParser\JsonParser\JsonParser\List1.txt";
        static string list2Path = @"C:\...\JsonParser\JsonParser\JsonParser\List2.txt";
        public static void Run(string[] args)
        {
            string list1Content = Input.FileAsString(list1Path);
            string list2Content = Input.FileAsString(list2Path);

            List<int> list1 = list1Content.Split(['\n',','], StringSplitOptions.RemoveEmptyEntries)
            .ToList().Select(int.Parse).ToList();

            List<int> list2 = list2Content.Split(['\n',','], StringSplitOptions.RemoveEmptyEntries)
            .ToList().Select(int.Parse).ToList();

            // // Union
            List<int> union = list1.Union(list2).ToList();
            union.Sort();

            // // Intersection
            List<int> intersection = list1.Intersect(list2).ToList();
            intersection.Sort();

            // print final list
            PrintList(union);
            PrintList(intersection);
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}