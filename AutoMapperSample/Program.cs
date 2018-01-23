using System;
using System.Collections.Generic;
using AutoMapperSample.DTO;
using AutoMapperSample.Mappers;
using AutoMapperSample.Models;
using AutoMapperSample.Repo;
using AutoMapperSample.Services;


namespace AutoMapperSample.Models
{
    class Program
    {
        static void Main(string[] args)
        { 
            var mapper = AutoMapperConfiguration.Initialize();
            var userRepo = new UserRepository();
            var userService = new UserService();

            var user = userRepo.GetUser();
            var userDto = userService.GetUserDto(mapper, user);
            Console.WriteLine($"\nUser DTO\nFirst name: {userDto.FirstName}\nLast name: {userDto.LastName}\nemail: {userDto.Email}");

            var users = userRepo.GetAllUsers();
            var userDtos = userService.GetUserDtoList(mapper, users);
            userDtos.ForEach(usrDto =>  Console.WriteLine($"\nUser DTO\nFirst name: {usrDto.FirstName}\nLast name: {usrDto.LastName}\nemail: {usrDto.Email}"));

            var motorBike = new MotorBike(
                brand: "Suzuki",
                model: "GSXR-1000",
                power : 190,
                color: "Black",
                tankCapacity : 21,
                maxSpeed : 299,
                store : new Store(
                    name: "World of Suzuki",
                    phoneNumber: "555-666-666"
                )
            );

            var motorBikeService = new MotorBikeService();
            var motorBikeDto = motorBikeService.GetMotorBikeDto(mapper, motorBike);

            Console.WriteLine($"\nMotorbike DTO\nBrand: {motorBikeDto.Brand}\nModel: {motorBikeDto.Model}\nPower: {motorBikeDto.HorsePower}\nFull name: {motorBikeDto.FullBikeName}");
            Console.WriteLine($"Color: {motorBikeDto.BikeDetails.Color}\nTank capacity: {motorBikeDto.BikeDetails.TankCapacity}\nMax speed: {motorBikeDto.BikeDetails.MaxSpeed}");
            Console.WriteLine($"Store: {motorBikeDto.Store.Name}");
        }
    }
}