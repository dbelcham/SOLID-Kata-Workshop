namespace Kata.SOLID
{
    public class SelfPropelledChopperCustomCostingCalculator
    {
        public double For(Chopper chopper)
        {
            return (chopper.Ownership * chopper.Acres);
        }
    }
}