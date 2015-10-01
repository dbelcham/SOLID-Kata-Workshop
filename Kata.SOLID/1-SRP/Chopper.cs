namespace Kata.SOLID
{
    public class Chopper
    {
        public double Width { get; set; }
        public double FuelConsumptionRate { get; set; }
        public double Power{get; set; }
        public double Acres { get; set; }
        public UoM Unit { get; set; }
        public double FuelPrice { get; set; }
        public double OperatorWage { get; set; }
        public double Lube { get; set; }
        public double Efficiency { get; set; }
        public double Speed { get; set; }
        public double YearlyUse { get; set; }
        public double Ownership { get; set; }
        public EquipmentType ChopTractorType { get; set; }
        public OwnershipType ChopType { get; set; }
        
        /// <summary>
        /// Calculate the time it will take to complete the work
        /// </summary>
        /// <param name="truckTime">The amount of time trucking will take</param>
        /// <returns></returns>
        public double FinishTime(double truckTime)
        {
            var equipmentWorkDurationCalculator = new EquipmentWorkDurationCalculator();
            return equipmentWorkDurationCalculator.FinishTime(this, truckTime);
        }

        /// <summary>
        /// Calculate the total cost for doing the work
        /// </summary>
        /// <param name="truckTime">Total time for trucking</param>
        /// <returns></returns>
        public double Cost(double truckTime)
        {
            var finishTime = FinishTime(truckTime);

            var equipmentCostingCalculator = new ChopperTypeCostingCalculator();
            return equipmentCostingCalculator.CalculateFor(truckTime, finishTime, this);
        }
    }
}