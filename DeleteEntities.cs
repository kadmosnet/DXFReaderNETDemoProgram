using System;
using System.Windows.Forms;

namespace DXFReaderNETDemoProgram
{
    public partial class DeleteEntities : Form
    {
        public DeleteEntities()
        {
            InitializeComponent();
        }

        private void DeleteEntities_Load(object sender, EventArgs e)
        {

        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, !checkedListBox1.GetItemChecked(i));
            }
        }
    }
}
