using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableExtensions
{
    public static class BikeExtensions
    {
        public static void PrintAllAvalibleBikes(this IEnumerable<IBike> bikes)
        {
            System.Console.WriteLine("\nAll avalible bikes in shop.");
            bikes
                .Where(bike => bike.IsAvalible)
                .ToList()
                .ForEach(bike => System.Console.WriteLine($"Brand: {bike.Brand} {bike.Model} \tPower: {bike.Power} \tPrice : {bike.Price}"));
        }
        public static void PrintTheCheapestAvalibleBike(this IEnumerable<IBike> bikes)
        {
            var cheapestBike = bikes
                                .Where(bike => bike.IsAvalible)
                                .WithLowest(bike => bike.Price);

            System.Console.WriteLine
            ($"\nThe cheapest avalible bike in shop is: {cheapestBike.Brand} {cheapestBike.Model} \tPower: {cheapestBike.Power} \tPrice : {cheapestBike.Price}");
        }

        public static void PrintTheWeakestAvalibleBike(this IEnumerable<IBike> bikes)
        {
            var weakestBike = bikes
                                .Where(bike => bike.IsAvalible)
                                .WithLowest(bike => bike.Power);

            System.Console.WriteLine
            ($"\nThe weakest avalible bike in shop is: {weakestBike.Brand} {weakestBike.Model} \tPower: {weakestBike.Power} \tPrice : {weakestBike.Price}");
        }

        public static void PrintTheMostPowerfulAvalibleBike(this IEnumerable<IBike> bikes)
        {
            var mostPowerful = bikes
                                .Where(bike => bike.IsAvalible)
                                .WithHighest(bike => bike.Power);

            System.Console.WriteLine
            ($"\nThe most powerful avalible bike in shop is: {mostPowerful.Brand} {mostPowerful.Model} \tPower: {mostPowerful.Power} \tPrice : {mostPowerful.Price}");
        }

        public static void PrintTheMostExpensiveAvalibleBike(this IEnumerable<IBike> bikes)
        {
            var mostExpensive = bikes
                                .Where(bike => bike.IsAvalible)
                                .WithHighest(bike => bike.Price);

            System.Console.WriteLine
            ($"\nThe most expensive avalible bike in shop is: {mostExpensive.Brand} {mostExpensive.Model} \tPower: {mostExpensive.Power} \tPrice : {mostExpensive.Price}");
        }

        public static void PrintAllBikesInShop(this IEnumerable<IBike> bikes)
        {
            
            bikes
                .ToList()
                .ForEach(bike => System.Console.WriteLine($"Brand: {bike.Brand} {bike.Model} \tPower: {bike.Power} \tPrice : {bike.Price}"));
        }

        public static void PrintTheMostExpensiveBike(this IEnumerable<IBike> bikes)
        {
            var mostExpensive = bikes
                                .WithHighest(bike => bike.Price);

            System.Console.WriteLine
            ($"\nThe most expensive avalible bike in shop is: {mostExpensive.Brand} {mostExpensive.Model} \tPower: {mostExpensive.Power} \tPrice : {mostExpensive.Price}");
        }
    }
}