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
        public EditPortDialog()
        {
            InitializeComponent();
            foreach (var elem in GUI.elements)
            {
                listBox1.Items.Add(elem.Identificator);
            }
        }
    }
}
