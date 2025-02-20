using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTzarLibrary
{
    public interface IAnimal: IComparable<IAnimal>
    {
        string Name { get; set; }
        int Age { get; set; }
        int LimbCount { get; set; }

        string Eat(string food);
        string Move(string direction);
        string Move(int distance);

    }
}
