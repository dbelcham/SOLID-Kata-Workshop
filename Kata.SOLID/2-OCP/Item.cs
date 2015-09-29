namespace Kata.SOLID
{
    public class Item
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Item(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}