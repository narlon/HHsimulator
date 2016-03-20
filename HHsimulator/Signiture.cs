using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace HHsimulator
{
    public partial class Signiture : Form
    {
        private String str, agi, intp, name;

        public Signiture()
        {
            InitializeComponent();
        }

        private void Signiture_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.Hero”中。您可以根据需要移动或移除它。
            this.heroTableAdapter.Fill(this.dataDataSet.Hero);
            comboBox2_SelectedIndexChanged(null, e);
            comboBox1.SelectedIndex = 0;
        }
        private void LoadInfo() {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd = String.Format("SELECT * FROM Hero where [ID] = {0}", int.Parse(comboBox2.SelectedValue.ToString()));
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                str = dr[2].ToString();
                agi = dr[3].ToString();
                intp = dr[4].ToString();
                name = dr[1].ToString();
            }
            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                int id = int.Parse(comboBox2.SelectedValue.ToString());
                pictureBox2.Image = PicLoader.Read(String.Format("Skill.s{0}.JPG", id * 4 - 3));
                pictureBox3.Image = PicLoader.Read(String.Format("Skill.s{0}.JPG", id * 4 - 2));
                pictureBox4.Image = PicLoader.Read(String.Format("Skill.s{0}.JPG", id * 4 - 1));
                pictureBox5.Image = PicLoader.Read(String.Format("Skill.s{0}.JPG", id * 4));
                pictureBox12.Image = PicLoader.Read(String.Format("Skill.s{0}.JPG", id * 4 - 3));
                pictureBox11.Image = PicLoader.Read(String.Format("Skill.s{0}.JPG", id * 4 - 2));
                pictureBox10.Image = PicLoader.Read(String.Format("Skill.s{0}.JPG", id * 4 - 1));
                pictureBox9.Image = PicLoader.Read(String.Format("Skill.s{0}.JPG", id * 4));
                pictureBox6.Image = PicLoader.Read(String.Format("Heros.{0}.JPG", id));
                pictureBox8.Image = PicLoader.Read(String.Format("Heros.{0}.JPG", id));
                LoadInfo();
                pictureBox7.Invalidate();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                pictureBox1.Image = PicLoader.Read(String.Format("SigBack.{0}.JPG", comboBox1.SelectedIndex + 1));
                pictureBox7.Image = PicLoader.Read(String.Format("SigBack.{0}.JPG", comboBox1.SelectedIndex + 1));
            }
        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            int[] x = { 0, 27, 20, 12, 8 };
            try
            {
                e.Graphics.DrawString("Strength", new System.Drawing.Font("Arial", 10, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Red), 85, 10);
                e.Graphics.DrawString(str, new System.Drawing.Font("Arial", 10, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Red), 185, 10);
                e.Graphics.DrawString("Agility", new System.Drawing.Font("Arial", 10, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Lime), 85, 25);
                e.Graphics.DrawString(agi, new System.Drawing.Font("Arial", 10, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Lime), 185, 25);
                e.Graphics.DrawString("Intelligence", new System.Drawing.Font("Arial", 10, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.LightBlue), 85, 40);
                e.Graphics.DrawString(intp, new System.Drawing.Font("Arial", 10, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.LightBlue), 185, 40);
                e.Graphics.DrawString(name, new System.Drawing.Font("楷体_GB2312", 10, FontStyle.Bold), new System.Drawing.SolidBrush(System.Drawing.Color.Black), x[name.Length - 1], 80);
            }
            catch(Exception es){
                es.ToString();
            }

        }
    }
}