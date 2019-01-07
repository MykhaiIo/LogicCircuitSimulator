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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnitTest.TestCase_2AND();
            UnitTest.TestCase_2OR();
            UnitTest.TestCase_2XOR();
            UnitTest.TestCase_NOT();
            UnitTest.TestCase_AndGateSimulation();
        }
        private void DrawActiveLine(Graphics _g, PointF p1, PointF p2)
        {
            _g.DrawLine(Pens.Red, p1, p2);
        }

        private void DrawInactiveLine(Graphics _g, PointF p1, PointF p2)
        {
            _g.DrawLine(Pens.Black, p1, p2);
        }

        private void Draw2AND(Graphics _g, PointF p1, PointF p2)
        {
            Image img = new Bitmap("C:\\Users\\Michel\\Documents\\NURE\\PS\\LogicCircuitSimulator\\LogicCircuitSimulator\\Resources\\2AND.png");
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

        }
    }
}
