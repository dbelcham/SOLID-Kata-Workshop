namespace Kata.SOLID
{
    public class SelfPropelledChopperCostingCalculator
    {
        public double For(Chopper chopper, double finishTime)
        {
            switch (chopper.ChopType)
            {
                case OwnershipType.Rent:
                    var rentalCalculator = new SelfPropelledChopperRentalCostingCalculator();
                    return rentalCalculator.For(chopper, finishTime);
                case OwnershipType.Custom:
                    var customCalculator = new SelfPropelledChopperCustomCostingCalculator();
                    return customCalculator.For(chopper);
                default:
                    var ownedCalculator = new SelfPropelledChopperOwnedCostingCalculator();
                    return ownedCalculator.For(chopper, finishTime);
            }
        }
    }
}