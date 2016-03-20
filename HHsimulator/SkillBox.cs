using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace HHsimulator
{
    public partial class SkillBox : UserControl
    {
        private int id = 1;
        private Image head;
        private string des;
        private string hname;
        private string hkey;

        public string Hkey
        {
            get { return hkey; }
            set { hkey = value; }
        }
        public string Hname
        {
            get { return hname; }
            set { hname = value; }
        }
        public string Des
        {
            get { return des; }
            set { des = value; textBox1.Text = des;}
        }
        public int Id
        {
            get { return id; }
            set { id = value; head = PicLoader.Read(String.Format("Skill.s{0}.JPG", id)); Invalidate(); }
        }
        public Color BackColor2 {
            get { return BackColor; }
            set { BackColor = value; textBox1.BackColor = value; }
        }
        public SkillBox()
        {
            InitializeComponent();
        }

        private void SkillBox_Paint(object sender, PaintEventArgs e)
        {
            if (head != null)
            {
                e.Graphics.DrawImage(head, 3, 3, 50, 50);;
                e.Graphics.DrawString(hname, new System.Drawing.Font("ËÎÌå", 13, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.White), 55, 3);
                e.Graphics.DrawString(String.Format("¿ì½Ý¼ü:{0}", hkey), new System.Drawing.Font("ËÎÌå", 9, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Gold), 185, 8);
            }
        }
    }
}
