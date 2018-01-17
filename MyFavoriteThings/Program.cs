using System;
using System.Collections.Generic;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var cheeses = new List<Cheese>()
            {
                new Cheese {Name= "Goat Cheese", Type= "Goat"},
                new Cheese {Name= "Gouda", Type= "Cow"},
                new Cheese {Name= "Pecorino", Type= "Sheep"}
            };

            foreach (var cheese in cheeses)
            {
                Console.WriteLine($"I love {cheese.Name}. It is made from the milk of a {cheese.Type}.");

            }

            Console.ReadLine();
        }   
    }
}
