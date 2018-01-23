using System;
using System.Collections.Generic;

namespace EnumerableExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st solution
            IEnumerable<IBike> bikeShop = MockBikeFactory.ProduceBikes(); 

            bikeShop.PrintAllAvalibleBikes();
            bikeShop.PrintTheCheapestAvalibleBike();
            bikeShop.PrintTheMostExpensiveAvalibleBike();
            bikeShop.PrintTheWeakestAvalibleBike();
            bikeShop.PrintTheMostPowerfulAvalibleBike();

            System.Console.WriteLine("\n***************************************************************************************************");

            // 2nd solution
            var bikeStore = new Bikes(MockBikeFactory.ProduceBikes());

            System.Console.WriteLine("\nAll avalible bikes in shop.");
            bikeStore.GetAllAvalible().Content.Print();

            System.Console.Write($"\nThe cheapest avalible bike in shop is: ");
            bikeStore.GetAllAvalible().GetTheCheapestOne().Print();

            System.Console.Write($"\nThe most expensive avalible bike in shop is: ");
            bikeStore.GetAllAvalible().GetTheMostExpensiveOne().Print();

            System.Console.Write($"\nThe weakest avalible bike in shop is: ");
            bikeStore.GetAllAvalible().GetTheWeakestOne().Print();

            System.Console.Write($"\nThe most powerful avalible bike in shop is: ");
            bikeStore.GetAllAvalible().GetTheMostPowerfulOne().Print();

            System.Console.WriteLine("\n***************************************************************************************************\n");

            //Adding new features... (1st solution)
            //We need to add new extension method and then call it...
            bikeShop.PrintAllBikesInShop();
            bikeShop.PrintTheMostExpensiveBike();

            System.Console.WriteLine("\n***************************************************************************************************");            

            //Adding new features... (2nd solution)
            //Here we operate directly on the collection
            System.Console.WriteLine("\nAll bikes in shop.");
            bikeStore.Content.Print();

            System.Console.Write($"\nThe most expensive bike in shop is: ");
            bikeStore.GetTheMostExpensiveOne().Print();
            //and so on...
            
        }
    }
}
