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
            UnitTest.TestCase_Nand_Nor_GatesSimulation();
            UnitTest.TestCase_Xnor_Xor_GatesSimulation();
            UnitTest.TestCase_Fork_3Not_And_GatesSimulation();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
