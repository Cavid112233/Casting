using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand-{Brand}:Model-{Model}: Year-{Year}");
        }
    }
}
