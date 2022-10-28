using System;
using System.Collections.Generic;

namespace Fish
{
    public class Aquarium
    {
        private readonly int _id;
        public List<Fish> Fish { get; set; }

        public Aquarium(int id)
        {
            _id = id;
        }

        public void Fill(int quantity)
        {
            Fish father = new Fish(1, "Father", 255, true);
            Fish mother = new Fish(2, "Mother", 255, false);

            Random random = new Random();
            List<Fish> fish = new List<Fish>();

            for (int i = 1; i < quantity + 1; ++i)
            {
                int lifetime = random.Next(1, 100);
                Fish newFish = new Fish(i, "Hoshim", lifetime, Convert.ToBoolean(random.Next(0, 2)), mother, father);
                fish.Add(newFish);
            }

            Fish = fish;
        }
    }
}