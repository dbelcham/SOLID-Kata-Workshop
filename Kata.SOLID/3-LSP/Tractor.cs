namespace Kata.SOLID
{
    public class Tractor : Equipment
    {
        public override double RunningCost()
        {
            return 33.5;
        }

        public override double OwnershipCost()
        {
            return 4000;
        }
    }
}