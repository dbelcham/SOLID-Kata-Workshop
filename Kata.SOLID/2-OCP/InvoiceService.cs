namespace Kata.SOLID
{
    public class InvoiceService
    {
        public double CalculateTotal()
        {
            var invoice = new Invoice(new Customer("Jim's Autobody", "AB", "Canada"));
            invoice.AddItem(new Item("Wheel", 4, 395.66));
            invoice.AddItem(new Item("Brake", 2, 144.38));
            invoice.AddItem(new Item("Light", 2, 6.99));

            var invoiceTotaler = new InvoiceTotaler();
            return invoiceTotaler.CalculateFor(invoice);
        }
    }
}