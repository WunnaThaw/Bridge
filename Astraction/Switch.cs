using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Switch
    {
        protected IAppliance _appliance;
        public abstract void TurnOn();
    }
}
