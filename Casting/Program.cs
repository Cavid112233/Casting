using Core.Entities;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Marka = "BMW";
            car.Model = "F3";
            car.Year = 2014;
            car.PassengerCapacity = 3;

            Car car1 = new Car();
            car1.Marka = "BMW";
            car1.Model = "M5";
            car1.Year = 2020;
            car1.PassengerCapacity = 4;

            Car car2 = new Car();
            car2.Marka = "Mercedes-Benz";
            car2.Model = "E-class";
            car2.Year = 2001;
            car2.PassengerCapacity = 4;

            Truck truck = new Truck();
            truck.Marka = "Volvo";
            truck.Model = "s90";
            truck.Year = 2021;
            truck.CarryingCapacity = 80;

            RentCar rentCar = new RentCar();
            rentCar.CarLimit = 3;
            rentCar.TruckLimit = 2;

            rentCar.AddVehicle(car);
            rentCar.AddVehicle(car1);
            rentCar.AddVehicle(car2);

            rentCar.AddVehicle(truck);

            Console.WriteLine(" ");

            rentCar.ShowAllVehicle();
        }
    }
}
