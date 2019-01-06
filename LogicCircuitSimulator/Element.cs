using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCircuitSimulator
{
    abstract class Element
    {
        public List<Pin> input_pins, output_pins;

        public int Delay { get; set; }
        public abstract void Functionality();
    }

    abstract class Terminal : Element
    {
        
    }

    class InTerminal : Terminal
    {
        public Logic SimulationInputValue { get; set; }

        public InTerminal()
        {
            input_pins.Clear();
            output_pins.Add(new Pin());
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
        {
            input_pins.Add(new Pin());
            output_pins.Clear();
            Delay = 0;
        }

        public override void Functionality()
        {
            SimulationResult = input_pins[0].State;
        }
    }

    abstract class Gate : Element
    {
        protected void Initialize1to1AsynchGate()
        {
            input_pins.Add(new Pin());
            output_pins.Add(new Pin());
            Delay = 0;
        }

        protected void Initialize2to1AsynchGate()
        {
            Initialize1to1AsynchGate();
            input_pins.Add(new Pin());
        }

        protected void Initialize1to2AsynchGate()
        {
            Initialize1to1AsynchGate();
            output_pins.Add(new Pin());
        }

        // TODO: Add methods for number of pins
    }

    class AND : Gate
    {
        public AND()
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
