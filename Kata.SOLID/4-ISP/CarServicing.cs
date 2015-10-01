using System.Linq;

namespace Kata.SOLID
{
    public class CarServicing
    {
        public void AnnualMaintenanceFor(Car car)
        {
            RotateTires(car);
            ChangeOil(car);
            CheckBrakes(car);
            CheckRadiator(car);
        }

        private void CheckRadiator(IHaveRadiator car)
        {
            while (car.Radiator.Level < 85)
            {
                car.AddRadiatorFluid(1);
                
            }
        }

        private void CheckBrakes(IHaveBrakes car)
        {
            var brakes = car.Brakes.ToArray();

            for (var i = 0; i < brakes.Count(); i++)
            {
                if (brakes[i].Level < 30)
                {
                    car.ReplaceBrake(i, new Brake());
                }
            }
        }

        private void ChangeOil(IHaveOil car)
        {
            car.DrainOil();
            while (car.OilLevel != 100)
            {
                car.AddOil(1);
            }
        }

        private void RotateTires(IHaveTires car)
        {
            car.RotateTires();
        }
    }
}