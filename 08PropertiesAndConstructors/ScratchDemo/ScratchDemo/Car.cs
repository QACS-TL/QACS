using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchDemo
{
    public class Car
    {
        private Car() { }
        private int speed = 30;

        //public int GetSpeed()
        //{
        //    return speed;
        //}

        //public void SetSpeed(int value)
        //{
        //    if (value > 200){
        //        value = 200;
        //    }
        //    speed = value;
        //}

        public int Speed
        {
            get { return speed; }
            set {
                if (value > 200)
                {
                    value = 200;
                }
                speed = value;
            }
        }

        //public int SpeedInKPH { get { return speed * 8 / 5; }  }

        private string colour;

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public int CurrentGear { get; set; }

        public  static Car CarCreator() {
            Car c = new Car();
            return c;
        }

    }
}
