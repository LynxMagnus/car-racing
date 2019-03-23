using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing.Models
{
    class Season
    {
        public List<Car> Cars { get; }

        public LeaderBoard LeaderBoard { get; }

        public int Races { get; }

        Random random;

        public Season(int races, List<Car> cars)
        {
            Races = races;
            Cars = cars;
            LeaderBoard = new LeaderBoard(cars);
            random = new Random(Guid.NewGuid().GetHashCode());
        }

        public void Start()
        {
            for (int i = 1; i <= Races; i++)
            {
                Race race = new Race(this, i, random.Next(5, 101), Cars);
                race.Start();

                Console.WriteLine();
                Console.WriteLine("Leader Board");

                for (int y = 0; y < LeaderBoard.Ranks.Count; y++)
                {
                    Console.WriteLine("{0} - Car {1} Points: {2}", y + 1, LeaderBoard.Ranks[y].Car.Number, LeaderBoard.Ranks[y].Points);
                }

                Console.WriteLine();
                Console.WriteLine("Winner: Car {0}", LeaderBoard.Leader.Car.Number);
            }
        }
    }
}
