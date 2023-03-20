using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editor_paint_rrc
{
    public partial class PaintForm : Form
    {
        private Point lastPoint;
        private bool isMouseDown = false;
        public PaintForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.White;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Graphics g = panel1.CreateGraphics();
                Pen pen = new Pen(panel1.BackColor, 5);
                g.DrawLine(pen, lastPoint, e.Location);
                lastPoint = e.Location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void PaintForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
        }

    }
}
