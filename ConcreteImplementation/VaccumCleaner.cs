using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class VaccumCleaner : IAppliance
    {
        private string _name;
        public VaccumCleaner(string name)
        {
            _name = name;
        }

        void IAppliance.TurnOn()
        {
            Console.WriteLine("{0} is ready to use.", _name);
        }
    }
}
