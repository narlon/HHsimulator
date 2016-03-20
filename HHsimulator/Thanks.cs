using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHsimulator
{
    public partial class Thanks : Form
    {
        public Thanks()
        {
            InitializeComponent();
        }

        private void Thanks_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = PicLoader.Read("Basic.logo.JPG");
            pictureBox2.Image = PicLoader.Read("Basic.high.JPG");
        }
    }
}