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
    public partial class SystemView : Form
    {
        public SystemView()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            string s = listBox1.SelectedItem.ToString();
            switch (s) {
                case "Ӣ���س�": pictureBox1.Image = PicLoader.Read("Basic.talent.JPG"); break;
                case "Ӣ���س���": pictureBox1.Image = PicLoader.Read("Basic.talent2.JPG"); break;
                case "ľͰ��������": pictureBox1.Image = PicLoader.Read("Basic.stone.JPG"); break;
                case "��������": pictureBox1.Image = PicLoader.Read("Basic.spirit.JPG"); break;
                default: break;
            }
        }

        private void SystemView_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = PicLoader.Read("Basic.talent.JPG");
        }
    }
}