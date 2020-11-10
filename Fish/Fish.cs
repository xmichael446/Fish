namespace Fish
{
    public class Fish
    {
        // Fields
        public int Id { get; set; }

        public int Lifetime { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public Fish Mother { get; set; }
        public Fish Father { get; set; }


        // Initializer
        public Fish(int id, string name, int lifetime, bool gender, Fish mother = null, Fish father = null)
        {
            Id = id;
            Name = name;
            Lifetime = lifetime;
            Gender = gender;

            Mother = mother;
            Father = father;
            Age = 0;
        }


        // Methods
        public bool CanGetMarriedWith(Fish fish)
        {
            return fish.Gender != Gender;
        }

        public bool IsMale()
        {
            return Gender;
        }
		
        public bool IsFemale()
        {
            return !Gender;
        }

        public bool ShouldBeDead()
        {
            return Age == Lifetime;
        }

        public override string ToString()
        {
            string gender = IsMale() ? "Male" : "Female";

            string str = $"Fish 1.\n" +
                         $"ID: {Id}\n" +
                         $"Name: {Name}.\n" +
                         $"Father: {Father.Name}.\n" +
                         $"Mother: {Mother.Name}.\n" +
                         $"Gender: {gender}\n" +
                         $"Age: {Age}\n\n";

            return str;
        }

        public void IncrementAge()
        {
            Age++;
        }
    }
}