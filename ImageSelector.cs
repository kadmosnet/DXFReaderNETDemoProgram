using System;

using System.Windows.Forms;

namespace DXFReaderNETDemoProgram
{
#pragma warning disable IDE0016, IDE0017, IDE0018, IDE0032, IDE0028, IDE1006
    public partial class ImageSelector : Form
    {


        public ImageSelector()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {


            openFileDialog1.Filter = "Image files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp| JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";

            openFileDialog1.FileName = TextBoxFileName.Text;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBoxFileName.Text = openFileDialog1.FileName;

            }
        }
        private readonly char decimalSeparetor = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        private void TextBoxRotation_KeyPress(object sender, KeyPressEventArgs e)
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

        private void checkBoxEmbedImage_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxRotation.Enabled = !checkBoxEmbedImage.Checked;
            Label2.Enabled = !checkBoxEmbedImage.Checked;
        }
    }
}
