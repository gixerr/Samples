using AutoMapper;
using AutoMapperSample.DTO;
using AutoMapperSample.Models;

namespace AutoMapperSample.Mappers
{
    public class AutoMapperConfiguration
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {   
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<MotorBike, MotorBikeDto>()
                    .ForMember(dto => dto.HorsePower,
                               opts => opts.MapFrom(model => model.Power))
                    .ForMember(dto => dto.FullBikeName,
                               opts => opts.MapFrom(model => $"{model.Brand} {model.Model}"))
                    .ForMember(dto => dto.BikeDetails,
                               opts => opts.MapFrom(
                                   model => new Details
                                   {
                                       Color = model.Color,
                                       TankCapacity = model.TankCapacity,
                                       MaxSpeed = model.MaxSpeed
                                   }));
                //Nested mapping
                cfg.CreateMap<Store, StoreDto>();
            })
            .CreateMapper();
    }
}