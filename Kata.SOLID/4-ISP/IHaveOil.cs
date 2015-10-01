namespace Kata.SOLID
{
    public interface IHaveOil
    {
        int OilLevel { get; }
        void DrainOil();
        void AddOil(int i);
    }
}