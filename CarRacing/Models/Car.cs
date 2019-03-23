using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing.Models
{
    class Car
    {
        public int Number { get; }

        public TimeSpan RaceTime { get; private set; }

        Random random;

        public string RaceTimeText
        {
            get
            {
                return string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}", RaceTime.Hours, RaceTime.Minutes, RaceTime.Seconds, RaceTime.Milliseconds);
            }
        }

        public Car(int number)
        {
            Number = number;
            random = new Random(Guid.NewGuid().GetHashCode());
        }

        public void Start(int distance)
        {            
            var speed = random.Next(40, 81);
            RaceTime = TimeSpan.FromHours(GetRaceTime(distance, speed));            
        }

        double GetRaceTime(int distance, int speed)
        {
            return (double)distance / speed;
        }
    }
}
