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
    public partial class CreateConnectionDialog : Form
    {
        public CreateConnectionDialog()
        {
            InitializeComponent();

            foreach (var elem in GUI.elements)
            {
                listBox1.Items.Add(elem.Identificator);
                listBox2.Items.Add(elem.Identificator);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
