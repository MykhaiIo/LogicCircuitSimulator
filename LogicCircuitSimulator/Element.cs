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

        public List<Pin> InputPins { get { return input_pins; } }

        public List<Pin> OutputPins { get { return output_pins; } }
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
            SimulationInputValue = new Logic(LogicValue.UNINITIALIZED);
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
        }
    }

    abstract class MultipleInputGate : Gate
    {
        protected MultipleInputGate()
            : base()
        { }

        protected void Initialize2to1AsynchGate()
        {
            Initialize1to1AsynchGate();
            input_pins.Add(new Pin(PinSide.INPUT));
        }

        public void AddInputPins(byte n_pins)
        {
            if (input_pins.Count + n_pins > 8)
                throw new NumberOfPinsOutOfRangeException();

            for (byte i = 0; i < n_pins; i++)
            {
                input_pins.Add(new Pin(PinSide.INPUT));
            }
        }

        public void RemoveInputPins(byte n_pins)
        {
            byte size = (byte)input_pins.Count;
            if (size - n_pins < 2)
                throw new NumberOfPinsOutOfRangeException();

            // Check whether pins which will be removed are not connected
            for (byte pin_idx = (byte)(size - 1); pin_idx > size - n_pins - 1; pin_idx--)
            {
                if (input_pins[pin_idx].ConnectedPin != null)
                    throw new ConnectedPinException();
            }

            // Remove of pins
            for (byte pin_idx = (byte)(size - 1); pin_idx > size - n_pins - 1; pin_idx--)
            {
                input_pins.Remove(input_pins[pin_idx]);
            }
        }
    }

    abstract class SingleInputGate : Gate
    {
        protected SingleInputGate()
            : base()
        { }

        protected void Initialize1to2AsynchGate()
        {
            Initialize1to1AsynchGate();
            output_pins.Add(new Pin(PinSide.OUTPUT));
        }
    }

    class AND : MultipleInputGate
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

    class NAND : MultipleInputGate
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

    class OR : MultipleInputGate
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

    class NOR : MultipleInputGate
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

    class XOR : MultipleInputGate
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

    class XNOR : MultipleInputGate
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

    class NOT : SingleInputGate
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

    class FORK : SingleInputGate
    {
        public FORK()
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

        public void AddOutputPins(byte n_pins)
        {
            if (output_pins.Count + n_pins > 8)
                throw new NumberOfPinsOutOfRangeException();

            for (byte i = 0; i < n_pins; i++)
            {
                output_pins.Add(new Pin(PinSide.OUTPUT));
            }
        }

        public void RemoveOutputPins(byte n_pins)
        {
            byte size = (byte)output_pins.Count;
            if (size - n_pins < 1)
                throw new NumberOfPinsOutOfRangeException();

            // Check whether pins which will be removed are not connected
            for (byte pin_idx = (byte)(size - 1); pin_idx > size - n_pins - 1; pin_idx--)
            {
                if (output_pins[pin_idx].ConnectedPin != null)
                    throw new ConnectedPinException();
            }

            // Remove of pins
            for (byte pin_idx = (byte)(size - 1); pin_idx > size - n_pins - 1; pin_idx--)
            {
                output_pins.Remove(output_pins[pin_idx]);
            }
        }
    }
}
