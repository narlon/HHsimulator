using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace HHsimulator
{
    public partial class TalentSkillBox : UserControl
    {
        private int state;
        private int str;
        private int agi;
        private int intp;
        private int str2;
        private int agi2;
        private int intp2;
        private int a;
        private int b;
        private int c;
        private string effect;
        private string effect2;
        public int Str
        {
            get { return str; }
            set { str = value; }
        }
        public int Str2
        {
            get { return str2; }
            set { str2 = value; }
        }
        public int Agi
        {
            get { return agi; }
            set { agi = value; }
        }
        public int Agi2
        {
            get { return agi2; }
            set { agi2 = value; }
        }
        public int Intp
        {
            get { return intp; }
            set { intp = value; }
        }
        public int Intp2
        {
            get { return intp2; }
            set { intp2 = value; }
        }
        public Image Head {
            get { return pictureBoxhead.Image; }
            set { pictureBoxhead.Image = value; }
        }
        public String DName
        {
            get { return lblname.Text; }
            set { lblname.Text = value; }
        }
        public String Effect
        {
            get { return effect; }
            set { effect = value; }
        }
        public String Effect2
        {
            get { return effect2; }
            set { effect2 = value; }
        }
        public TalentSkillBox()
        {
            InitializeComponent();
            state = 0;
        }
        public void CClear() {
            pictureBoxhead.Image = null;
            a = 0;
            b = 0;
            c = 0;
            lblname.Text = "";
            richTextBox1.Text = "";
            Invalidate();
        }
        public void SetChart(int a,int b,int c,string eff) {
            this.a = a;
            this.b = b;
            this.c = c;
            richTextBox1.Text = eff;
            Invalidate();
        }

        private void TalentSkillBox_Paint(object sender, PaintEventArgs e)
        {
            if (DName != "")
            {
                e.Graphics.DrawString(String.Format("决 {0}", a), new System.Drawing.Font("Arial", 9, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Red), 80, 26);
                e.Graphics.DrawString(String.Format("协 {0}", b), new System.Drawing.Font("Arial", 9, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Green), 80, 38);
                e.Graphics.DrawString(String.Format("辨 {0}", c), new System.Drawing.Font("Arial", 9, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Blue), 80, 50);
                e.Graphics.FillRectangle(Brushes.Red, 115, 30, 4 * a, 6);
                e.Graphics.FillRectangle(Brushes.Green, 115, 42, 4 * b, 6);
                e.Graphics.FillRectangle(Brushes.Blue, 115, 54, 4 * c, 6);
            }
        }

        private void pictureBoxhead_Click(object sender, EventArgs e)
        {
            if (state == 0 && effect2 != "")
            {
                state = 1;
                SetChart(str2, agi2, intp2, effect2);
            }
            else if (state == 1) {
                state = 0;
                SetChart(str, agi, intp, effect);         
            }
        }

        private void pictureBoxhead_MouseEnter(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Image != null && effect2 != "")
            {
                ((Control)sender).Cursor = Cursors.Hand;
                ToolTip tooltip1 = new ToolTip();
                tooltip1.SetToolTip((Control)sender, "点击切换等级");
            }
            else
            {
                ((Control)sender).Cursor = Cursors.Default;
            }
        }
    }
}
