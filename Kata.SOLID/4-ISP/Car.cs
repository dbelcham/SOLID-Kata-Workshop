using System.Collections.Generic;

namespace Kata.SOLID
{
    public class Car
    {
        private readonly IList<Brake> brakes;

        public Car()
        {
            brakes = new List<Brake> {new Brake(), new Brake(), new Brake(), new Brake()};
        }

        public IEnumerable<Cylinder> Cylinders { get; set; }
        public IEnumerable<Wheel> Wheels { get; set; }
        public Wiper DriversWiper { get; set; }
        public Wiper PassengerWiper { get; set; }
        public Wiper RearWiper { get; set; }
        public Light HeadLight { get; set; }
        public Light BrakeLight { get; set; }
        public Light RightTurnSignal { get; set; }
        public Light LeftTurnSignal { get; set; }
        public Light ReverseLight { get; set; }
        public Light FogLight { get; set; }
        public int OilLevel { get; private set; }
        public Radiator Radiator { get; set; }

        public IEnumerable<Brake> Brakes
        {
            get { return brakes; }
        }

        public void RotateTires()
        {
            //some tire rotation logic goes here
        }

        public void DrainOil()
        {
            OilLevel = 0;
        }

        public void AddOil(int i)
        {
            OilLevel += i;
        }

        public void ReplaceBrake(int i, Brake brake)
        {
            brakes[i] = brake;
        }

        public void AddRadiatorFluid(int i)
        {
            Radiator.Level += i;
        }
    }
}