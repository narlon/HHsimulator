using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HHsimulator
{
    public partial class ItemView : Form
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public ItemView()
        {
            InitializeComponent();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            BackgroundImage = PicLoader.Read("Bg.t1.JPG");
            for (int i = 0; i < 17; i++)
            {
                ((Button)panel4.Controls["button" + (i + 1)]).BackgroundImage = PicLoader.Read(String.Format("Shop.{0}.JPG", i + 1));
            }
            LoadInfo("ÎäÆ÷ÉÌÈË");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadInfo(((Button)sender).Tag.ToString());
        }

        private void LoadInfo(String seller)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd = String.Format("SELECT * FROM [Item] where [Seller] = '{0}' order by [Order]", seller);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            int id = 1;
            while (dr.Read())
            {
                for (int i = id; i <= 12; i++)
                    ((ItemBox)(Controls["itembox" + i])).CClear();
                if (((ItemBox)(Controls["itembox" + id])).DName != dr[1].ToString())
                {
                    ((ItemBox)(Controls["itembox" + id])).Head = PicLoader.Read(String.Format("Items.C{0}.JPG", dr[0].ToString()));
                    ((ItemBox)(Controls["itembox" + id])).DName = dr[1].ToString();
                    ((ItemBox)(Controls["itembox" + id])).Effect = dr[2].ToString();
                    ((ItemBox)(Controls["itembox" + id])).Des = String.Format("{0,4:G}", dr[7].ToString());
                    if (dr[4].ToString() != "")
                    {
                        ((ItemBox)(Controls["itembox" + id])).D1 = PicLoader.Read(String.Format("Items.C{0}.JPG", dr[4].ToString()));
                        ((ItemBox)(Controls["itembox" + id])).Type[0] = int.Parse(dr[4].ToString());
                    }
                    if (dr[5].ToString() != "")
                    {
                        ((ItemBox)(Controls["itembox" + id])).D2 = PicLoader.Read(String.Format("Items.C{0}.JPG", dr[5].ToString()));
                        ((ItemBox)(Controls["itembox" + id])).Type[1] = int.Parse(dr[5].ToString());
                    }
                    if (dr[6].ToString() != "")
                    {
                        ((ItemBox)(Controls["itembox" + id])).D3 = PicLoader.Read(String.Format("Items.C{0}.JPG", dr[6].ToString()));
                        ((ItemBox)(Controls["itembox" + id])).Type[2] = int.Parse(dr[6].ToString());
                    }
                }
                id++;
            }
            conn.Close();
        }

        private void buttonother_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiParent.MdiChildren;
            Form p = this.MdiParent;
            foreach (Form cf in charr)
            {
                if (cf is DataView)
                    return;
                else
                    cf.Close();
            }
            DataView iv = new DataView();
            iv.MdiParent = p;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }
    }
}