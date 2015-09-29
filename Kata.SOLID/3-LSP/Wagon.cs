namespace Kata.SOLID
{
    public class Wagon : Equipment
    {
        public override double RunningCost()
        {
            throw new System.NotImplementedException();
        }

        public override double OwnershipCost()
        {
            return 15000;
        }
    }
}