using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTzarLibrary
{
    public class Elelphant:Animal
    {
        public Elelphant(string name, int age, int limbCount, int trunkLength):base(name, age)
        {
            this.LimbCount = limbCount;
            this.TrunkLength = trunkLength;
        }

        public int TrunkLength { get; set; }

        public string Trumpet(int duration)
        {
            return $"I'm an Elephant called {this.Name} trumpeting for {duration} seconds.";
        }

        public override string Eat(string food)
        {
            return base.Eat(food) +  $" Actually, I'm an Elelphant using my {this.TrunkLength}cm long trunk to eat {food}.";
        }
    }
}
