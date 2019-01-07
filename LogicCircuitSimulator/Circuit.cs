using System.Collections.Generic;

namespace LogicCircuitSimulator
{
    class Circuit
    {
        private List<Element> elements;
        private Dictionary<Pin, Pin> port_map;

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

            pin.ConnectedPin.ConnectedPin = null;
            pin.ConnectedPin = null;
            if (pin.Side == PinSide.INPUT)
            {
                port_map.Remove(pin.ConnectedPin);
            }
            else if (pin.Side == PinSide.OUTPUT)
            {
                port_map.Remove(pin);
            }
            else
            {
                throw new InvalidPinSideException();
            }
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

        void SimulateFor(uint duration)
        {
            for (uint i = 0; i < duration; i++)
            {
                NextMoment();
            }
        }

        void SimulateUntil(uint moment)
        {
            RestartSimulation();
            SimulateFor(moment);
        }  
    }
}
