using System.Collections.Generic;
using System.Linq;

namespace EnumerableExtensions
{
    public static class BikePrinter
    {
        public static void Print(this IBike bike)
            => System.Console.WriteLine($"{bike.Brand} {bike.Model} \tPower: {bike.Power} \tPrice : {bike.Price}");
        
        public static void Print(this IEnumerable<IBike> bikes)
            => bikes.ToList().ForEach(bike => System.Console.WriteLine($"Brand: {bike.Brand} \tModel: {bike.Model} \tPower: {bike.Power} \tPrice : {bike.Price}"));
    }
}