using System;

using System.Windows.Forms;


namespace DXFReaderNETDemoProgram
{
#pragma warning disable IDE0016, IDE0017, IDE0018, IDE0032, IDE0028, IDE1006
    public partial class InputDialog : Form
    {
        internal bool ForceNumeric;
        public InputDialog()
        {
            InitializeComponent();

        }
        private readonly char decimalSeparetor = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ForceNumeric)
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor) && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == decimalSeparetor) && ((sender as TextBox).Text.IndexOf(decimalSeparetor) > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {

        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            if (ForceNumeric)
            {
                textBox1.MaxLength = 10;
            }
        }
    }
}
