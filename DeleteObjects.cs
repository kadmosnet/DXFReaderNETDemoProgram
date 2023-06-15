using System;
using System.Windows.Forms;

namespace DXFReaderNETDemoProgram
{
    public partial class DeleteObjects : Form
    {
        public DeleteObjects()
        {
            InitializeComponent();
        }

        private void DeleteEntities_Load(object sender, EventArgs e)
        {

        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = !listView1.Items[i].Checked;
            }
        }
    }
}
