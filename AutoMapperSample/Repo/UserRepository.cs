using System.Collections.Generic;
using System.Linq;
using AutoMapperSample.Models;

namespace AutoMapperSample.Repo
{
    public class UserRepository
    {
        public UserRepository()
        {
            InitializeUsers();
        }
        private IEnumerable<User> _users;
        public User GetUser() 
            => _users.FirstOrDefault();

        public IEnumerable<User> GetAllUsers() 
            => _users;

        void InitializeUsers()
        {
            _users = new List<User>
            {
                 new User(
                    firstName: "UserFirstName1",
                    lastName: "UserLastName1",
                    password: "secret1",
                    email: "UserFirstName1.UserLastName1@mail.com"),
                 new User(
                    firstName: "UserFirstName2",
                    lastName: "UserLastName2",
                    password: "secret2",
                    email: "UserFirstName2.UserLastName2@mail.com"),
                 new User(
                    firstName: "UserFirstName3",
                    lastName: "UserLastName3",
                    password: "secret3",
                    email: "UserFirstName3.UserLastName3@mail.com"),
                new User(
                    firstName: "UserFirstName4",
                    lastName: "UserLastName4",
                    password: "secret4",
                    email: "UserFirstName4.UserLastName4@mail.com"),
                new User(
                    firstName: "UserFirstName5",
                    lastName: "UserLastNam5",
                    password: "secret5",
                    email: "UserFirstName5.UserLastName@mail5.com"),
            };
        }

    }
}