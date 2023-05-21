using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TV : IAppliance
    {
        private string _name;
        public TV(string name)
        {
            _name = name;
        }

        void IAppliance.TurnOn()
        {
            Console.WriteLine("{0} Power is ON.", _name);
        }
    }
}
