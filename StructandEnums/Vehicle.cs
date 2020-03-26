using System;

namespace StructandEnums
{
    class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels 
        { 
            get;    set;
        }
        public double Speed 
        {  
            get; set;
        }
        public Vehicle(string brand = "No brand", int wheels = 0, double speed= 0)
        {
            Brand = brand;
            Speed = speed;
            Wheels = wheels;
            
        }

        public void Move()
        {
            System.Console.WriteLine($"the {Brand} moves forward at {Speed } mph");
        }

        public void Stop()
        {
            System.Console.WriteLine($"the {Brand} stops");
            Speed = 0;
        }
    }
}