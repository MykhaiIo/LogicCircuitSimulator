using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LogicCircuitSimulator
{
    public static class GraphicSymbols
    {
        public enum Elements
        {
            AND2, AND3, AND4, AND5, AND6, AND7, AND8,
            NAND2, NAND3, NAND4, NAND5, NAND6, NAND7, NAND8,
            OR2, OR3, OR4, OR5, OR6, OR7, OR8,
            NOR2, NOR3, NOR4, NOR5, NOR6, NOR7, NOR8,
            XOR2, XOR3, XOR4, XOR5, XOR6, XOR7, XOR8,
            XNOR2, XNOR3, XNOR4, XNOR5, XNOR6, XNOR7, XNOR8,
            BUF, INV, FORK3, FORK4, ITerm, OTerm
        }

        public static Point[] I1PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 12 },
            new Point { X = 40, Y = 12 }
        };

        public static Point[] I2PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 10 },
            new Point { X = 0, Y = 20 },
            new Point { X = 40, Y = 15 }
        };

        public static Point[] I3PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 8 },
            new Point { X = 0, Y = 15 },
            new Point { X = 0, Y = 23 },
            new Point { X = 40, Y = 15 },
        };

        public static Point[] I4PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 6 },
            new Point { X = 0, Y = 12 },
            new Point { X = 0, Y = 19 },
            new Point { X = 0, Y = 25 },
            new Point { X = 40, Y = 15 },
        };

        public static Point[] I5PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 4 },
            new Point { X = 0, Y = 10 },
            new Point { X = 0, Y = 16 },
            new Point { X = 0, Y = 22 },
            new Point { X = 0, Y = 27 },
            new Point { X = 40, Y = 15 },
        };

        public static Point[] I6PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 6 },
            new Point { X = 0, Y = 12 },
            new Point { X = 0, Y = 18 },
            new Point { X = 0, Y = 24 },
            new Point { X = 0, Y = 29 },
            new Point { X = 0, Y = 35 },
            new Point { X = 40, Y = 20 },
        };

        public static Point[] I7PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 6 },
            new Point { X = 0, Y = 12 },
            new Point { X = 0, Y = 18 },
            new Point { X = 0, Y = 23 },
            new Point { X = 0, Y = 28 },
            new Point { X = 0, Y = 34 },
            new Point { X = 0, Y = 39 },
            new Point { X = 40, Y = 23 },
        };

        public static Point[] I8PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 4 },
            new Point { X = 0, Y = 10 },
            new Point { X = 0, Y = 16 },
            new Point { X = 0, Y = 21 },
            new Point { X = 0, Y = 26 },
            new Point { X = 0, Y = 32 },
            new Point { X = 0, Y = 37 },
            new Point { X = 0, Y = 42 },
            new Point { X = 40, Y = 24 },
        };

        public static Point[] F3PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 0 },
            new Point { X = 0, Y = 10 },
            new Point { X = 10, Y = 5 }
        };

        public static Point[] F4PortsCoordinates1 { get; } = {
            new Point { X = 0, Y = 5 },
            new Point { X = 5, Y = 0 },
            new Point { X = 10, Y = 5 },
            new Point { X = 5, Y = 10 }
        };

        public static PointF TICoordinates1 { get; } = new PointF(21, 2.5f);

        public static PointF TOCoordinates1 { get; } = new PointF(0, 2.5f);

        public static bool IsGate(Elements _type)
        {
            switch (_type)
            {
                case Elements.BUF:
                case Elements.INV:

                case Elements.AND2:
                case Elements.AND3:
                case Elements.AND4:
                case Elements.AND5:
                case Elements.AND6:
                case Elements.AND7:
                case Elements.AND8:

                case Elements.NAND2:
                case Elements.NAND3:
                case Elements.NAND4:
                case Elements.NAND5:
                case Elements.NAND6:
                case Elements.NAND7:
                case Elements.NAND8:

                case Elements.OR2:
                case Elements.OR3:
                case Elements.OR4:
                case Elements.OR5:
                case Elements.OR6:
                case Elements.OR7:
                case Elements.OR8:

                case Elements.NOR2:
                case Elements.NOR3:
                case Elements.NOR4:
                case Elements.NOR5:
                case Elements.NOR6:
                case Elements.NOR7:
                case Elements.NOR8:

                case Elements.XOR2:
                case Elements.XOR3:
                case Elements.XOR4:
                case Elements.XOR5:
                case Elements.XOR6:
                case Elements.XOR7:
                case Elements.XOR8:

                case Elements.XNOR2:
                case Elements.XNOR3:
                case Elements.XNOR4:
                case Elements.XNOR5:
                case Elements.XNOR6:
                case Elements.XNOR7:
                case Elements.XNOR8:
                    return true;

                default:
                    return false;
            }
        }


        public static bool IsUnaryGate(Elements _type)
        {
            switch (_type)
            {
                case Elements.BUF:
                case Elements.INV:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsBinaryGate(Elements _type)
        {
            switch (_type)
            {
                case Elements.AND2:
                case Elements.AND3:
                case Elements.AND4:
                case Elements.AND5:
                case Elements.AND6:
                case Elements.AND7:
                case Elements.AND8:

                case Elements.NAND2:
                case Elements.NAND3:
                case Elements.NAND4:
                case Elements.NAND5:
                case Elements.NAND6:
                case Elements.NAND7:
                case Elements.NAND8:

                case Elements.OR2:
                case Elements.OR3:
                case Elements.OR4:
                case Elements.OR5:
                case Elements.OR6:
                case Elements.OR7:
                case Elements.OR8:

                case Elements.NOR2:
                case Elements.NOR3:
                case Elements.NOR4:
                case Elements.NOR5:
                case Elements.NOR6:
                case Elements.NOR7:
                case Elements.NOR8:

                case Elements.XOR2:
                case Elements.XOR3:
                case Elements.XOR4:
                case Elements.XOR5:
                case Elements.XOR6:
                case Elements.XOR7:
                case Elements.XOR8:

                case Elements.XNOR2:
                case Elements.XNOR3:
                case Elements.XNOR4:
                case Elements.XNOR5:
                case Elements.XNOR6:
                case Elements.XNOR7:
                case Elements.XNOR8:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsPort(Elements _type)
        {
            switch (_type)
            {
                case Elements.ITerm:
                case Elements.OTerm:
                    return true;

                default:
                    return false;
            }
        }

        public static bool IsFork(Elements _type)
        {
            switch(_type)
            {
                case Elements.FORK3:
                case Elements.FORK4:
                    return true;

                default:
                    return false;
            }
        }

    }
}
