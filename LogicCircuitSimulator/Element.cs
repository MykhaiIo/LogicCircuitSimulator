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
}
