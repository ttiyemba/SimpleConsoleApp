using System;

namespace StructandEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vh1 = new Vehicle("bmw",4,120);

            if(vh1 is IDrivable)
            {
                vh1.Move();
                vh1.Stop();

            }

            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powButton = new PowerButton(TV);

            powButton.Execute();
            powButton.Undo();
            

            
        }
    }

   
   

   
}
