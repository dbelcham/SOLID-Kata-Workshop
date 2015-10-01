namespace Kata.SOLID
{
    public class PullTypeChopperCustomCostingCalculator
    {
        public double For(Chopper chopper)
        {
            return (chopper.Ownership * chopper.Acres);
        }
    }
}