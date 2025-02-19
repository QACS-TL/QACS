using System.Net.WebSockets;

namespace ZooTzarLibrary
{
    public abstract class Animal
    {

        public Animal() : this("Anon")
        {

        }

        public Animal(string name) : this(name, 33)
        {

        }
        public static int AnimalCount { get; private set; }

        public Animal(string name="Anon", int age= 33)
        {
            this.Name = name;
            this.Age = age;
            this.LimbCount = 4;
            AnimalCount++;
        }

        //public string name;
        public string Name { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int limbCount;
        //public int GetLimbCount() { 
        //    return limbCount; 
        //}
        //public void SetLimbCount(int value)
        //{
        //    if (value < 0 || value > 100)
        //    {
        //        value = 0;
        //    }
        //    this.limbCount = value;
        //}
        public int LimbCount
        {
            get { return limbCount; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                this.limbCount = value;
            }
        }


        private int health;

        public abstract string Eat(string food);


        public string Move(string direction="North", int distance=10)
        {
            return $"I'm an {this.GetType().Name} called {this.Name} using some of my {this.LimbCount} limbs to move {direction} for {distance} metres.";
        }

        //public string Move(string direction)
        //{
        //    return $"I'm an animal called {this.Name} using some of my {this.LimbCount} limbs to move {direction}.";
        //}

        //public string Move(int distance)
        //{
        //    return $"I'm an animal called {this.Name} using some of my {this.LimbCount} limbs to move {distance} metres.";
        //}

        public override string ToString()
        {
            return $"I'm an {this.GetType().Name} called {this.Name}. I am {this.Age} years old and I have {this.LimbCount} limbs.";
        }
    }
}
