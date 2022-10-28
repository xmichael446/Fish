using System;
using System.Collections.Generic;

namespace Fish
{
    public static class Program
    {
        public static void Main()
        {
            Aquarium aquarium = new Aquarium(1);
            aquarium.Fill(70);

            int lastId = 71;
            int iteration = 0;

            Logger logger = Logger.GetInstance();
            List<int> collisions = new List<int>();

            while (aquarium.Fish.Count >= 2)
            {
                List<Fish> fish = aquarium.Fish;

                Random rand = new Random();

                for (int i = 0; i < 6; ++i)
                {
                    collisions.Add(rand.Next(1, 6) + iteration);
                }

                collisions.Sort((a, b) => b.CompareTo(a));
                for (int i = collisions.Count - 1; i > 0; --i)
                {
                    if (collisions[i] > iteration)
                    {
                        break;
                    }

                    if (collisions[i] != iteration) continue;

                    collisions.RemoveAt(i);

                    Fish fish1 = fish[rand.Next(1, fish.Count)];
                    Fish fish2 = fish[rand.Next(1, fish.Count)];

                    logger.LogCollision(fish1, fish2);

                    if (!fish1.CanMarry(fish2)) continue;

                    int lifetime = rand.Next(1, 100);
                    bool gender = Convert.ToBoolean(rand.Next(0, 2));
                    Fish mother = (fish1.IsFemale()) ? fish1 : fish2;
                    Fish father = (fish1.IsMale()) ? fish1 : fish2;

                    Fish newFish = new Fish(lastId, "Hoshim", lifetime, gender, mother, father);
                    lastId++;

                    logger.LogBirth(newFish);
                }

                for (int i = 0; i < fish.Count; ++i)
                {
                    fish[i].IncrementAge();

                    if (fish[i].ShouldBeDead())
                    {
                        logger.LogDeath(fish[i]);
                    }
                }

                iteration++;
            }

            logger.LogDoomsDay();
        }
    }
}