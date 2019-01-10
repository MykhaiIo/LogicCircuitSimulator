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
            GUI.g_graphics = panel1.CreateGraphics();
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
            GUI.g_graphics = panel1.CreateGraphics();
            int w = panel1.Width;
            int h = panel1.Height;
            Pen blackpen = new Pen(Color.Black)
            {
                Width = 2
            };
            
            Brush whitebrush = new SolidBrush(Color.White);
            GUI.g_graphics.DrawRectangle(blackpen, 0, 0, w, h);
            blackpen.Dispose();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private bool MouseDownOnSelectedPicBox = false;
        private Point MouseDownLocation;

        private bool Connecting = false;
        private int SendingControlTag;
        private int ReceiveingControlTag;      

        private void bNext_Click(object sender, EventArgs e)
        {
            GUI.g_circuit.NextMoment();
            Invalidate();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            GUI.g_circuit.SimulateFor(100);
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
            var VisAND = new GUI.Visual.AND();
            GUI.AddElement(VisAND);
            var pb = VisAND.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
            var VisNAND = new GUI.Visual.NAND();
            GUI.AddElement(VisNAND);
            var pb = VisNAND.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bOr_Click(object sender, EventArgs e)
        {
            var VisOR = new GUI.Visual.OR();
            GUI.AddElement(VisOR);
            var pb = VisOR.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bNor_Click(object sender, EventArgs e)
        {
            var VisNOR = new GUI.Visual.NOR();
            GUI.AddElement(VisNOR);
            var pb = VisNOR.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bXor_Click(object sender, EventArgs e)
        {
            var VisXOR = new GUI.Visual.XOR();
            GUI.AddElement(VisXOR);
            var pb = VisXOR.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bXnor_Click(object sender, EventArgs e)
        {
            var VisXNOR = new GUI.Visual.XNOR();
            GUI.AddElement(VisXNOR);
            var pb = VisXNOR.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bBuf_Click(object sender, EventArgs e)
        {
            var VisBUF = new GUI.Visual.BUF();
            GUI.AddElement(VisBUF);
            var pb = VisBUF.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bInv_Click(object sender, EventArgs e)
        {
            var VisNOT = new GUI.Visual.NOT();
            GUI.AddElement(VisNOT);
            var pb = VisNOT.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bInPort_Click(object sender, EventArgs e)
        {
            var VisInTerm = new GUI.Visual.InTerminal();
            GUI.AddElement(VisInTerm);
            var pb = VisInTerm.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bOutPort_Click(object sender, EventArgs e)
        {
            var VisInTerm = new GUI.Visual.OutTerminal();
            GUI.AddElement(VisInTerm);
            var pb = VisInTerm.PictureBox;
            if (pb != null)
            {
                panel1.Controls.Add(pb);
            }
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
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?\nThis will delete all the elements!"
                              , "Attention!"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Exclamation
                        ) == DialogResult.OK)
            {
                panel1.Controls.Clear();
                GUI.elements.Clear();
                GUI.visual_connections.Clear();
            }
        }

        private void stopSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm2 = new CreateConnectionDialog();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //textBox1.Text = frm2.getText();
                frm2.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new EditPortDialog();
            DialogResult dr = dlg.ShowDialog(this);
            if (dr == DialogResult.OK)
                dlg.Close();
        }
    }
}
