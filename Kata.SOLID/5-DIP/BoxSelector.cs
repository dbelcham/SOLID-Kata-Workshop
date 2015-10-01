namespace Kata.SOLID
{
    public class BoxSelector : IBoxSelector
    {
        public Box For(double volume)
        {
            //pick a box that works for this volume
            return new Box();
        }
    }
}