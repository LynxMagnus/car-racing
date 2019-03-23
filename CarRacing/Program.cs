using CarRacing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            for (int i = 1; i <= 6; i++)
            {
                cars.Add(new Car(i));
            }

            Season season = new Season(10, cars);
            season.Start();
            Console.ReadLine();
        }
    }
}
