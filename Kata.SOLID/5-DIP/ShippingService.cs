using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Kata.SOLID
{
    public class ShippingService
    {
        public void ShipProducts(IEnumerable<Product> products)
        {
            ProductVolumeCalculator volumeCalculator = new ProductVolumeCalculator();

            var volume = volumeCalculator.For(products);

            BoxSelector boxSelector = new BoxSelector();

            var box = boxSelector.For(volume);

            box.LoadWith(products);

            ShippingCompany shipper = new ShippingCompany();
            shipper.Send(box);
        }
    }
}