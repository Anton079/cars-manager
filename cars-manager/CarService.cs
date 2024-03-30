using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_manager
{
    public class CarService
    {
        private List<Car> _Cars;

        public CarService()
        {
            _Cars = new List<Car>();
            this.LoadData();
        }

        public void LoadData()
        {
            Car car1 = new Car(1, "Xiaomi", 150, 200, 422,true); ;
            Car car2 = new Car(2, "Dacia", 5230, 360, 522,false);
            Car car3 = new Car(3, "saab", 876, 250, 534,true);
            Car car4 = new Car(4, "Lacia", 354, 564, 756,false);
            Car car5 = new Car(5, "Aro", 165, 876, 710,true);

            this._Cars.Add(car1);
            this._Cars.Add(car2);
            this._Cars.Add(car3);
            this._Cars.Add(car4);
            this._Cars.Add(car5);
        }

        public void AfisareCars()
        {
            foreach (Car x in _Cars)
            {
                Console.WriteLine(x.CarInfo());
            }
        }
    }
}
