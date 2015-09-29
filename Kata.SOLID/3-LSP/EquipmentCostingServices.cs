using System.Collections.Generic;
using System.Linq;

namespace Kata.SOLID
{
    public class EquipmentCostingServices
    {
        private readonly List<Equipment> equipment;

        public EquipmentCostingServices()
        {
            this.equipment = new List<Equipment>
            {
                new Tractor(),
                new Combine(),
                new Truck(),
                //new Wagon()
            };
        }

        public double GetTotalOperatingCost()
        {
            return new CostingCalculator().OperatingCostFor(equipment);
        }

        public double GetTotalOwnershipCost()
        {
            return new CostingCalculator().OwnershipCostFor(equipment);
        }
    }
}