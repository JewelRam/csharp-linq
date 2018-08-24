using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits =
           from fruit in fruits
           where fruit.StartsWith("L")
           select fruit;

            foreach (var item in LFruits)
            {
                Console.WriteLine(item);
            }


            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };


            List<int> areAllEven = numbers.Where(number => number % 4 == 0 || number % 6 == 0).ToList();
            foreach (int number in areAllEven)
            {
                Console.WriteLine(number);
            }
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

            List<string> ascending = names.OrderBy(m => m).ToList();
            List<string> descending = names.OrderByDescending(m => m).ToList();
            foreach (string item in ascending)
            {
                Console.WriteLine(item);
            }

            // What is our most expensive product?
            List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};

            Console.WriteLine();





        }
    }
}
