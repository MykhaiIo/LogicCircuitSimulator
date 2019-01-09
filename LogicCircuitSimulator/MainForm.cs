using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicCircuitSimulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Circuit = new Circuit();
            graphics = panel1.CreateGraphics();
            VisualElements = new Dictionary<int, VisualElementDeprecated>();
            PictureBoxes = new Dictionary<int, PictureBox>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnitTest.TestCase_LogicOperatorAnd();
            UnitTest.TestCase_LogicOperatorOr();
            UnitTest.TestCase_LogicOperatorXor();
            UnitTest.TestCase_LogicOperatorNot();

            UnitTest.TestCase_AndGateSimulation();
            UnitTest.TestCase_Nand_Nor_GatesSimulation();
            UnitTest.TestCase_Xnor_Xor_GatesSimulation();
            UnitTest.TestCase_Fork_3Not_And_GatesSimulation();

            UnitTest.TestCase_SetNumberOfInputPinsAnd();
            UnitTest.TestCase_6AndGateSimulation();

            UnitTest.TestCase_ConnectDisconnectOfNot();

            UnitTest.TestCase_SetNumberOfInputPinsNand();
            UnitTest.TestCase_8NandGateSimulation();
        }

        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            xPos.Text = "X: " + e.Location.X;
            yPos.Text = "Y: " + e.Location.Y;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            GUI.g_graphics = e.Graphics;
            int w = panel1.Width;
            int h = panel1.Height;
            Pen blackpen = new Pen(Color.Black)
            {
                Width = 2
            };
            GUI.g_graphics.DrawRectangle(blackpen, 220, 50, w, h);
            blackpen.Dispose();
            GUI.g_graphics.Dispose();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private Circuit Circuit;
        private Graphics graphics;

        private Dictionary<int, VisualElementDeprecated> VisualElements; //Key = Element ID
        private Dictionary<int, PictureBox> PictureBoxes;      //Key = Element ID
        private List<Tuple<VisualElementDeprecated, VisualElementDeprecated>> Connections; // A -> B

        private bool MouseDownOnSelectedPicBox = false;
        private Point MouseDownLocation;

        private bool Connecting = false;
        private int SendingControlTag;
        private int ReceiveingControlTag;      

        private void bNext_Click(object sender, EventArgs e)
        {
            Circuit.NextMoment();
            Invalidate();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Circuit.SimulateFor(100);
            Invalidate();
        }

        private void bStop_Click(object sender, EventArgs e)
        {

        }

        private void bRestart_Click(object sender, EventArgs e)
        {

        }

        private void bAnd_Click(object sender, EventArgs e)
        {
            

        }

        private void bNand_Click(object sender, EventArgs e)
        {
            

        }

        private void bOr_Click(object sender, EventArgs e)
        {
            
        }

        private void bNor_Click(object sender, EventArgs e)
        {
            

        }

        private void bXor_Click(object sender, EventArgs e)
        {
            
        }

        private void bXnor_Click(object sender, EventArgs e)
        {
            

        }

        private void bBuf_Click(object sender, EventArgs e)
        {
           
        }

        private void bInv_Click(object sender, EventArgs e)
        {
            
        }

        private void bInPort_Click(object sender, EventArgs e)
        {
            
        }

        private void bOutPort_Click(object sender, EventArgs e)
        {
            /*var velement = new VisualElement(VisualElement.Elements.OTerm);
            VisualElements.Add(e.GetHashCode(), velement);
            var OutTer = new OutTerminal();
            Circuit.AddElement(OutTer);
            PictureBox pb = new PictureBox
            {
                Name = "OTer",
                Location = new Point(100, 100),
                Image = velement.GetImage(VisualElement.Elements.OTerm)
            };

            PictureBoxes.Add(e.GetHashCode(), pb);
            panel1.Controls.Add(pb);*/
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?\nThis will delete all the elements!"
                              , "Attention!"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Exclamation
                        ) == DialogResult.OK)
            {
                VisualElements.Clear();
                //OutputPorts.Clear();
                //Connections.Clear();
                PictureBoxes.Clear();

                panel1.Controls.Clear();
                graphics.Clear(panel1.BackColor);
            }
        }

        private void stopSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
