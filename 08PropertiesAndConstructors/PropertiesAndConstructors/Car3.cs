using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors2AndAHalf
{
    public class Car
    {

        public Car(string make="Ford", string model="Fiesta")
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }
    }
}
