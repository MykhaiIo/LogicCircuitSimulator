using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace LogicCircuitSimulator
{
    abstract class VisualElement
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

        protected List<Point> visual_input_pins, visual_output_pins;
        protected Dictionary<Pin, Point> visual_pin;
        protected Dictionary<List<Pin>, List<Point>> visual_pins;
        public Bitmap ElementImage { get; private set; }
        protected Element Element { get; private set; }

        protected VisualElement()
        {
            visual_input_pins = new List<Point>();
            visual_output_pins = new List<Point>();
            //visual_pins = new Dictionary<List<Point>, Point>();
        }

        

    abstract class VisualTerminal : VisualElement
    {
        protected VisualTerminal()
            : base()
        { }
    }

    class VisualInTerminal : VisualTerminal
    {
        public Logic SimulationInputValue { get; set; }

        public VisualInTerminal()
            : base()
        {
            visual_input_pins.Clear();
            
        }

        
    }

    class VisualOutTerminal : VisualTerminal
    {
        public Logic SimulationResult { get; private set; }

            public VisualOutTerminal()
                : base()
            {
                visual_output_pins.Clear();
            }
    }

    abstract class VisualGate : VisualElement
    {
        protected VisualGate()
            : base()
        { }

            protected void Initialize1to1AsynchGate()
            {
                
            }
    }

    abstract class VisualMultipleInputGate : VisualGate
    {
        protected VisualMultipleInputGate()
            : base()
        { }

        

        
    }

    abstract class VisualSingleInputGate : VisualGate
    {
        protected VisualSingleInputGate()
            : base()
        { }

        protected void Initialize1to2AsynchGate()
        {
            Initialize1to1AsynchGate();
        }
    }

    class VisualAND : VisualMultipleInputGate
    {
            public VisualAND()
                : base()
            {
                visual_input_pins.AddRange(I2PortsCoordinates);
                ElementImage = new Bitmap(GetImage(Elements.AND2));
                Element = new AND();
            }

            protected void ChangeNumberOfInputs(uint _inputs)
            {
                switch (_inputs)
                {
                    case 0:
                    case 1:
                    case 2:
                        visual_input_pins.AddRange(I2PortsCoordinates);
                        ElementImage = new Bitmap(GetImage(Elements.AND2));
                        var Circuit = new Circuit();
                        //Circuit.SetNumberOfInputPins(Element, 2);
                        break;
                    case 3:
                        visual_input_pins.AddRange(I3PortsCoordinates);
                        ElementImage = new Bitmap(GetImage(Elements.AND3));
                        break;
                    case 4:
                        visual_input_pins.AddRange(I4PortsCoordinates);
                        ElementImage = new Bitmap(GetImage(Elements.AND4));
                        break;
                    case 5:
                        visual_input_pins.AddRange(I5PortsCoordinates);
                        ElementImage = new Bitmap(GetImage(Elements.AND5));
                        break;
                    case 6:
                        visual_input_pins.AddRange(I6PortsCoordinates);
                        ElementImage = new Bitmap(GetImage(Elements.AND6));
                        break;
                    case 7:
                        visual_input_pins.AddRange(I7PortsCoordinates);
                        ElementImage = new Bitmap(GetImage(Elements.AND7));
                        break;
                    case 8:
                        visual_input_pins.AddRange(I8PortsCoordinates);
                        ElementImage = new Bitmap(GetImage(Elements.AND8));
                        break;

                    default:
                        throw new InvalidEnumArgumentException(
                            "_type", (int)_inputs, typeof(Elements)
                        );


                }

            }


        }

    class VisualNAND : VisualMultipleInputGate
        {
        public VisualNAND()
            : base()
        {
            //Initialize2to1AsynchGate();
        }

        
    }

       

    class VisualOR : VisualMultipleInputGate
        {
            public VisualOR()
                : base()
            {
                //Initialize2to1AsynchGate();
            }

        
    }

    class VisualNOR : VisualMultipleInputGate
        {
            public VisualNOR()
                : base()
            {
                //Initialize2to1AsynchGate();
            }
    }

    class VisualXOR : VisualMultipleInputGate
        {
            public VisualXOR()
                : base()
            {
                //Initialize2to1AsynchGate();
            }

        
    }

    class VisualXNOR : VisualMultipleInputGate
        {
            public VisualXNOR()
                : base()
            {
                //Initialize2to1AsynchGate();
            }

        
    }

    class VisualNOT : VisualSingleInputGate
        {
        public VisualNOT()
            : base()
        {
            Initialize1to1AsynchGate();
        }

        
    }

        class VisualFORK : VisualSingleInputGate
        {
            public VisualFORK()
                : base()
            {
                Initialize1to2AsynchGate();
            }


        }

        public static Point[] I1PortsCoordinates { get; } = {
            new Point { X = 0, Y = 12 },
            new Point { X = 40, Y = 12 }
        };

        public static Point[] I2PortsCoordinates { get; } = {
            new Point { X = 0, Y = 10 },
            new Point { X = 0, Y = 20 },
            new Point { X = 40, Y = 15 }
        };

        public static Point[] I3PortsCoordinates { get; } = {
            new Point { X = 0, Y = 8 },
            new Point { X = 0, Y = 15 },
            new Point { X = 0, Y = 23 },
            new Point { X = 40, Y = 15 },
        };

        public static Point[] I4PortsCoordinates { get; } = {
            new Point { X = 0, Y = 6 },
            new Point { X = 0, Y = 12 },
            new Point { X = 0, Y = 19 },
            new Point { X = 0, Y = 25 },
            new Point { X = 40, Y = 15 },
        };

        public static Point[] I5PortsCoordinates { get; } = {
            new Point { X = 0, Y = 4 },
            new Point { X = 0, Y = 10 },
            new Point { X = 0, Y = 16 },
            new Point { X = 0, Y = 22 },
            new Point { X = 0, Y = 27 },
            new Point { X = 40, Y = 15 },
        };

        public static Point[] I6PortsCoordinates { get; } = {
            new Point { X = 0, Y = 6 },
            new Point { X = 0, Y = 12 },
            new Point { X = 0, Y = 18 },
            new Point { X = 0, Y = 24 },
            new Point { X = 0, Y = 29 },
            new Point { X = 0, Y = 35 },
            new Point { X = 40, Y = 20 },
        };

        public static Point[] I7PortsCoordinates { get; } = {
            new Point { X = 0, Y = 6 },
            new Point { X = 0, Y = 12 },
            new Point { X = 0, Y = 18 },
            new Point { X = 0, Y = 23 },
            new Point { X = 0, Y = 28 },
            new Point { X = 0, Y = 34 },
            new Point { X = 0, Y = 39 },
            new Point { X = 40, Y = 23 },
        };

        public static Point[] I8PortsCoordinates { get; } = {
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

        public static Point[] F3PortsCoordinates { get; } = {
            new Point { X = 0, Y = 0 },
            new Point { X = 0, Y = 10 },
            new Point { X = 10, Y = 5 }
        };

        public static Point[] F4PortsCoordinates { get; } = {
            new Point { X = 0, Y = 5 },
            new Point { X = 5, Y = 0 },
            new Point { X = 10, Y = 5 },
            new Point { X = 5, Y = 10 }
        };



        public static Point TICoordinates { get; } = new Point(21, 2);

        public static Point TOCoordinates { get; } = new Point(0, 2);

        public Bitmap GetImage(Elements _type)
        {
            switch (_type)
            {
                case Elements.BUF:
                    return LogicCircuitSimulator.Properties.Resources.BUF;

                case Elements.INV:
                    return LogicCircuitSimulator.Properties.Resources.INV;


                case Elements.AND2:
                    return LogicCircuitSimulator.Properties.Resources._2AND;

                case Elements.AND3:
                    return LogicCircuitSimulator.Properties.Resources._3AND;

                case Elements.AND4:
                    return LogicCircuitSimulator.Properties.Resources._4AND;

                case Elements.AND5:
                    return LogicCircuitSimulator.Properties.Resources._5AND;

                case Elements.AND6:
                    return LogicCircuitSimulator.Properties.Resources._6AND;

                case Elements.AND7:
                    return LogicCircuitSimulator.Properties.Resources._7AND;

                case Elements.AND8:
                    return LogicCircuitSimulator.Properties.Resources._8AND;


                case Elements.NAND2:
                    return LogicCircuitSimulator.Properties.Resources._2NAND;

                case Elements.NAND3:
                    return LogicCircuitSimulator.Properties.Resources._3NAND;

                case Elements.NAND4:
                    return LogicCircuitSimulator.Properties.Resources._4NAND;

                case Elements.NAND5:
                    return LogicCircuitSimulator.Properties.Resources._5NAND;

                case Elements.NAND6:
                    return LogicCircuitSimulator.Properties.Resources._6NAND;

                case Elements.NAND7:
                    return LogicCircuitSimulator.Properties.Resources._7NAND;

                case Elements.NAND8:
                    return LogicCircuitSimulator.Properties.Resources._8NAND;


                case Elements.OR2:
                    return LogicCircuitSimulator.Properties.Resources._2OR;

                case Elements.OR3:
                    return LogicCircuitSimulator.Properties.Resources._3OR;

                case Elements.OR4:
                    return LogicCircuitSimulator.Properties.Resources._4OR;

                case Elements.OR5:
                    return LogicCircuitSimulator.Properties.Resources._5OR;

                case Elements.OR6:
                    return LogicCircuitSimulator.Properties.Resources._6OR;

                case Elements.OR7:
                    return LogicCircuitSimulator.Properties.Resources._7OR;

                case Elements.OR8:
                    return LogicCircuitSimulator.Properties.Resources._8OR;


                case Elements.NOR2:
                    return LogicCircuitSimulator.Properties.Resources._2NOR;

                case Elements.NOR3:
                    return LogicCircuitSimulator.Properties.Resources._3NOR;

                case Elements.NOR4:
                    return LogicCircuitSimulator.Properties.Resources._4NOR;

                case Elements.NOR5:
                    return LogicCircuitSimulator.Properties.Resources._5NOR;

                case Elements.NOR6:
                    return LogicCircuitSimulator.Properties.Resources._6NOR;

                case Elements.NOR7:
                    return LogicCircuitSimulator.Properties.Resources._7NOR;

                case Elements.NOR8:
                    return LogicCircuitSimulator.Properties.Resources._8NOR;


                case Elements.XOR2:
                    return LogicCircuitSimulator.Properties.Resources._2XOR;

                case Elements.XOR3:
                    return LogicCircuitSimulator.Properties.Resources._3XOR;

                case Elements.XOR4:
                    return LogicCircuitSimulator.Properties.Resources._4XOR;

                case Elements.XOR5:
                    return LogicCircuitSimulator.Properties.Resources._5XOR;

                case Elements.XOR6:
                    return LogicCircuitSimulator.Properties.Resources._6XOR;

                case Elements.XOR7:
                    return LogicCircuitSimulator.Properties.Resources._7XOR;

                case Elements.XOR8:
                    return LogicCircuitSimulator.Properties.Resources._8XOR;


                case Elements.XNOR2:
                    return LogicCircuitSimulator.Properties.Resources._2XNOR;

                case Elements.XNOR3:
                    return LogicCircuitSimulator.Properties.Resources._3XNOR;

                case Elements.XNOR4:
                    return LogicCircuitSimulator.Properties.Resources._4XNOR;

                case Elements.XNOR5:
                    return LogicCircuitSimulator.Properties.Resources._5XNOR;

                case Elements.XNOR6:
                    return LogicCircuitSimulator.Properties.Resources._6XNOR;

                case Elements.XNOR7:
                    return LogicCircuitSimulator.Properties.Resources._7XNOR;

                case Elements.XNOR8:
                    return LogicCircuitSimulator.Properties.Resources._8XNOR;


                case Elements.FORK3:
                    return LogicCircuitSimulator.Properties.Resources.Fork3;

                case Elements.FORK4:
                    return LogicCircuitSimulator.Properties.Resources.Fork4;


                case Elements.ITerm:
                    return LogicCircuitSimulator.Properties.Resources.ITerminal;

                case Elements.OTerm:
                    return LogicCircuitSimulator.Properties.Resources.OTerminal;

                default:
                    throw new InvalidEnumArgumentException(
                        "_type", (int)_type, typeof(Elements)
                    );
            }
        }

        //public static bool IsGate(Elements _type)
        //{
        //    switch (_type)
        //    {
        //        case Elements.BUF:
        //        case Elements.INV:

        //        case Elements.AND2:
        //        case Elements.AND3:
        //        case Elements.AND4:
        //        case Elements.AND5:
        //        case Elements.AND6:
        //        case Elements.AND7:
        //        case Elements.AND8:

        //        case Elements.NAND2:
        //        case Elements.NAND3:
        //        case Elements.NAND4:
        //        case Elements.NAND5:
        //        case Elements.NAND6:
        //        case Elements.NAND7:
        //        case Elements.NAND8:

        //        case Elements.OR2:
        //        case Elements.OR3:
        //        case Elements.OR4:
        //        case Elements.OR5:
        //        case Elements.OR6:
        //        case Elements.OR7:
        //        case Elements.OR8:

        //        case Elements.NOR2:
        //        case Elements.NOR3:
        //        case Elements.NOR4:
        //        case Elements.NOR5:
        //        case Elements.NOR6:
        //        case Elements.NOR7:
        //        case Elements.NOR8:

        //        case Elements.XOR2:
        //        case Elements.XOR3:
        //        case Elements.XOR4:
        //        case Elements.XOR5:
        //        case Elements.XOR6:
        //        case Elements.XOR7:
        //        case Elements.XOR8:

        //        case Elements.XNOR2:
        //        case Elements.XNOR3:
        //        case Elements.XNOR4:
        //        case Elements.XNOR5:
        //        case Elements.XNOR6:
        //        case Elements.XNOR7:
        //        case Elements.XNOR8:
        //            return true;

        //        default:
        //            return false;
        //    }
        //}


        //public static bool IsUnaryGate(Elements _type)
        //{
        //    switch (_type)
        //    {
        //        case Elements.BUF:
        //        case Elements.INV:
        //            return true;

        //        default:
        //            return false;
        //    }
        //}

        //public static bool IsPolinaryGate(Elements _type)
        //{
        //    switch (_type)
        //    {
        //        case Elements.AND2:
        //        case Elements.AND3:
        //        case Elements.AND4:
        //        case Elements.AND5:
        //        case Elements.AND6:
        //        case Elements.AND7:
        //        case Elements.AND8:

        //        case Elements.NAND2:
        //        case Elements.NAND3:
        //        case Elements.NAND4:
        //        case Elements.NAND5:
        //        case Elements.NAND6:
        //        case Elements.NAND7:
        //        case Elements.NAND8:

        //        case Elements.OR2:
        //        case Elements.OR3:
        //        case Elements.OR4:
        //        case Elements.OR5:
        //        case Elements.OR6:
        //        case Elements.OR7:
        //        case Elements.OR8:

        //        case Elements.NOR2:
        //        case Elements.NOR3:
        //        case Elements.NOR4:
        //        case Elements.NOR5:
        //        case Elements.NOR6:
        //        case Elements.NOR7:
        //        case Elements.NOR8:

        //        case Elements.XOR2:
        //        case Elements.XOR3:
        //        case Elements.XOR4:
        //        case Elements.XOR5:
        //        case Elements.XOR6:
        //        case Elements.XOR7:
        //        case Elements.XOR8:

        //        case Elements.XNOR2:
        //        case Elements.XNOR3:
        //        case Elements.XNOR4:
        //        case Elements.XNOR5:
        //        case Elements.XNOR6:
        //        case Elements.XNOR7:
        //        case Elements.XNOR8:
        //            return true;

        //        default:
        //            return false;
        //    }
        //}

        //public static bool IsPort(Elements _type)
        //{
        //    switch (_type)
        //    {
        //        case Elements.ITerm:
        //        case Elements.OTerm:
        //            return true;

        //        default:
        //            return false;
        //    }
        //}

        //public static bool IsFork(Elements _type)
        //{
        //    switch (_type)
        //    {
        //        case Elements.FORK3:
        //        case Elements.FORK4:
        //            return true;

        //        default:
        //            return false;
        //    }
        //}


        public void DrawActiveLine(Graphics _g, PointF p1, PointF p2)
        {
            _g.DrawLine(Pens.Red, p1, p2);
        }

        public void DrawInactiveLine(Graphics _g, PointF p1, PointF p2)
        {
            _g.DrawLine(Pens.Black, p1, p2);
        }

        public void DrawElement(Graphics _g, Elements _type, Point p)
        {
            Image img = GetImage(_type);
            _g.DrawImage(img, p);
        }

        //public Elements Element { get; private set; }

        
    }

    static class GUI
    {
        public static Graphics g_graphics;

        public static void DrawActiveLine(PointF p1, PointF p2)
        {
            g_graphics.DrawLine(Pens.Red, p1, p2);
        }

        public static void DrawInactiveLine(PointF p1, PointF p2)
        {
            g_graphics.DrawLine(Pens.Black, p1, p2);
        }
    }
}
