using AutoMapper;
using AutoMapperSample.DTO;
using AutoMapperSample.Models;

namespace AutoMapperSample.Services
{
    public class MotorBikeService
    {
        public MotorBikeDto GetMotorBikeDto(IMapper mapper, MotorBike motorBike)
            => mapper.Map<MotorBikeDto>(motorBike);
    }
}