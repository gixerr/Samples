using System.Collections.Generic;

namespace EnumerableExtensions
{
    public class MockBikeFactory
    {
        public static IEnumerable<IBike> ProduceBikes()
        {
            return new List<IBike>
            {
                new Motorbike
                {
                    Brand = "Suzuki",
                    Model = "GSXR1000",
                    Price = 40000M,
                    Power = 200,
                    IsAvalible = true
                },
                new Motorbike
                {
                    Brand = "Honda",
                    Model = "FireBlade",
                    Price = 50000M,
                    Power = 180,
                    IsAvalible = true
                },
                new Motorbike
                {
                    Brand = "Yamaha",
                    Model = "R1",
                    Price = 45000M,
                    Power = 210,
                    IsAvalible = true
                },
                new Motorbike
                {
                    Brand = "Kawasaki",
                    Model = "Ninja",
                    Price = 39000M,
                    Power = 175,
                    IsAvalible = true
                },
                new Motorbike
                {
                    Brand = "Ducati",
                    Model = "Panigale",
                    Price = 60000M,
                    Power = 205,
                    IsAvalible = false
                }
            };
        }
    }
}