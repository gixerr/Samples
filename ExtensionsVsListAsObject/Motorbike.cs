namespace EnumerableExtensions
{
    public class Motorbike : IBike
    {
        public bool IsAvalible { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Power { get; set; }

    }
}