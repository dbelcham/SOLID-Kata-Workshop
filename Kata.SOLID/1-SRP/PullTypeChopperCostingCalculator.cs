namespace Kata.SOLID
{
    public class PullTypeChopperCostingCalculator
    {
        public double For(Chopper chopper, double finishTime)
        {
            switch (chopper.ChopType)
            {
                case OwnershipType.Rent:
                    var rentalCalculator = new PullTypeChopperRentalCostingCalculator();
                    return rentalCalculator.For(chopper, finishTime);

                case OwnershipType.Custom:
                    var customCalculator = new PullTypeChopperCustomCostingCalculator();
                    return customCalculator.For(chopper);
                default:
                    var ownedCalculator = new PullTypeChopperOwnedCostingCalculator();
                    return ownedCalculator.For(chopper, finishTime);                    
            }
        }
    }
}