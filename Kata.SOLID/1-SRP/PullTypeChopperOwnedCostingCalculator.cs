namespace Kata.SOLID
{
    public class PullTypeChopperOwnedCostingCalculator
    {
        public double For(Chopper chopper, double finishTime)
        {
            if (chopper.YearlyUse > 0)
            {
                return (chopper.Ownership * finishTime / chopper.YearlyUse) * (chopper.Ownership * chopper.Lube / 100 * finishTime / chopper.YearlyUse);
            }
            return 0;
        }
    }
}