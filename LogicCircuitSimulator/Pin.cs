using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCircuitSimulator
{
    class Pin
    {
        public Pin()
        {
            State = new Logic(LogicValue.UNINITIALIZED);
        }

        public Logic State { get; set; }
    }
}
