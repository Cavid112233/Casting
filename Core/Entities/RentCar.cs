using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RentCar
    {
        public int CarLimit { get; set; }

        public int TruckLimit { get; set; }

        Vehicle[] _vehicles = new Vehicle[] { };

        Car[] _cars = new Car[] { };

        Truck[] _trucks = new Truck[] { };

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                if (_cars.Length < CarLimit)
                {
                    var car = vehicle as Car;

                    Array.Resize(ref _cars, _cars.Length + 1);
                    _cars[_cars.Length - 1] = car;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Masin limiti asilib!!!");
                }
            }
            else if (vehicle is Truck)
            {
                if (_trucks.Length < TruckLimit)
                {
                    var truck = vehicle as Truck;

                    Array.Resize(ref _trucks, _trucks.Length + 1);
                    _trucks[_trucks.Length - 1] = truck;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Yuk masininin limiti asilib!!!");
                }
            }

        }
        public void ShowAllVehicle()
        {
            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] is Car)
                {
                    var car = _vehicles[i] as Car;

                    Console.WriteLine(car.ShowInfo());

                }
                else if (_vehicles[i] is Truck)
                {

                    var truck = _vehicles[i] as Truck;

                    Console.WriteLine(truck.ShowInfo());

                }

            }

        }
    }
}
