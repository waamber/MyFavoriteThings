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

            var drinks = new List<Drinks>()
            {
                new Drinks {Name= "Bell's Two Hearted Ale", Type= "Beer"},
                new Drinks {Name= "Gin Mule", Type= "Liquor"},
                new Drinks {Name= "Cabernet Sauvignon", Type= "Wine"}
            };

            foreach (var drink in drinks)
            {
                Console.WriteLine($"Most nights I drink {drink.Name} if I'm in the mood for {drink.Type}.");
            }

            var food = new Food()
            {
                Name= "Tacos",
                Type= "Mexican",
                Price= "cheap af"
            };

            Console.WriteLine(food.IEat(food.Name, food.Type, food.Price));

            var dog = new List<Dogs>()
            {
                new Dogs {Name= "Puggy", Breed= "Pug", GoodDoge= true},
                new Dogs {Name= "Jeff", Breed= "Westie", GoodDoge= false},
                new Dogs {Name= "Delta", Breed= "Goldie", GoodDoge= true}
            };

            foreach (var doge in dog)
            {
                Console.WriteLine(doge.HiDoggie(doge.Breed, doge.Name, doge.GoodDoge));
            }
            

            Console.ReadLine();
        }   
    }
}
