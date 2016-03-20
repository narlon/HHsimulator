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
    public partial class BossView : Form
    {
        private int id;
        private int[] type = new int[4] { 0, 0, 0, 0 };
        private ToolTip tooltip1 = new ToolTip();

        public BossView()
        {
            InitializeComponent();
        }

        private void BossView_Load(object sender, EventArgs e)
        {
            BackgroundImage = PicLoader.Read("Bg.t1.JPG");
            for (int i = 0; i < 8; i++)
            {
                ((Button)panel4.Controls["button" + (i + 1)]).BackgroundImage = PicLoader.Read(String.Format("Boss.{0}.JPG", i + 1));
            }
            id = 1;
            LoadInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = int.Parse(((Button)sender).Name.Substring(6));
            LoadInfo();
        }

        private void LoadInfo()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd = String.Format("SELECT * from Boss where [ID] = {0}", id);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelname.Text = dr[1].ToString();
                textBoxHis.Text = dr[2].ToString();
                labelatk.Text = dr[4].ToString();
                labeldef.Text = dr[3].ToString();
                labelmhp.Text = dr[5].ToString();
                labelmmp.Text = dr[6].ToString();
                labelAts.Text = dr[7].ToString();
                labelSpd.Text = dr[8].ToString();
                labelRag.Text = dr[9].ToString();
                labelReg.Text = dr[10].ToString();
                labelGiv.Text = dr[11].ToString();
                for (int i = 0; i < 4; i++) {
                    type[i] = int.Parse(dr[12 + i * 2].ToString());
                    ((PictureBox)(panel5.Controls["pictureBox" + (i + 1)])).Image = PicLoader.Read(String.Format("Items.C{0}.JPG", dr[12 + i * 2].ToString()));
                    ((Label)(panel5.Controls["labelp" + (i + 1)])).Text = string.Format("{0}%", double.Parse(dr[13 + i * 2].ToString())*100);
                }
            }
            strcmd = String.Format("SELECT * from MSkill where [Group] = '{0}'", labelname.Text);
            cmd = new OleDbCommand(strcmd, conn);
            dr = cmd.ExecuteReader();
            richTextBox1.Clear();
            while (dr.Read())
            {
                int ip;
                int ip2;
                ip = richTextBox1.Text.Length;
                richTextBox1.AppendText(String.Format("{0} ", dr[1].ToString()));
                ip2 = richTextBox1.Text.Length;
                richTextBox1.Select(ip, ip2 - ip - 1);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText(String.Format("{0}\n", dr[3].ToString()));
            }
            conn.Close();

            pictureBoxhero.Image = PicLoader.Read(String.Format("Boss.{0}.JPG", id));
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Image != null)
            {
                int tid = int.Parse(((Control)sender).Name.Substring(10, 1)) - 1;
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
                    content = String.Format("{0}({1})\n{2}", dr[0].ToString(), dr[2].ToString(), dr[1].ToString());
                }
                conn.Close();

                tooltip1.SetToolTip((Control)sender, content);
                tooltip1.Active = true;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            tooltip1.Active = false;
        }
    }
}