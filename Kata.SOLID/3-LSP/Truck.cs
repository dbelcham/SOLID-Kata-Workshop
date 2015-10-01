namespace Kata.SOLID
{
    public class Truck : IWithEngine, IAmOwned
    {
        public double RunningCost()
        {
            return 3.5;
        }

        public double OwnershipCost()
        {
            return 25000;
        }
    }
}