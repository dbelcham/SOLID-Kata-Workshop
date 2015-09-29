using System.Collections.Generic;

namespace Kata.SOLID
{
    public class Invoice
    {
        private IList<Item> _items;
        public Customer Customer { get; set; }
        public IEnumerable<Item> Items { get { return _items; } }

        public Invoice(Customer customer)
        {
            Customer = customer;
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }
    }
}