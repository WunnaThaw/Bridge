using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl : Switch
    {
        public RemoteControl(IAppliance appliance)
        {
            _appliance = appliance;
        }

        public override void TurnOn()
        {
            _appliance.TurnOn();
        }
    }
}
