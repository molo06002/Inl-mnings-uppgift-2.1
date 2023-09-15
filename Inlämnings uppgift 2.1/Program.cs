// See https://aka.ms/new-console-template for more information
using System;
namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Vilken är din favorit bok?";
            Console.WriteLine(x);
            string bok = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(bok);

        }
    }
}