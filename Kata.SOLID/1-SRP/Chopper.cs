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
            double finishTime = 0;
            if (Speed > 0 && Width > 0 && Efficiency > 0)
            {
                if (Unit == UoM.Imperial)
                {
                    finishTime = Acres/(Speed*Width/8.25*Efficiency/100);
                }
                else
                {
                    finishTime = Acres/(Speed*Width/10*Efficiency/100);
                }
            }
            if (finishTime < truckTime)
            {
                finishTime = truckTime;
            }

            return finishTime;
        }

        /// <summary>
        /// Calculate the total cost for doing the work
        /// </summary>
        /// <param name="truckTime">Total time for trucking</param>
        /// <returns></returns>
        public double Cost(double truckTime)
        {
            var finishTime = FinishTime(truckTime);

            if (ChopTractorType == EquipmentType.SelfPropelled)
            {
                switch (ChopType)
                {
                    case OwnershipType.Rent:
                        return (Ownership*Acres) + (FuelPrice*FuelConsumptionRate*Power*finishTime) + (OperatorWage*finishTime) + (Ownership*Acres*Lube/100);
                    case OwnershipType.Custom:
                        return (Ownership*Acres);
                    default:
                        if (YearlyUse > 0)
                        {
                            return (Ownership*finishTime/YearlyUse) + (Ownership*Lube/100*finishTime/YearlyUse) +
                                   (FuelPrice*FuelConsumptionRate*Power*finishTime) + (OperatorWage*finishTime);
                        }
                        return 0;
                }
            }
            if (ChopTractorType == EquipmentType.PullType)
            {
                switch (ChopType)
                {
                    case OwnershipType.Rent:
                        return (Ownership*Acres) + (FuelPrice*FuelConsumptionRate*Power*finishTime) + (OperatorWage*finishTime) +
                               (Ownership*Acres*Lube/100);

                    case OwnershipType.Custom:
                        return (Ownership*Acres);
                    default:
                        if (YearlyUse > 0)
                        {
                            return (Ownership*finishTime/YearlyUse)*(Ownership*Lube/100*finishTime/YearlyUse);
                        }
                        return 0;
                }
            }
            return 0;
        }
    }
}