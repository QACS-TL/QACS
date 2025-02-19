using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTzarLibrary
{
    public class Raccoon: Animal
    {
        public override string Eat(string food)
        {
            return $"I'm a hungry Raccoon chomping on {food}";
        }

        public string Scavenge(string lookedForThing)
        {
            return $"I'm a {this.GetType().Name} scavenging for {lookedForThing}.";
        }
    }
}
