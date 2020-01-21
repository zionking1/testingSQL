using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Godwin", "Ana", "Felipe" };
foreach (var name in names)
{
Console.WriteLine($"Hello {name.ToUpper()}!");
            Console.WriteLine("Hello World!");
        }
    }
    } 
}
