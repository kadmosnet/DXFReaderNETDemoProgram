using System;
using System.Windows.Forms;

namespace DXFReaderNETDemoProgram
{
#pragma warning disable IDE0016, IDE0017, IDE0018, IDE0032, IDE0028, IDE1006, IDE0044, IDE0059
    public partial class InquiryDialog : Form
    {
        public InquiryDialog()
        {
            InitializeComponent();
        }

        private void InquiryDialog_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                textBox1.Text = "";

            }

        }
    }
}
