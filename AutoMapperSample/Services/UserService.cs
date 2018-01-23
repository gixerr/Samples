using System.Collections.Generic;
using AutoMapper;
using AutoMapperSample.DTO;
using AutoMapperSample.Models;

namespace AutoMapperSample.Services
{
    public class UserService
    {
        public UserDto GetUserDto(IMapper mapper, User user)
            => mapper.Map<UserDto>(user);

        public List<UserDto> GetUserDtoList(IMapper mapper, IEnumerable<User> usersList)
            => mapper.Map<List<UserDto>>(usersList);
    }
}