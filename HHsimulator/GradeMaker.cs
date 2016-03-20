using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace HHsimulator
{
    public partial class GradeMaker : UserControl
    {
        private int value = 0;
        public delegate void ValueChangeHandler(int value);
        public event ValueChangeHandler ValueChanged;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; Invalidate(); }
        }
        public GradeMaker()
        {
            InitializeComponent();
        }

        private void GradeMaker_MouseClick(object sender, MouseEventArgs e)
        {
            if (value != 0)
                ValueChanged(value);
        }

        private void GradeMaker_Paint(object sender, PaintEventArgs e)
        {
            Font font = new System.Drawing.Font("Arial", 15, FontStyle.Bold);
            Brush b = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
            for (int i = 0; i < value; i++) {
                e.Graphics.DrawString("¡ï", font, b, i * 20F - 5, 0);
            }
            for (int i = value; i < 5; i++)
            {
                e.Graphics.DrawString("¡î", font, b, i * 20F - 5, 0);
            }
        }

        private void GradeMaker_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <= 20)
                value = 1;
            else if (e.X <= 40)
                value = 2;
            else if (e.X <= 60)
                value = 3;
            else if (e.X <= 80)
                value = 4;
            else
                value = 5;
            Invalidate();
        }
    }
}
