namespace AutoMapperSample.Models
{
    public class User
    {
        public User(string firstName, string lastName, string password, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Email = email;
        }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Password { get; protected set; }
        public string Email { get; protected set; }
    }
}