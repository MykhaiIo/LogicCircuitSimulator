using System.Collections.Generic;

namespace LogicCircuitSimulator
{
    class Circuit
    {
        private List<Element> elements;
        private Dictionary<Pin, Pin> port_map;

        public Dictionary<Pin, Pin> Connections { get { return port_map; } }

        public Circuit()
        {
            elements = new List<Element>();
            port_map = new Dictionary<Pin, Pin>();
        }

        public void AddElement(Element element)
        {
            elements.Add(element);
        }
    
        public void RemoveElement(Element element)
        {
            if (element.HasConnectedPins())
                throw new ElementHasConnectedPinsException();

            elements.Remove(element);
        }

        public void Connect(Pin from, Pin to)
        {
            if (from.Side != PinSide.OUTPUT)
                throw new InvalidPinSideException();
            if (to.Side != PinSide.INPUT)
                throw new InvalidPinSideException();

            from.ConnectedPin = to;
            to.ConnectedPin = from;
            port_map.Add(from, to);
        }
        
        public void Disconnect(Pin pin)
        {
            if (pin.ConnectedPin == null)
                throw new AlreadyDisconnectedPinException();

            Pin opposite_pin = pin.ConnectedPin;

            if (pin.Side == PinSide.INPUT)
            {
                port_map.Remove(opposite_pin); // Remove throught output pin
            }
            else if (pin.Side == PinSide.OUTPUT)
            {
                port_map.Remove(pin);
            }
            else
            {
                throw new InvalidPinSideException();
            }

            pin.ConnectedPin = null;
            opposite_pin.ConnectedPin = null;
        }

        public void RestartSimulation()
        {
            foreach (var element in elements)
            {
                foreach (var in_pin in element.GetPinsBySide(PinSide.INPUT))
                {
                    in_pin.State = new Logic(LogicValue.UNINITIALIZED);
                }
                foreach (var out_pin in element.GetPinsBySide(PinSide.OUTPUT))
                {
                    out_pin.State = new Logic(LogicValue.UNINITIALIZED);
                }
            }
        }

        public void NextMoment()
        {
            foreach (var elem in elements)
            {
                elem.Functionality();
            }
            foreach(var connection in port_map)
            {
                connection.Value.State = connection.Key.State;
            }
        }

        public void SimulateFor(uint duration)
        {
            for (uint i = 0; i < duration; i++)
            {
                NextMoment();
            }
        }

        public void SimulateUntil(uint moment)
        {
            RestartSimulation();
            SimulateFor(moment);
        }

        public void SetNumberOfInputPins(MultipleInputGate gate, byte new_n_pins)
        {
            if (new_n_pins < 2 || new_n_pins > 8)
                throw new NumberOfPinsOutOfRangeException();

            List<Pin> in_pins = gate.GetPinsBySide(PinSide.INPUT);
            byte cur_n_pins = (byte)in_pins.Count;

            if (new_n_pins < cur_n_pins)
            {
                // Disconnect pins which will be removed
                for (var pin_idx = new_n_pins; pin_idx < cur_n_pins; pin_idx++)
                {
                    Pin cur_pin = in_pins[pin_idx];
                    if (cur_pin.ConnectedPin != null)
                        Disconnect(cur_pin);
                }

                // Remove pins
                gate.RemoveInputPins((byte)(cur_n_pins - new_n_pins));
            }
            else if (new_n_pins > cur_n_pins)
            {
                gate.AddInputPins((byte)(new_n_pins - cur_n_pins));
            }
        }

        public void SetNumberOfOutputPins(FORK gate, byte new_n_pins)
        {
            if (new_n_pins < 1 || new_n_pins > 3)
                throw new NumberOfPinsOutOfRangeException();

            List<Pin> out_pins = gate.GetPinsBySide(PinSide.OUTPUT);
            byte cur_n_pins = (byte)out_pins.Count;

            if (new_n_pins < cur_n_pins)
            {
                // Disconnect pins which will be removed
                for (var pin_idx = new_n_pins; pin_idx < cur_n_pins; pin_idx++)
                {
                    Pin cur_pin = out_pins[pin_idx];
                    if (cur_pin.ConnectedPin != null)
                        Disconnect(cur_pin);
                }

                // Remove pins
                gate.RemoveOutputPins((byte)(cur_n_pins - new_n_pins));
            }
            else if (new_n_pins > cur_n_pins)
            {
                gate.AddOutputPins((byte)(new_n_pins - cur_n_pins));
            }
        }
    }
}
