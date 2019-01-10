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
            GUI.Visual.Element element_from, element_to;
            if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {
                element_from = GUI.elements[listBox1.SelectedIndex];
                element_to = GUI.elements[listBox2.SelectedIndex];
                byte pin_idx_from, pin_idx_to;
                pin_idx_from = (byte)inPinNum.Value;
                pin_idx_to = (byte)outPinNum.Value;
                try
                {
                    if (pin_idx_from >= element_from.LogicElement.GetNumberOfPins(PinSide.OUTPUT))
                        throw new NumberOfPinsOutOfRangeException($"Left element don't have output pin with index {pin_idx_from}.");
                    if (pin_idx_to >= element_to.LogicElement.GetNumberOfPins(PinSide.INPUT))
                        throw new NumberOfPinsOutOfRangeException($"Right element don't have input pin with index {pin_idx_to}.");

                    GUI.Visual.Connect(element_from.OutputPins[pin_idx_from], element_to.InputPins[pin_idx_to]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
