using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create implementation objects
            IAppliance tv = new TV("Bedroom TV");
            IAppliance vaccum = new VaccumCleaner("Cleaner");

            // Convert to abstraction objects
            Switch tvSwitch = new RemoteControl(tv);
            Switch vaccumSwitch = new RemoteControl(vaccum);

            // client code works only with the abstraction objects, not the implementation objects
            tvSwitch.TurnOn();
            vaccumSwitch.TurnOn();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
