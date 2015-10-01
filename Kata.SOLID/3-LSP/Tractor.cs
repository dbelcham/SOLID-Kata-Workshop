namespace Kata.SOLID
{
    public interface IWithEngine:IEquipment
    {
        double RunningCost();
    }

    public interface IEquipment
    {
    }

    public interface IAmOwned:IEquipment
    {
        double OwnershipCost();
    }

    public class Tractor : IWithEngine, IAmOwned
    {
        public double RunningCost()
        {
            return 33.5;
        }

        public double OwnershipCost()
        {
            return 4000;
        }
    }
}