using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HHsimulator
{
    public partial class ItemBox : UserControl
    {
        private int[] type = new int[3];
        private ToolTip tooltip1 = new ToolTip();

        public int[] Type
        {
            get { return type; }
            set { type = value; }
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
        public Image D1
        {
            get { return pictureBoxd1.Image; }
            set { pictureBoxd1.Image = value; }
        }
        public Image D2
        {
            get { return pictureBoxd2.Image; }
            set { pictureBoxd2.Image = value; }
        }
        public Image D3
        {
            get { return pictureBoxd3.Image; }
            set { pictureBoxd3.Image = value; }
        }
        public ItemBox()
        {
            InitializeComponent();
            //tooltip1.BackColor = Color.Black;
            //tooltip1.ForeColor = Color.White;
        }
        public void CClear() {
            pictureBoxhead.Image = null;
            pictureBoxd1.Image = null;
            pictureBoxd2.Image = null;
            pictureBoxd3.Image = null;
            pictureBoxd1.Cursor = Cursors.Hand;
            pictureBoxd2.Cursor = Cursors.Hand;
            pictureBoxd3.Cursor = Cursors.Hand;
            lblname.Text = "";
            richTextBox1.Text = "";
            lbldes.Text = "";
        }

        private void pictureBoxd1_MouseEnter(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Image != null)
            {
                int tid = int.Parse(((Control)sender).Name.Substring(11, 1)) - 1;
                string content = "";
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
                conn.Open();
                string strcmd = String.Format("SELECT [Name],[Effect],[Seller] FROM [Item] where [ID] = {0}", type[tid]);
                OleDbCommand cmd = new OleDbCommand(strcmd, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    content = dr[0].ToString();
                    content = String.Format("{0}({1})\n{2}",dr[0].ToString(),dr[2].ToString(),dr[1].ToString());
                }
                conn.Close();
                tooltip1.SetToolTip((Control)sender, content);
                tooltip1.Active = true;
            }
            else
                ((Control)sender).Cursor = Cursors.Default;
        }

        private void pictureBoxd1_MouseLeave(object sender, EventArgs e)
        {
            tooltip1.Active = false;
        }
    }
}
