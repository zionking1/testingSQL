using System;
using System.Collections.Generic;

namespace sustain_wok
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> {1,   1};
            var previous fibonacciNumbers[fibonacciNumbers.Count-1];
            var previous2 fibonacciNumbers[fibonacciNumbers.Count-2];
            fibonacciNumbers.Add(previous + previous2);
            foreach(var item in fibonacciNumbers);
            Console.WriteLine(item);
            var names = new List<string> {"Godwin", "Ana", "Felipe" };
            foreach ( var name  in names)
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Add("judith");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"my name is {names[0]}");
                Console.WriteLine($"i have added {names [2]} and {names [3]}");
                Console.WriteLine($"Hello {name.ToUpper()}");
                Console.WriteLine($"The list has {names.Count} people in it");

                var indexof = names.IndexOf("Felipe");
                if(index == -1)
               
                {
                    Console.WriteLine($" The name{names[index]} is at index{index}");
                    var notFound = names.IndexOf("notFound");
                    Console.WriteLine($"when an item is not found, Index returns {notFound}");  
                    names.sort();
                    foreach ( var name in names)
                {
                    Console.WriteLine($"hello {name.ToUpper()}!");
                
                
            }
            

        }
    }
}
    }   