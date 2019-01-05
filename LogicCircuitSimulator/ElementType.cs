using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCircuitSimulator
{
    // Add identifier to this enum when you create new type of circuit element
    public enum ElementType
    {
        AND,
        NAND,
        OR,
        NOR,
        XOR,
        XNOR,
        NOT,
        BUFF
    };
}
