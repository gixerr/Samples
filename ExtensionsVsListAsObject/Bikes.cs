using System.Collections.Generic;
using System.Linq;

namespace EnumerableExtensions
{
    public class Bikes
    {
        private IEnumerable<IBike> ContainedBikes { get; }
        public IEnumerable<IBike> Content => this.ContainedBikes;
        public Bikes(IEnumerable<IBike> bikes)
        {
            this.ContainedBikes = bikes.ToList();
        }

        public Bikes GetAllAvalible()
            => new Bikes(this.ContainedBikes.Where(bike => bike.IsAvalible));

        public IBike GetTheCheapestOne() 
            => this.ContainedBikes.WithLowest(bike => bike.Price);

         public IBike GetTheWeakestOne()
            => this.ContainedBikes.WithLowest(bike => bike.Power);

        public IBike GetTheMostPowerfulOne()
            => this.ContainedBikes.WithHighest(bike => bike.Power);

        public IBike GetTheMostExpensiveOne()
            => this.ContainedBikes.WithHighest(bike => bike.Price);
    }

}