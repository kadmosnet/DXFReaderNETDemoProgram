using System;

using System.Windows.Forms;

namespace DXFReaderNETDemoProgram
{
    public partial class PenSelector : Form
    {


        public PenSelector()
        {
            InitializeComponent();
        }

        private readonly char decimalSeparetor = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        private void TextBoxRotation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == decimalSeparetor) && ((sender as TextBox).Text.IndexOf(decimalSeparetor) > -1))
            {
                e.Handled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedItem != null)
            {
                if (ComboBox1.SelectedItem.ToString() != "Dashed")
                {
                    labelDashLength.Enabled = false;
                    labelSkipLength.Enabled = false;

                    textBoxDashLength.Enabled = false;
                    textBoxSkipLength.Enabled = false;
                }
                else
                {
                    labelDashLength.Enabled = true;
                    labelSkipLength.Enabled = true;

                    textBoxDashLength.Enabled = true;
                    textBoxSkipLength.Enabled = true;
                }
            }
        }
    }
}
