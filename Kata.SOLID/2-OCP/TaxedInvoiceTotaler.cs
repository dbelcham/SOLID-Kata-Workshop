namespace Kata.SOLID
{
    public class TaxedInvoiceTotaler : IInvoiceTotaler
    {
        public double CalculateFor(Invoice invoice)
        {
            var invoiceTotaler = new InvoiceTotaler();
            var total = invoiceTotaler.CalculateFor(invoice);
            total = total * 1.05;
            return total;
        }
    }
}