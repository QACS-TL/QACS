using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    internal class Thing
    {
        public string Name { get; set; }
        public IEnumerable<Person> Persons { get; set; }
    }
}
