namespace Kata.SOLID
{
    public class Customer
    {
        public string Name { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

        public Customer(string name, string province, string country)
        {
            Name = name;
            Province = province;
            Country = country;
        }
    }
}