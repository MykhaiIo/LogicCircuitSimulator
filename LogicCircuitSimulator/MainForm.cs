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



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnitTest.TestCase_2AND();
            UnitTest.TestCase_2OR();
            UnitTest.TestCase_2XOR();
            UnitTest.TestCase_NOT();
            UnitTest.TestCase_AndGateSimulation();
            UnitTest.TestCase_Nand_Nor_GatesSimulation();
            UnitTest.TestCase_Xnor_Xor_GatesSimulation();
            UnitTest.TestCase_Fork_3Not_And_GatesSimulation();
        }

        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            xPos.Text = "X: " + e.Location.X;
            yPos.Text = "Y: " + e.Location.Y;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int w = this.panel1.Width;
            int h = this.panel1.Height;
            Pen blackpen = new Pen(Color.Black);
            blackpen.Width = 2;
            g.DrawRectangle(blackpen, 220, 50, w, h);
            blackpen.Dispose();
            g.Dispose();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private Circuit Circuit;
        private Graphics graphics;

        private Dictionary<int, VisualElement> VisualElements; //Key = Element ID
        private Dictionary<int, PictureBox> PictureBoxes;      //Key = Element ID
        private List<Tuple<VisualElement, VisualElement>> Connections; // A -> B

        private GraphicElements.Elements DragdropElem;
        private bool MouseDownOnSelectedPicBox = false;
        private Point MouseDownLocation;

        private bool Connecting = false;
        private int SendingControlTag;
        private int ReceiveingControlTag;      

        private void bNext_Click(object sender, EventArgs e)
        {

        }

        private void bStart_Click(object sender, EventArgs e)
        {

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

        }

        private void bClear_Click(object sender, EventArgs e)
        {

        }

        private void stopSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopSimulationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
