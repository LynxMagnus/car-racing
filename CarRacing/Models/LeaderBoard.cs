using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing.Models
{
    class LeaderBoard
    {
        public List<Rank> Ranks { get; private set; }

        public Rank Leader
        {
            get
            {
                return Ranks.OrderByDescending(x => x.Points).FirstOrDefault();
            }
        }

        public LeaderBoard(List<Car> cars)
        {
            Ranks = new List<Rank>();
            cars.ForEach(x => Ranks.Add(new Rank(x)));
        }

        void Order()
        {
            Ranks = Ranks.OrderByDescending(x => x.Points).ToList();
        }

        public void Update(Car car, int points)
        {
            Ranks.Where(x => x.Car == car).First().AddPoints(points);
            Order();
        }
    }

    class Rank
    {
        public Car Car { get; }

        public int Points { get; private set; }

        public Rank(Car car)
        {
            Car = car;
        }

        public void AddPoints(int points)
        {
            Points += points;
        }
    }
}
