using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Car:Vehicle
    {
        public int PassengerCapacity { get; set; }
        public Car()
        {
        }
        public Car(string marka, string model, int year, int passengercapacity) : base(marka, model, year)
        {
            PassengerCapacity = passengercapacity;
        }


        public override string ShowInfo()
        {
            return $"Sernisin sayi: {PassengerCapacity}";
        }
    }
}
