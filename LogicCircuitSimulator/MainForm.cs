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
            Graphics g = e.Graphics;
            int w = panel1.Width;
            int h = panel1.Height;
            Pen blackpen = new Pen(Color.Black)
            {
                Width = 2
            };
            Brush whitebrush = new SolidBrush(Color.White);
            g.DrawRectangle(blackpen, 220, 50, w, h);
            //g.FillRectangle(whitebrush, 220, 50, w, h);
            //whitebrush.Dispose();
            blackpen.Dispose();
            g.Dispose();
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
            GUI.ConnectableImages.AND2 and2_image_data = new GUI.ConnectableImages.AND2();
            PictureBox pb = new PictureBox
            {
                Name = "And",
                Location = new Point(100, 100),
                Image = and2_image_data.Image

            };
            //pb.Paint += PicBox_Paint;
            pb.MouseEnter += PicBox_MouseEnter;
            pb.MouseLeave += PicBox_MouseLeave;
            pb.MouseDown += PicBox_MouseDown;
            pb.MouseUp += PicBox_MouseUp;
            pb.MouseMove += PicBox_MouseMove;
            pb.Move += PicPox_Move;
            //pb.ContextMenuStrip = ContextMenu;

            if (pb.Left < panel1.Left)
                pb.Left = panel1.Left;
            if (pb.Right > panel1.Right)
                pb.Left = (panel1.Right + pb.Width);
            if (pb.Top < panel1.Top)
                pb.Top = panel1.Top;
            if (pb.Bottom > panel1.Bottom)
                pb.Top = (panel1.Bottom + pb.Height);

            if (pb != null)
            {
                PictureBoxes.Add(e.GetHashCode(), pb);
                panel1.Controls.Add(pb);
            }
        }



        private void PicPox_Move(object sender, EventArgs e)
        {
            //int _senderTag = (int)(((PictureBox)sender).Tag);
                panel1.Invalidate();
        }

        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left
            && MouseDownOnSelectedPicBox
            )
            {
                ((PictureBox)sender).Cursor = Cursors.SizeAll;
                ((PictureBox)sender).Left = e.X + ((PictureBox)sender).Left - MouseDownLocation.X;
                ((PictureBox)sender).Top = e.Y + ((PictureBox)sender).Top - MouseDownLocation.Y;
            }
        }

        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {
            if ((sender as PictureBox).Cursor != Cursors.Default)
                (sender as PictureBox).Cursor = Cursors.Default;

            MouseDownOnSelectedPicBox = false;
        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownOnSelectedPicBox = true;

                MouseDownLocation = e.Location;
            }
        }

        private void PicBox_MouseLeave(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control && Connecting)
            {
                ReceiveingControlTag = -1;
            }
        }

        private void PicBox_MouseEnter(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control && Connecting)
            {
                ReceiveingControlTag = (int)(((Control)sender).Tag);
            }
        }

        //private void PicBox_Paint(object sender, PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //}

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
