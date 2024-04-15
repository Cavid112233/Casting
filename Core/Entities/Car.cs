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

        public override void ShowInfo()
        {
            Console.WriteLine($"Sernisin sayi: {PassengerCapacity}");
        }
    }
}
