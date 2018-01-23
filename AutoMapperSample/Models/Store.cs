namespace AutoMapperSample.Models
{
    public class Store
    {
        public Store(string name, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}