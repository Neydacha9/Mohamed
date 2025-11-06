using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;            
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuStrit1_ItemClicked(object sender, EventArgs e)
        {

        }
        private void openTooStrip1_Item(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculate _frmtest = new FormCalculate();
            _frmtest.MdiParent = this;
            _frmtest.Show();
        }
    }
}
