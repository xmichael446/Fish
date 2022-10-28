using System;
using System.Threading;

namespace Fish
{
    public class Logger
    {
        private Logger? _instance = null;

        public Logger GetInstance() {
            if (_instance == null) _instance = new Logger();

            return _instance;
        }

        public void LogCollision(Fish fish1, Fish fish2)
        {
            Console.WriteLine("!!! Collision !!!");
            Console.WriteLine(fish1);
            Console.WriteLine(fish2);

            Thread.Sleep(1000);
        }

        public void LogBirth(Fish fish)
        {
            Console.WriteLine("!!! Birth !!!");
            Console.WriteLine(fish);

            Thread.Sleep(1000);
        }

        public void LogDeath(Fish fish)
        {
            Console.WriteLine("!!! Death !!!");
            Console.WriteLine(fish);

            Thread.Sleep(1000);
        }

        public void LogDoomsDay() {
            Console.WriteLine("!!! No Fish to reproduce, the aquarium's fucked !!!");

        }
    }
}