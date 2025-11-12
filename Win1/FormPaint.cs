using Microsoft.VisualBasic.Devices;
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
    public partial class FormPaint : Form
    {
        public FormPaint()
        {
            InitializeComponent();
        }
        public bool Mouse = false;
        Pen pen = new Pen(Color.Black, 2);
        Point _startPoint = new Point();
        Point _endPoint = new Point();
        private void whitebtn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.;
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = false;
            Xlblb.Text = e.X.ToString();
            Ylblb.Text = e.Y.ToString();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse = true;
            Xlblbl.Text = e.X.ToString();
            Ylblbl.Text = e.Y.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            XLbl.Text = e.X.ToString();
            YLbl.Text = e.Y.ToString();
        }

        private void FormPaint_Load(object sender, EventArgs e)
        {

        }
    }
}
