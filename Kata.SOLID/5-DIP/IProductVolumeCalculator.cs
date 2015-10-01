using System.Collections.Generic;

namespace Kata.SOLID
{
    public interface IProductVolumeCalculator
    {
        double For(IEnumerable<Product> products);
    }
}