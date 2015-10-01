namespace Kata.SOLID
{
    public class SelfPropelledChopperRentalCostingCalculator
    {
        public double For(Chopper chopper, double finishTime)
        {
            return (chopper.Ownership*chopper.Acres) +
                   (chopper.FuelPrice*chopper.FuelConsumptionRate*chopper.Power*finishTime) +
                   (chopper.OperatorWage*finishTime) + (chopper.Ownership*chopper.Acres*chopper.Lube/100);
        }
    }
}