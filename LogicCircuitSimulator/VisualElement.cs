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
    static class GUI
    {
        public static Graphics g_graphics;
        public static Circuit g_circuit = new Circuit();
        public static List<Visual.Element> elements = new List<Visual.Element>();
        public static Dictionary<Visual.Pin, Visual.Pin> visual_connections = new Dictionary<Visual.Pin, Visual.Pin>();

        public static void AddElement(Visual.Element new_element)
        {
            elements.Add(new_element);
        }

        public static void RemoveElement(Visual.Element element)
        {
            elements.Remove(element);
            // TODO: Handle connections with this element
        }

        public static void DrawActiveLine(PointF p1, PointF p2)
        {
            g_graphics.DrawLine(Pens.Red, p1, p2);
        }

        public static void DrawInactiveLine(PointF p1, PointF p2)
        {
            g_graphics.DrawLine(Pens.Black, p1, p2);
        }

        public static void DrawUninitializedLine(PointF p1, PointF p2)
        {
            g_graphics.DrawLine(Pens.Gray, p1, p2);
        }

        public static void DrawActiveConnection(Visual.Pin from, Visual.Pin to)
        {
            GUI.DrawActiveLine(from.Coords, to.Coords);
        }

        public static void DrawInactiveConnection(Visual.Pin from, Visual.Pin to)
        {
            GUI.DrawInactiveLine(from.Coords, to.Coords);
        }

        public static void DrawUninitializedConnection(Visual.Pin from, Visual.Pin to)
        {
            GUI.DrawUninitializedLine(from.Coords, to.Coords);
        }

        public class ConnectableImages
        {
            abstract public class ConnectableImage
            {
                public virtual Bitmap Image { get; }
                public virtual Point[] InputPoints { get; }
                public virtual Point[] OutputPoints { get; }

                
            }

            public class AND2 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._2AND;
                public override Point[] InputPoints { get; } = { new Point(0, 10), new Point(0, 20) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class NAND2 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._2NAND;
                public override Point[] InputPoints { get; } = { new Point(0, 10), new Point(0, 20) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class OR2 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._2OR;
                public override Point[] InputPoints { get; } = { new Point(0, 10), new Point(0, 20) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class NOR2 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._2NOR;
                public override Point[] InputPoints { get; } = { new Point(0, 10), new Point(0, 20) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class XOR2 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._2XOR;
                public override Point[] InputPoints { get; } = { new Point(0, 10), new Point(0, 20) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class XNOR2 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._2XNOR;
                public override Point[] InputPoints { get; } = { new Point(0, 10), new Point(0, 20) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class AND3 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._3AND;
                public override Point[] InputPoints { get; } = { new Point(0, 8), new Point(0, 15), new Point(0, 23) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class NAND3 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._3NAND;
                public override Point[] InputPoints { get; } = { new Point(0, 8), new Point(0, 15), new Point(0, 23) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class OR3 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._3OR;
                public override Point[] InputPoints { get; } = { new Point(0, 8), new Point(0, 15), new Point(0, 23) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class NOR3 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._3NOR;
                public override Point[] InputPoints { get; } = { new Point(0, 8), new Point(0, 15), new Point(0, 23) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class XOR3 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._3XOR;
                public override Point[] InputPoints { get; } = { new Point(0, 8), new Point(0, 15), new Point(0, 23) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class XNOR3 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._3XNOR;
                public override Point[] InputPoints { get; } = { new Point(0, 8), new Point(0, 15), new Point(0, 23) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class AND4 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._4AND;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 19), new Point(0, 25) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class NAND4 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._4NAND;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 19), new Point(0, 25) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class OR4 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._4OR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 19), new Point(0, 25) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class NOR4 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._4NOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 19), new Point(0, 25) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class XOR4 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._4XOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 19), new Point(0, 25) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class XNOR4 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._4XNOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 19), new Point(0, 25) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class AND5 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._5AND;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10),
                                                        new Point(0, 16), new Point(0, 22), new Point(0, 27) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class NAND5 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._5NAND;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10),
                                                        new Point(0, 16), new Point(0, 22), new Point(0, 27) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class OR5 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._5OR;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10),
                                                        new Point(0, 16), new Point(0, 22), new Point(0, 27) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class NOR5 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._5NOR;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10),
                                                        new Point(0, 16), new Point(0, 22), new Point(0, 27) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class XOR5 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._5XOR;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10),
                                                        new Point(0, 16), new Point(0, 22), new Point(0, 27) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class XNOR5 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._5XNOR;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10),
                                                        new Point(0, 16), new Point(0, 22), new Point(0, 27) };
                public override Point[] OutputPoints { get; } = { new Point(40, 15) };
            }

            public class AND6 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._6AND;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 24), new Point(0, 29), new Point(0, 35) };
                public override Point[] OutputPoints { get; } = { new Point(40, 20) };
            }

            public class NAND6 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._6NAND;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 24), new Point(0, 29), new Point(0, 35) };
                public override Point[] OutputPoints { get; } = { new Point(40, 20) };
            }

            public class OR6 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._6OR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 24), new Point(0, 29), new Point(0, 35) };
                public override Point[] OutputPoints { get; } = { new Point(40, 20) };
            }

            public class NOR6 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._6NOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 24), new Point(0, 29), new Point(0, 35) };
                public override Point[] OutputPoints { get; } = { new Point(40, 20) };
            }

            public class XOR6 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._6XOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 24), new Point(0, 29), new Point(0, 35) };
                public override Point[] OutputPoints { get; } = { new Point(40, 20) };
            }

            public class XNOR6 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._6XNOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 24), new Point(0, 29), new Point(0, 35) };
                public override Point[] OutputPoints { get; } = { new Point(40, 20) };
            }

            public class AND7 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._7AND;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 23), new Point(0, 28), new Point(0, 34), new Point(0, 39) };
                public override Point[] OutputPoints { get; } = { new Point(40, 23) };
            }

            public class NAND7 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._7NAND;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 23), new Point(0, 28), new Point(0, 34), new Point(0, 39) };
                public override Point[] OutputPoints { get; } = { new Point(40, 23) };
            }

            public class OR7 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._7OR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 23), new Point(0, 28), new Point(0, 34), new Point(0, 39) };
                public override Point[] OutputPoints { get; } = { new Point(40, 23) };
            }

            public class NOR7 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._7NOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 23), new Point(0, 28), new Point(0, 34), new Point(0, 39) };
                public override Point[] OutputPoints { get; } = { new Point(40, 23) };
            }

            public class XOR7 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._7XOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 23), new Point(0, 28), new Point(0, 34), new Point(0, 39) };
                public override Point[] OutputPoints { get; } = { new Point(40, 23) };
            }

            public class XNOR7 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._7XNOR;
                public override Point[] InputPoints { get; } = { new Point(0, 6), new Point(0, 12), new Point(0, 18),
                                                        new Point(0, 23), new Point(0, 28), new Point(0, 34), new Point(0, 39) };
                public override Point[] OutputPoints { get; } = { new Point(40, 23) };
            }

            public class AND8 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._8AND;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10), new Point(0, 16), new Point(0, 21),
                                                        new Point(0, 26), new Point(0, 32), new Point(0, 37), new Point(0, 42) };
                public override Point[] OutputPoints { get; } = { new Point(40, 24) };
            }

            public class NAND8 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._8NAND;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10), new Point(0, 16), new Point(0, 21),
                                                        new Point(0, 26), new Point(0, 32), new Point(0, 37), new Point(0, 42) };
                public override Point[] OutputPoints { get; } = { new Point(40, 24) };
            }

            public class OR8 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._8OR;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10), new Point(0, 16), new Point(0, 21),
                                                        new Point(0, 26), new Point(0, 32), new Point(0, 37), new Point(0, 42) };
                public override Point[] OutputPoints { get; } = { new Point(40, 24) };
            }

            public class NOR8 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._8NOR;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10), new Point(0, 16), new Point(0, 21),
                                                        new Point(0, 26), new Point(0, 32), new Point(0, 37), new Point(0, 42) };
                public override Point[] OutputPoints { get; } = { new Point(40, 24) };
            }

            public class XOR8 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._8XOR;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10), new Point(0, 16), new Point(0, 21),
                                                        new Point(0, 26), new Point(0, 32), new Point(0, 37), new Point(0, 42) };
                public override Point[] OutputPoints { get; } = { new Point(40, 24) };
            }

            public class XNOR8 : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources._8XNOR;
                public override Point[] InputPoints { get; } = { new Point(0, 4), new Point(0, 10), new Point(0, 16), new Point(0, 21),
                                                        new Point(0, 26), new Point(0, 32), new Point(0, 37), new Point(0, 42) };
                public override Point[] OutputPoints { get; } = { new Point(40, 24) };
            }

            public class BUF : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources.BUF;
                public override Point[] InputPoints { get; } = { new Point(0, 12) };
                public override Point[] OutputPoints { get; } = { new Point(40, 12) };
            }

            public class NOT : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources.INV;
                public override Point[] InputPoints { get; } = { new Point(0, 12) };
                public override Point[] OutputPoints { get; } = { new Point(40, 12) };
            }

            public class FORK : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources.Fork3;
                public override Point[] InputPoints { get; } = { new Point(0, 5) };
                public override Point[] OutputPoints { get; } = { new Point(5, 0), new Point(10, 5), new Point(5, 10) };
            }


            /*public static Point[] F3PortsCoordinates { get; } = {
                new Point { X = 0, Y = 0 },
                new Point { X = 0, Y = 10 },
                new Point { X = 10, Y = 5 }
            };*/

            public class ITERM : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources.ITerminal;
                public override Point[] OutputPoints { get; } = { new Point(20, 2) };
            }

            public class OTERM : ConnectableImage
            {
                public override Bitmap Image { get; } = Properties.Resources.OTerminal;
                public override Point[] InputPoints { get; } = { new Point(0, 2) };
            }


        }
        public class Visual
        {
            public static void Connect(Pin from, Pin to)
            {
                if (from.Side != PinSide.OUTPUT)
                    throw new InvalidPinSideException("Left pin must be output.");
                if (to.Side != PinSide.INPUT)
                    throw new InvalidPinSideException("Right pin must be input.");
                if (visual_connections.ContainsKey(from))
                    throw new InvalidPinSideException("Left pin already connected.");
                if (visual_connections.ContainsValue(to))
                    throw new InvalidPinSideException("Right pin already connected.");

                from.ConnectedPin = to;
                to.ConnectedPin = from;

                visual_connections.Add(from, to);

                LogicCircuitSimulator.Pin logic_from, logic_to;
                logic_from = from.Parent.LogicElement.GetPin(from.Side, (byte)from.Index);
                logic_to = to.Parent.LogicElement.GetPin(to.Side, (byte)to.Index);

                g_circuit.Connect(logic_from, logic_to);

                DrawInactiveConnection(from, to); // TODO: Use U-connection as default in future
            }

            public class Pin
            {
                public Pin(Visual.Element parent, PinSide side, int index)
                {
                    Parent = parent;
                    Side = side;
                    Index = index;
                }

                private Point GetShift(PinSide side, int index)
                {
                    if (side == PinSide.INPUT)
                        return Parent.ImageData.InputPoints[index];
                    else if (side == PinSide.OUTPUT)
                        return Parent.ImageData.OutputPoints[index];
                    else
                        throw new InvalidPinSideException();

                }

                public Point Coords
                {
                    get
                    {
                        return new Point(Parent.PictureBox.Location.X + GetShift(Side, Index).X,
                        Parent.PictureBox.Location.Y + GetShift(Side, Index).Y);
                    }
                }

                public int Index { get; set; }
                public PinSide Side { get; set; }
                public Visual.Pin ConnectedPin { get; set; }
                public Visual.Element Parent { get; private set; }
            }

            public abstract class Element
            {
                public LogicCircuitSimulator.Element LogicElement { get { return logic_element; } }
                public ConnectableImages.ConnectableImage ImageData { get { return image_data; } }
                public System.Windows.Forms.PictureBox PictureBox { get { return picture_box; } }
                public virtual string Identificator { get; }
                public List<Visual.Pin> InputPins = new List<Pin>();
                public List<Visual.Pin> OutputPins = new List<Pin>();

                protected System.Windows.Forms.PictureBox picture_box;
                protected LogicCircuitSimulator.Element logic_element;
                protected ConnectableImages.ConnectableImage image_data;
            }

            public abstract class Gate : Element
            {
                protected Gate()
                    : base()
                { }
            }

            public abstract class Terminal : Element
            {
                protected Terminal()
                    : base()
                { }
            }

            public class InTerminal : Terminal
            {
                public InTerminal()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.InTerminal();
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.ITERM();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 200),
                        Size = new Size(20, 5),
                        Image = image_data.Image
                    };
                }
                public override string Identificator { get => ($"INPUT X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class OutTerminal : Terminal
            {
                public OutTerminal()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.OutTerminal();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.OTERM();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 200),
                        Size = new Size(20, 5),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"OUTPUT X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }
                       
            public abstract class SingleInputGate : Gate
            {
                protected SingleInputGate()
                    : base()
                { }
            }

            public abstract class MultipleInputGate : Gate
            {
                protected MultipleInputGate()
                    : base()
                { }
            }

            public class AND : MultipleInputGate
            {
                public AND()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.AND();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 1));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.AND2();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(40, 30),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"AND X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class NAND : MultipleInputGate
            {
                public NAND()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.NAND();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 1));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.NAND2();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(40, 30),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"NAND X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class OR : MultipleInputGate
            {
                public OR()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.OR();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 1));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.OR2();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(40, 30),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"OR X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class NOR : MultipleInputGate
            {
                public NOR()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.NOR();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 1));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.NOR2();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(40, 30),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"NOR X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class XOR : MultipleInputGate
            {
                public XOR()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.XOR();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 1));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.XOR2();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(40, 30),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"XOR X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class XNOR : MultipleInputGate
            {
                public XNOR()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.XNOR();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 1));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.XNOR2();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(40, 30),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"XNOR X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class BUF : SingleInputGate
            {
                public BUF()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.FORK();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.BUF();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(40, 25),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"BUF X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class NOT : SingleInputGate
            {
                public NOT()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.NOT();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.NOT();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(40, 25),
                        Image = image_data.Image
                    };
                }

                public override string Identificator { get => ($"NOT X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }

            public class FORK : SingleInputGate
            {
                public FORK()
                    : base()
                {
                    logic_element = new LogicCircuitSimulator.FORK();
                    InputPins.Add(new Visual.Pin(this, PinSide.INPUT, 0));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 0));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 1));
                    OutputPins.Add(new Visual.Pin(this, PinSide.OUTPUT, 2));
                    g_circuit.AddElement(logic_element);
                    image_data = new ConnectableImages.FORK();
                    picture_box = new System.Windows.Forms.PictureBox
                    {
                        Name = elements.Count.ToString(),
                        Location = new Point(100, 100),
                        Size = new Size(10, 10),
                        Image = image_data.Image
                    };
                }
                public override string Identificator { get => ($"NODE X={picture_box.Location.X + picture_box.Size.Width / 2} Y={picture_box.Location.Y + picture_box.Size.Height / 2}"); }
            }
        }
    }
}
