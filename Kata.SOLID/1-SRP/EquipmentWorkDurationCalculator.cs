namespace Kata.SOLID
{
    public class EquipmentWorkDurationCalculator
    {
        /// <summary>
        /// Calculate the time it will take to complete the work
        /// </summary>
        /// <param name="truckTime">The amount of time trucking will take</param>
        /// <returns></returns>
        public double FinishTime(Chopper chopper, double truckTime)
        {
            double finishTime = 0;
            if (chopper.Speed > 0 && chopper.Width > 0 && chopper.Efficiency > 0)
            {
                if (chopper.Unit == UoM.Imperial)
                {
                    finishTime = chopper.Acres / (chopper.Speed * chopper.Width / 8.25 * chopper.Efficiency / 100);
                }
                else
                {
                    finishTime = chopper.Acres / (chopper.Speed * chopper.Width / 10 * chopper.Efficiency / 100);
                }
            }
            if (finishTime < truckTime)
            {
                finishTime = truckTime;
            }

            return finishTime;
        }

    }
}