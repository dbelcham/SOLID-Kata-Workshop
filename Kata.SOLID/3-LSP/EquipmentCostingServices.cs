using System.Collections.Generic;
using System.Linq;

namespace Kata.SOLID
{
    public class EquipmentCostingServices
    {
        private readonly List<IEquipment> equipment;

        public EquipmentCostingServices()
        {
            this.equipment = new List<IEquipment>
            {
                new Tractor(),
                new Combine(),
                new Truck(),
                new Wagon()
            };
        }

        public double GetTotalOperatingCost()
        {
            return new CostingCalculator().OperatingCostFor(equipment.OfType<IWithEngine>());
        }

        public double GetTotalOwnershipCost()
        {
            return new CostingCalculator().OwnershipCostFor(equipment.OfType<IAmOwned>());
        }
    }
}