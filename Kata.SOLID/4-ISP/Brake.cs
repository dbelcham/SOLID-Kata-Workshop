namespace Kata.SOLID
{
    public class Brake
    {
        public Brake()
        {
            Level = 100;
        }

        public int Level { get; private set; }
    }
}