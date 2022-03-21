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
    public partial class BlockSelector : Form
    {
        internal DXFReaderNET.DXFReaderNETControl DXFReaderNETControl;
        private bool toggleOrigin = false;
        private readonly char decimalSeparetor = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        public BlockSelector()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedItem != null)
            {
                ViewBlock(ComboBox1.Text);

            }

        }

        private void ViewBlock(string blockname)
        {
            dxfReaderNETControl1.NewDrawing();
            foreach (DXFReaderNET.Entities.EntityObject entity in DXFReaderNETControl.DXF.Blocks[blockname].Entities)
            {
                if (entity.Color.IsByBlock)
                {
                    entity.Color = AciColor.FromCadIndex(7);
                }
                dxfReaderNETControl1.DXF.AddEntity(entity);
            }
            dxfReaderNETControl1.Refresh();
            dxfReaderNETControl1.ZoomExtents();
        }

        private void BlockSelector_Shown(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedItem != null)
            {
                ViewBlock(ComboBox1.Text);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomExtents();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (toggleOrigin)
            {
                dxfReaderNETControl1.ClearDrawnElements();
                toggleOrigin = false;
            }
            else
            {
                
                if (ComboBox1.SelectedItem != null)
                {

                    Vector2 origin = DXFReaderNETControl.DXF.Blocks[ComboBox1.Text].Origin.ToVector2();
                    Vector2 urc = dxfReaderNETControl1.UpperRightCorner;
                    Vector2 llc = dxfReaderNETControl1.LowerLeftCorner;

                    double dist = urc.X - llc.X;


                    dxfReaderNETControl1.DrawLine(new Pen(Color.Red, 0), origin - new Vector2(dist, 0), origin + new Vector2(dist, 0), true);
                    dxfReaderNETControl1.DrawLine(new Pen(Color.Red, 0), origin - new Vector2(0, dist), origin + new Vector2(0, dist), true);
                    toggleOrigin = true;
                }
            }


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

        private void TextBoxScale_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BlockSelector_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
