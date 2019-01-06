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

        bool HaveConnectedPins(Element element)
        {
            foreach (Pin in_pin in element.GetPinsBySide(PinSide.INPUT))
            {
                if (port_map.ContainsKey(in_pin))
                    return true;
            }
            foreach (Pin out_pin in element.GetPinsBySide(PinSide.OUTPUT))
            {
                if (port_map.ContainsValue(out_pin))
                    return true;
            }
            return false;
        }
    
        void RemoveElement(Element element)
        {
            elements.Remove(element);
        }

        void Connect(Pin from, Pin to)
        {
            port_map.Add(from, to);
        }
        
        void Disconnect(Pin pin)
        {
            if (port_map.ContainsKey(pin))
            {
                port_map.Remove(pin);
                return;
            }
            if (port_map.ContainsValue(pin))
            {
                foreach (var pair in port_map)
                {
                    if (Object.ReferenceEquals(pair.Value, pin))
                    {
                        port_map.Remove(pair.Key);
                        return;
                    }
                }
                throw new Exception("Value exists but pair not removed");
            }
            throw new AlreadyDisconnectedPinException();
        }
    }
}
