// Singleton class Logger, to log the info to the console.
using System;
using System.Threading;

namespace Fish
{
    public class Logger
    {
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
    }
}