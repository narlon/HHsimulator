using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace HHsimulator
{
    public partial class HItemBox : UserControl
    {
        private string race;

        public string Race
        {
            get { return race; }
            set { race = value; if(race!=null) CheckRace(); }
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
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }
        public String Des
        {
            get { return lbldes.Text; }
            set { lbldes.Text = value; }
        }
        public HItemBox()
        {
            InitializeComponent();
        }
        public void CClear() {
            pictureBoxhead.Image = null;
            for (int i = 1; i <= 9;i++ )
                (Controls["pictureBoxd" + i] as PictureBox).Image = null;
            pictureBoxd2.Image = null;
            pictureBoxd3.Image = null;
            pictureBoxd4.Image = null;
            pictureBoxd1.Cursor = Cursors.Hand;
            pictureBoxd2.Cursor = Cursors.Hand;
            pictureBoxd3.Cursor = Cursors.Hand;
            pictureBoxd4.Cursor = Cursors.Hand;
            lblname.Text = "";
            richTextBox1.Text = "";
            lbldes.Text = "";
        }

        private void CheckRace()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (race[i-1] == '1')
                {
                    (Controls["pictureBoxd" + i] as PictureBox).Image = PicLoader.Read(String.Format("AttrRace.R{0}.JPG", i));
                    (Controls["pictureBoxd" + i] as PictureBox).Show();
                }
                else {
                    (Controls["pictureBoxd" + i] as PictureBox).Image = null;
                    (Controls["pictureBoxd" + i] as PictureBox).Hide();
                }
            }
        }

        private void pictureBoxd1_MouseEnter(object sender, EventArgs e)
        {
            string[] types = new string[] { "Ò°ÊÞ", "ÍöÁé", "Áú", "Ä§Îï", "·ÉÐÐ", "»úÐµ", "À¥³æ", "Ö²Îï", "¶ñÄ§" };
            if (((PictureBox)sender).Image != null)
            {
                ToolTip tooltip1 = new ToolTip();
                tooltip1.SetToolTip((Control)sender, types[int.Parse(((Control)sender).Name.Substring(11, 1)) - 1]);
            }
            else
                ((Control)sender).Cursor = Cursors.Default;
        }

    }
}
