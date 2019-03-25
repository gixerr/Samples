namespace Attributes.Models
{
    class UserDebugDisplay
    {
        private readonly User _user;

        public UserDebugDisplay(User user)
        {
            _user = user;
        }

        public string UpperFirstName => _user.FirstName.ToUpperInvariant();
        public string LowerLastName => _user.LastName.ToLowerInvariant();
        public string AgeInHex => _user.Age.ToString("X");
    }
}