using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Kata.SOLID
{
    public class ShippingService
    {
        private readonly IProductVolumeCalculator _productVolumeCalculator;
        private readonly IBoxSelector _boxSelector;

        public ShippingService(IProductVolumeCalculator productVolumeCalculator, IBoxSelector boxSelector)
        {
            _productVolumeCalculator = productVolumeCalculator;
            _boxSelector = boxSelector;
        }

        public void ShipProducts(IList<Product> products)
        {
            //example of Dependency Injections
            var volume = _productVolumeCalculator.For(products);

            //dependency Inversion
            IBoxSelector boxSelector = new BoxSelector();

            var box = boxSelector.For(volume);

            box.LoadWith(products);

            //dependency Inversion
            IShippingCompany shipper = new ShippingCompany();
            shipper.Send(box);
        }
    }
}