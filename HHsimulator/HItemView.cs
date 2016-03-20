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
    public partial class HItemView : Form
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public HItemView()
        {
            InitializeComponent();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            BackgroundImage = PicLoader.Read("Bg.t1.JPG");
            LoadInfo("¹¥»÷");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CClear();
            LoadInfo((sender as Button).Tag.ToString());
        }

        private void CClear() {
            for (int i = 1; i <= 12; i++)
                ((HItemBox)(Controls["hItembox" + i])).CClear();
        }
        private void LoadInfo(string type)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd = String.Format("SELECT * FROM [HItem] where [Type] = '{0}' order by [ID]", type);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            int id = 1;
            while (dr.Read())
            {
                ((HItemBox)(Controls["hItemBox" + id])).Head = PicLoader.Read(String.Format("HItems.I{0}.JPG", dr[0].ToString())); 
                ((HItemBox)(Controls["hItemBox" + id])).DName = dr[1].ToString();
                ((HItemBox)(Controls["hItemBox" + id])).Effect = dr[2].ToString();
                ((HItemBox)(Controls["hItemBox" + id])).Des = String.Format("Ä§Á¦({0})", dr[4].ToString());
                ((HItemBox)(Controls["hItemBox" + id])).Race = dr[3].ToString();
                id++;
            }
            conn.Close();
        }


    }
}