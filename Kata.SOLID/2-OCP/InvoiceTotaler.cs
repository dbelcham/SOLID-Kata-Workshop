using System.Linq;

namespace Kata.SOLID
{
    public class InvoiceTotaler
    {
        public double CalculateFor(Invoice invoice)
        {
            return invoice.Items.Sum(x => x.Count*x.Price);
        }
    }
}