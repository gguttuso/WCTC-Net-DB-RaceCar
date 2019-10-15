using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class MazdaThree : RaceCar
    {
        public MazdaThree()
        {
            Name = "Mazda Three";
            TopSpeed = 120;
        }


        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is coming to a hault!");
            base.Brake();
        }
    }
}
