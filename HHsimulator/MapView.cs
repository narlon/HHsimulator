using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HHsimulator
{
    public partial class MapView : Form
    {
        private bool IsFlash = false;

        delegate void SetLabelCallback();
        private Thread myThread = null;

        public MapView()
        {
            InitializeComponent();
        }

        private void MapView_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = PicLoader.Read("Basic.map.JPG");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            if (listBox1.SelectedItem == null)
                return;
            string s = listBox1.SelectedItem.ToString();
            switch (s) {
                case "水精灵的河入口": x = 880; y = 510; break;
                case "风精灵的空洞入口": x = 640; y = 250; break;
                case "火精灵的溶洞入口": x = 300; y = 120; break;
                case "地精灵的地下洞穴入口": x = 570; y = 155; break;
                case "冰精灵的冰山入口": x = 565; y = 375; break;
                case "雷精灵的遗迹入口": x = 620; y = 480; break;
                case "光与暗之街道入口": x = 650; y = 310; break;
                case "恶魔之门入口": x = 465; y = 185; break;
                case "隐藏商店1": x = 525; y = 155; break;
                case "隐藏商店2": x = 720; y = 480; break;
                case "村民位置": x = 940; y = 347; break;
                case "野外商人": x = 873; y = 567; break;
                default: break;
            }

            label2.Location = new Point(202, y);
            label3.Location = new Point(x, 7);
            label1.Location = new Point(x - 4, y - 4);
            if (!IsFlash) {
                IsFlash = true;
                label1.Show();
                label2.Show();
                label3.Show();
                myThread = new Thread(new ThreadStart(FlashLabel));
                myThread.Start();
            }
        }

        private void FlashLabel()
        {
            while (IsFlash)
            {
                Thread.Sleep(150);
                SetLabel();
            }
        }
        private void SetLabel()
        {
            if (label1.InvokeRequired)
            {
                SetLabelCallback d = new SetLabelCallback(SetLabel);
                this.Invoke(d, new object[] { });
            }
            else
            {
                if ((label1.BackColor.R % 10) == 0)
                {
                    label1.BackColor = Color.FromArgb(label1.BackColor.R + 40, 255, 255 - label1.BackColor.R);
                    if (label1.BackColor.R == 240)
                        label1.BackColor = Color.FromArgb(255, 255, 0);
                }
                else
                {
                    label1.BackColor = Color.FromArgb(label1.BackColor.R - 40, 255, 255 - label1.BackColor.R);
                    if (label1.BackColor.R == 15)
                        label1.BackColor = Color.FromArgb(0, 255, 255);
                }
            }
        }

        private void MapView_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsFlash = false;
            if (myThread != null && myThread.IsAlive)
                myThread.Abort();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (checkBox1.Checked)
            {
                Pen myPen = new Pen(Color.Goldenrod,3);
                e.Graphics.DrawEllipse(myPen, 237, 145, 15, 15);
                e.Graphics.DrawEllipse(myPen, 414, 300, 15, 15);
                e.Graphics.DrawEllipse(myPen, 535, 450, 15, 15);
                myPen.Dispose();
            }

            if (checkBox2.Checked)
            {
                SolidBrush mybrush = new SolidBrush(Color.Red);
                e.Graphics.FillEllipse(mybrush, 290, 95, 14, 14);
                e.Graphics.FillEllipse(mybrush, 305, 320, 14, 14);
                e.Graphics.FillEllipse(mybrush, 455, 500, 14, 14);
                e.Graphics.FillEllipse(mybrush, 496, 260, 14, 14);
                mybrush.Dispose();
                mybrush = new SolidBrush(Color.Yellow);
                e.Graphics.FillEllipse(mybrush, 195, 155, 13, 13);
                e.Graphics.FillEllipse(mybrush, 350, 519, 13, 13);
                e.Graphics.FillEllipse(mybrush, 422, 85, 13, 13);
                e.Graphics.FillEllipse(mybrush, 575, 460, 13, 13);
                mybrush.Dispose();
                mybrush = new SolidBrush(Color.Lime);
                e.Graphics.FillEllipse(mybrush, 195, 270, 12, 12);
                e.Graphics.FillEllipse(mybrush, 277, 395, 12, 12);
                e.Graphics.FillEllipse(mybrush, 480, 193, 12, 12);
                e.Graphics.FillEllipse(mybrush, 598, 344, 12, 12);
                mybrush.Dispose();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
}