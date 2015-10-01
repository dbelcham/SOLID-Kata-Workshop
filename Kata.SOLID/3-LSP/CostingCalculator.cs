using System.Collections.Generic;
using System.Linq;

namespace Kata.SOLID
{
    public class CostingCalculator
    {
        public double OperatingCostFor(IEnumerable<IWithEngine> equipment)
        {
            return equipment.Sum(x =>x.RunningCost());
        }

        public double OwnershipCostFor(IEnumerable<IAmOwned> equipment)
        {
            return equipment.Sum(x => x.OwnershipCost());
        }
    }
}