using System;
using System.Collections.Generic;

namespace LogicCircuitSimulator
{
    abstract class Element
    {
        protected List<Pin> input_pins, output_pins;

        protected Element()
        {
            input_pins = new List<Pin>();
            output_pins = new List<Pin>();
        }

        public int Delay { get; set; }

        public abstract void Functionality();

        public List<Pin> GetPinsBySide(PinSide side)
        {
            switch (side)
            {
                case PinSide.INPUT:
                    return input_pins;
                case PinSide.OUTPUT:
                    return output_pins;
                default:
                    throw new InvalidPinSideException();
            }
        }

        public byte GetNumberOfPins(PinSide side)
        {
            return (byte)(GetPinsBySide(side).Count);
        }

        public Pin GetPin(PinSide side, byte pin_index)
        {
            if (GetNumberOfPins(side) <= pin_index)
                throw new PinIndexOutOfRangeException("Wrong pin index");
            return GetPinsBySide(side)[pin_index];
        }

        public bool HasConnectedPins()
        {
            foreach (Pin in_pin in input_pins)
            {
                if (in_pin.ConnectedPin != null)
                    return true;
            }
            foreach (Pin out_pin in output_pins)
            {
                if (out_pin.ConnectedPin != null)
                    return true;
            }
            return false;
        }
    }

    abstract class Terminal : Element
    {
        protected Terminal()
            : base()
        { }
    }

    class InTerminal : Terminal
    {
        public Logic SimulationInputValue { get; set; }

        public InTerminal()
            : base()
        {
            input_pins.Clear();
            output_pins.Add(new Pin(PinSide.OUTPUT));
            Delay = 0;
        }

        public override void Functionality()
        {
            output_pins[0].State = SimulationInputValue;
        }
    }

    class OutTerminal : Terminal
    {
        public Logic SimulationResult { get; private set; }

        public OutTerminal()
            : base()
        {
            input_pins.Add(new Pin(PinSide.INPUT));
            output_pins.Clear();
            Delay = 0;
            SimulationResult = new Logic(LogicValue.UNINITIALIZED);
        }

        public override void Functionality()
        {
            SimulationResult = input_pins[0].State;
        }
    }

    abstract class Gate : Element
    {
        protected Gate()
            : base()
        { }

        protected void Initialize1to1AsynchGate()
        {
            input_pins.Add(new Pin(PinSide.INPUT));
            output_pins.Add(new Pin(PinSide.OUTPUT));
            Delay = 0;
        }

        protected void Initialize2to1AsynchGate()
        {
            Initialize1to1AsynchGate();
            input_pins.Add(new Pin(PinSide.INPUT));
        }

        protected void Initialize1to2AsynchGate()
        {
            Initialize1to1AsynchGate();
            output_pins.Add(new Pin(PinSide.OUTPUT));
        }

        // TODO: Add methods for number of pins
    }

    class AND : Gate
    {
        public AND()
            : base()
        {
            Initialize2to1AsynchGate();
        }

        public override void Functionality()
        {
            Logic rv = new Logic(LogicValue.LOGIC_1);
            foreach( Pin ip in input_pins )
            {
                rv &= ip.State;
            }

            output_pins[0].State = rv;
        }
    }

    class NAND : Gate
    {
        public NAND()
            : base()
        {
            Initialize2to1AsynchGate();
        }

        public override void Functionality()
        {
            Logic rv = new Logic(LogicValue.LOGIC_1);
            foreach (Pin ip in input_pins)
            {
                rv &= ip.State;
            }

            output_pins[0].State = !rv;
        }
    }

    class OR : Gate
    {
        public OR()
            : base()
        {
            Initialize2to1AsynchGate();
        }

        public override void Functionality()
        {
            Logic rv = new Logic(LogicValue.LOGIC_0);
            foreach (Pin ip in input_pins)
            {
                rv |= ip.State;
            }

            output_pins[0].State = rv;
        }
    }

    class NOR : Gate
    {
        public NOR()
            : base()
        {
            Initialize2to1AsynchGate();
        }

        public override void Functionality()
        {
            Logic rv = new Logic(LogicValue.LOGIC_0);
            foreach (Pin ip in input_pins)
            {
                rv |= ip.State;
            }

            output_pins[0].State = !rv;
        }
    }

    class XOR : Gate
    {
        public XOR()
            : base()
        {
            Initialize2to1AsynchGate();
        }

        public override void Functionality()
        {
            Logic rv = new Logic(LogicValue.LOGIC_0);
            foreach (Pin ip in input_pins)
            {
                rv ^= ip.State;
            }

            output_pins[0].State = rv;
        }
    }

    class XNOR : Gate
    {
        public XNOR()
            : base()
        {
            Initialize2to1AsynchGate();
        }

        public override void Functionality()
        {
            Logic rv = new Logic(LogicValue.LOGIC_0);
            foreach (Pin ip in input_pins)
            {
                rv ^= ip.State;
            }

            output_pins[0].State = !rv;
        }
    }

    class NOT : Gate
    {
        public NOT()
            : base()
        {
            Initialize1to1AsynchGate();
        }

        public override void Functionality()
        {
            output_pins[0].State = !input_pins[0].State;
        }
    }

    class BUFF : Gate
    {
        public BUFF()
            : base()
        {
            Initialize1to2AsynchGate();
        }

        public override void Functionality()
        {
            foreach (Pin op in output_pins)
            {
                op.State = input_pins[0].State;
            }
        }
    }
}
