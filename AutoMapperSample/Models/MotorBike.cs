namespace AutoMapperSample.Models
{
    public class MotorBike
    {
        public MotorBike(string brand, string model, int power, string color, int tankCapacity, int maxSpeed, Store store)
        {
            this.Brand = brand;
            this.Model = model;
            this.Power = power;
            this.Color = color;
            this.TankCapacity = tankCapacity;
            this.MaxSpeed = maxSpeed;
            this.Store = store;
        }
        public string Brand { get; protected set; }
        public string Model { get; protected set; }
        public int Power { get; protected set; }
        public string Color { get; protected set; }
        public int TankCapacity { get; protected set; }
        public int MaxSpeed { get; protected set; }
        public Store Store { get; set; }

    }

}