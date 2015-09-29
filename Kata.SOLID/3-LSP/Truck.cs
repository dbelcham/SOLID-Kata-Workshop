namespace Kata.SOLID
{
    public class Truck : Equipment
    {
        public override double RunningCost()
        {
            return 3.5;
        }

        public override double OwnershipCost()
        {
            return 25000;
        }
    }
}