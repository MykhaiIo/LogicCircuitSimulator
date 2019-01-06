using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCircuitSimulator
{
    enum PinSide : byte { INPUT, OUTPUT };

    class Pin
    {
        public Pin(PinSide side)
        {
            State = new Logic(LogicValue.UNINITIALIZED);
            connected_pin = null;
        }

        private Pin connected_pin;
        public Pin ConnectedPin
        {
            get { return connected_pin; }
            set
            {
                if (value.Side == this.Side)
                    throw new ConnectToIdenticalSideException();
                else
                    connected_pin = value;
            }
        }
        public PinSide Side { get; private set; }
        public Logic State { get; set; }
    }
}
