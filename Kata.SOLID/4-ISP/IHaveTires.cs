using System.Collections.Generic;

namespace Kata.SOLID
{
    public interface IHaveTires
    {
        IEnumerable<Wheel> Wheels { get; set; }
        void RotateTires();
    }
}