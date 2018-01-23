using AutoMapperSample.Models;

namespace AutoMapperSample.DTO
{
    public class MotorBikeDto
    {
        public string Brand { get; protected set; }
        public string Model { get; protected set; }
        public int HorsePower { get; protected set; }
        public string FullBikeName { get; protected set; }
        public Details BikeDetails { get; protected set; }
        public StoreDto Store { get; set; }
    }
}