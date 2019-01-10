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
    public partial class EditPortDialog : Form
    {
        List<InTerminal> in_terminals = new List<InTerminal>();
        public EditPortDialog()
        {
            InitializeComponent();
            foreach (var elem in GUI.elements)
            {
                if (elem is GUI.Visual.InTerminal)
                {
                    InTerminal logic_terminal = elem.LogicElement as InTerminal;
                    if (logic_terminal != null)
                        in_terminals.Add(logic_terminal);
                        listBox1.Items.Add(elem.Identificator+ $" Value={logic_terminal.SimulationInputValue}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                in_terminals[listBox1.SelectedIndex].SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            }
            if (radioButton0.Checked)
            {
                in_terminals[listBox1.SelectedIndex].SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            }
            this.Close();
        }
    }
}
