using System.Net.WebSockets;

namespace ZooTzarLibrary
{
    public class Animal
    {
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

        public string Eat(string food)
        {
            return $"I'm an animal called {this.Name} using some of my {this.LimbCount} limbs to eat {food}.";
        }

        public string Move(string direction, int distance)
        {
            return $"I'm an animal called {this.Name} using some of my {this.LimbCount} limbs to move {direction} for {distance} metres.";
        }

        public string Move(string direction)
        {
            return $"I'm an animal called {this.Name} using some of my {this.LimbCount} limbs to move {direction}.";
        }

        public string Move(int distance)
        {
            return $"I'm an animal called {this.Name} using some of my {this.LimbCount} limbs to move {distance} metres.";
        }
    }
}
