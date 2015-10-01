namespace Kata.SOLID
{
    public class ChopperTypeCostingCalculator
    {
        public double CalculateFor(double truckTime, double finishTime, Chopper chopper)
        {
            if (chopper.ChopTractorType == EquipmentType.SelfPropelled)
            {
                var calculator = new SelfPropelledChopperCostingCalculator();
                return calculator.For(chopper, finishTime);
            }
            if (chopper.ChopTractorType == EquipmentType.PullType)
            {
                var calculator = new PullTypeChopperCostingCalculator();
                return calculator.For(chopper, finishTime);
            }
            return 0;
        }
    }
}