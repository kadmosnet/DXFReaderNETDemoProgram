using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using DXFReaderNET;

namespace DXFReaderNETDemoProgram
{
#pragma warning disable IDE0016, IDE0017, IDE0018, IDE0032, IDE0028, IDE1006
    public partial class GradientSelector : Form
    {
        public GradientSelector()
        {
            InitializeComponent();
        }
        private readonly char decimalSeparetor = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedItem != null)
            {
                try
                {
                    PictureBox1.Image = ImageList1.Images[ImageList1.Images.Keys.IndexOf(ComboBox1.SelectedItem + ".png")];
                }
                catch
                {
                    PictureBox1.Image = null;
                }
            }

        }

        private void buttonColor1_Click(object sender, EventArgs e)
        {
            AciColor color = AciColor.FromCadIndex((short)buttonColor1.Tag);


            Form1 mainForm=new Form1(); 

            color = mainForm.dxfReaderNETControl1.ShowPalette(color);
            buttonColor1.BackColor = color.ToColor();
            buttonColor1.Tag = color.Index;
        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {


            AciColor color = AciColor.FromCadIndex((short)buttonColor2.Tag);

            Form1 mainForm = new Form1();

            color = mainForm.dxfReaderNETControl1.ShowPalette(color);
            buttonColor2.BackColor = color.ToColor();
            buttonColor2.Tag = color.Index;
        }

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

        private void ButtonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
