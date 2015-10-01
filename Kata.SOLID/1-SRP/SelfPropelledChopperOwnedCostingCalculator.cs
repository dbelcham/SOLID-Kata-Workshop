namespace Kata.SOLID
{
    public class SelfPropelledChopperOwnedCostingCalculator
    {
        public double For(Chopper chopper, double finishTime)
        {
            if (chopper.YearlyUse > 0)
            {
                return (chopper.Ownership * finishTime / chopper.YearlyUse) +
                       (chopper.Ownership * chopper.Lube / 100 * finishTime / chopper.YearlyUse) +
                       (chopper.FuelPrice * chopper.FuelConsumptionRate * chopper.Power * finishTime) +
                       (chopper.OperatorWage * finishTime);
            }
            return 0;
        }
    }
}