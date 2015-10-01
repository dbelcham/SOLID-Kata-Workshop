using System.Collections.Generic;

namespace Kata.SOLID
{
    public interface IHaveBrakes
    {
        Light BrakeLight { get; set; }
        IEnumerable<Brake> Brakes { get; }
        void ReplaceBrake(int i, Brake brake);
    }
}