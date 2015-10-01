namespace Kata.SOLID
{
    public class Combine : IWithEngine, IAmOwned
    {
        public double RunningCost()
        {
            return 88.25;
        }

        public double OwnershipCost()
        {
            return 100000;
        }
    }
}