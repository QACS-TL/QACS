namespace ZooTzarLibrary
{
    public class Animal
    {
        public string name;
        public int age;
        public int limbCount;
        private int health;

        public string Eat(string food)
        {
            return $"I'm an animal called {this.name} using some of my {this.limbCount} limbs to eat {food}.";
        }

        public string Move(string direction, int distance)
        {
            return $"I'm an animal called {this.name} using some of my {this.limbCount} limbs to move {direction} for {distance} metres.";
        }

        public string Move(string direction)
        {
            return $"I'm an animal called {this.name} using some of my {this.limbCount} limbs to move {direction}.";
        }

        public string Move(int distance)
        {
            return $"I'm an animal called {this.name} using some of my {this.limbCount} limbs to move {distance} metres.";
        }
    }
}
