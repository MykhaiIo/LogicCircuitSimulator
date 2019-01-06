using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCircuitSimulator
{
    class Circuit
    {
        private List<Element> elements;
        private Dictionary<Pin, Pin> port_map;

        Circuit()
        {
            elements = new List<Element>();
            port_map = new Dictionary<Pin, Pin>();
        }

        Element AddElement(ElementType type)
        {
            Element elem;
            switch (type)
            {
                
                case ElementType.AND:
                    {
                        elem = new AND();
                        break;
                    }
                case ElementType.NAND:
                    {
                        elem = new NAND();
                        break;
                    }
                case ElementType.OR:
                    {
                        elem = new OR();
                        break;
                    }
                case ElementType.NOR:
                    {
                        elem = new NOR();
                        break;
                    }
                case ElementType.XOR:
                    {
                        elem = new XOR();
                        break;
                    }
                case ElementType.XNOR:
                    {
                        elem = new XNOR();
                        break;
                    }
                case ElementType.NOT:
                    {
                        elem = new NOT();
                        break;
                    }
                case ElementType.BUFF:
                    {
                        elem = new BUFF();
                        break;
                    }
                default:
                    throw new NotImplementedException("Not implemented element type");
            }
            return elem;
        }
    
        void RemoveElement(Element element)
        {
            if (element.HasConnectedPins())
                throw new ElementHasConnectedPinsException();

            elements.Remove(element);
        }

        void Connect(Pin from, Pin to)
        {
            from.ConnectedPin = to;
            to.ConnectedPin = from;
            port_map.Add(from, to);
        }
        
        void Disconnect(Pin pin)
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
    }
}
