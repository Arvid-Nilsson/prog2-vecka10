using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning8._2
{
    public partial class Form1 : Form
    {
        bool on = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color röd = Color.Red;
            Color grön = Color.Green;

            SolidBrush brush = new SolidBrush(Color.Black);

            g.FillRectangle(brush, 80, 80, 150, 200);


            if(on == true)
            {
                brush.Color = grön;
                g.FillEllipse(brush, 115, 190, 80, 80);
            }
            else
            {
                brush.Color = röd;
                g.FillEllipse(brush, 115, 100, 80, 80);
            }
            

            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(on == true)
            {
                on = false;
            }
            else
            {
                on = true;
            }
            Invalidate();
        }
    }
}
