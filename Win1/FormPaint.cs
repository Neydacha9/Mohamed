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

        private class PointArray
        {
            private int index = 0;
            private Point[] points;
            public PointArray(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];

            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                else
                {
                    points[index] = new Point(x, y);
                    index++;
                }
            }
            public void Reset()
            {
                index = 0;
            }
            public int CountPoint()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;

            }
        }
        private bool ClampingMouse = false;
        Bitmap bitmap = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);

        private void whitebtn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void blackbtn_Click(object sender, EventArgs e)
        {
            pen.Color= Color.Black;
        }
    }
}
