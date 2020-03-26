using System;

namespace StructandEnums
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            System.Console.WriteLine("The tv is off");
            
        }

        public void On()
        {
            System.Console.WriteLine("The tv is on");
        }

        public void VolumeDown()
        {
            if(Volume!=0){
                Volume --;
                System.Console.WriteLine($"the tv volume is at {Volume}");
            }
        }

        public void VolumeUp()
        {
            if(Volume!=50){
                Volume ++;
                System.Console.WriteLine($"the volume is at {Volume}");
            }
        }
    }
}