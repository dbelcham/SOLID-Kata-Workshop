namespace Kata.SOLID
{
    public interface IHaveRadiator
    {
        Radiator Radiator { get; set; }
        void AddRadiatorFluid(int i);
    }
}