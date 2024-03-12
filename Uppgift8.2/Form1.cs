using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift8._2
{
    public partial class Form1 : Form
    {
        Color color = Color.FromArgb(0, 0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        public int getColor(string color)
        {
            if(color == "")
            {
                return 0;
            }
            else
            {
                return int.Parse(color);
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            int red = getColor(tbxRed.Text);
            int green = getColor(tbxGreen.Text);
            int blue = getColor(tbxBlue.Text);
            color = Color.FromArgb(red, green, blue);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush brush = new SolidBrush(color);

            g.FillRectangle(brush, 175, 150, 200, 100);
        }
    }
}
