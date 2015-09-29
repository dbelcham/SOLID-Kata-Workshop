namespace Kata.SOLID
{
    public class Combine : Equipment
    {
        public override double RunningCost()
        {
            return 88.25;
        }

        public override double OwnershipCost()
        {
            return 100000;
        }
    }
}