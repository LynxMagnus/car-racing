using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing.Models
{
    class Race
    {
        public Season Season { get; }

        public int Number { get; }

        public int Distance { get; }

        public List<Car> Cars { get; }

        public Race(Season season, int number, int distance, List<Car> cars)
        {
            Number = number;
            Season = season;
            Distance = distance;
            Cars = cars;
        }

        public void Start()
        {
            Console.WriteLine("Race {0} Starting - Distance {1} miles", Number, Distance);
            Cars.ForEach(x => x.Start(Distance));

            int i = 1;
            foreach (var car in Cars.OrderBy(x => x.RaceTime))
            {
                switch (i)
                {
                    case 1:
                        Season.LeaderBoard.Update(car, 5);
                        Console.WriteLine(string.Format("Position {0} Car {1} Time: {2} Points: {3}", i, car.Number, car.RaceTimeText, 5));
                        break;
                    case 2:
                        Season.LeaderBoard.Update(car, 3);
                        Console.WriteLine(string.Format("Position {0} Car {1} Time: {2} Points: {3}", i, car.Number, car.RaceTimeText, 3));
                        break;
                    case 3:
                        Season.LeaderBoard.Update(car, 1);
                        Console.WriteLine(string.Format("Position {0} Car {1} Time: {2} Points: {3}", i, car.Number, car.RaceTimeText, 1));
                        break;
                    default:
                        Console.WriteLine(string.Format("Position {0} Car {1} Time: {2} Points: {3}", i, car.Number, car.RaceTimeText, 0));
                        break;
                }

                i++;
            }
        }
    }
}
