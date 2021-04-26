using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsHomework.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Object Driver { get; set; }

        public Car(string model, int speed, Object driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

    }
}
