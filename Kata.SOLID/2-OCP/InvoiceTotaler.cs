using System.Linq;

namespace Kata.SOLID
{
    public interface IInvoiceTotaler
    {
        double CalculateFor(Invoice invoice);
    }

    public class InvoiceTotaler : IInvoiceTotaler
    {
        public double CalculateFor(Invoice invoice)
        {
            return invoice.Items.Sum(x => x.Count*x.Price);
        }
    }
}