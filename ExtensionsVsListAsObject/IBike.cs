namespace EnumerableExtensions
{
    public interface IBike
    {
        bool IsAvalible { get; set; } 
        string Brand { get; set; }
        string Model { get; set; }
        decimal Price { get; set; }
        int Power { get; set; }
    }
}