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
    public partial class HeroView : Form
    {
        private int id;
        private int shop = 0;
        private int[] hid = { 21, 8, 49, 25, 32, 39, 46, 51, 53, 60, 66,
            41, 40, 12, 9, 56, 28, 33, 23, 55, 62, 68,
            4, 5, 20, 27, 35, 38, 48, 26, 57, 64, 70,
            14, 2, 24, 30, 37, 42, 44, 7, 54, 59, 65,
            22, 17, 13, 50, 29, 31, 6, 18, 3, 61, 67,
            1, 10, 19, 52, 34, 36, 43, 47, 58, 77, 69,
            11, 15, 16, 45, 71, 78, 0, 0 ,0 ,0 ,0,
            74, 73, 72, 0, 0, 0, 0, 0 ,0 ,0 ,0,
            76, 75, 63, 0, 0, 0, 0, 0 ,0 ,0 ,0};
        private int bstr, bagi, bint, bdef;
        private string batk;
        private int lv;
        private int sid;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public HeroView()
        {
            InitializeComponent();
        }

        private void HeroView_Load(object sender, EventArgs e)
        {
            BackgroundImage = PicLoader.Read("Bg.t1.JPG");
            for (int i = 0; i < 3; i++)
            {
                ((Button)panel4.Controls["buttons" + (i + 1)]).BackgroundImage = PicLoader.Read("Altar.1.JPG");
            }
            buttons8.BackgroundImage = PicLoader.Read("Altar.1.JPG");
            for (int i = 3; i < 6; i++)
            {
                ((Button)panel4.Controls["buttons" + (i + 1)]).BackgroundImage = PicLoader.Read("Altar.2.JPG");
            }
            buttons9.BackgroundImage = PicLoader.Read("Altar.2.JPG");
            ((Button)panel4.Controls["buttons7"]).BackgroundImage = PicLoader.Read("Altar.3.JPG");
            for (int i = 0; i < 11; i++)
            {
                ((Button)panel4.Controls["button" + (i + 1)]).BackgroundImage = PicLoader.Read(String.Format("Heros.{0}.JPG", hid[i]));
            }
            id = 21;
            LoadInfo();
        }

        private void LoadInfo() {
            lv = 1;
            labellv.Text = "Lv01";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd = String.Format("SELECT * FROM Hero where [ID] = {0}", id);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelid.Text = dr[0].ToString();
                labelname.Text = dr[1].ToString();
                labelstr.Text = dr[2].ToString();
                labelagi.Text = dr[3].ToString();
                labelint.Text = dr[4].ToString();
                bstr = int.Parse(labelstr.Text);
                bagi = int.Parse(labelagi.Text);
                bint = int.Parse(labelint.Text);
                bdef = int.Parse(dr[17].ToString());
                labelstrp.Text = dr[5].ToString();
                labelagip.Text = dr[6].ToString();
                labelintp.Text = dr[7].ToString();
                labelmhp.Text = dr[8].ToString();
                labelmmp.Text = dr[9].ToString();
                labelatk.Text = dr[10].ToString();
                batk = labelatk.Text;
                labeljob.Text = dr[11].ToString();
                pictureBoxsskill1.Image = PicLoader.Read(String.Format("SSkill.Attribute{0}.JPG", int.Parse(dr[12].ToString()) + 1));
                pictureBoxsskill2.Image = PicLoader.Read(String.Format("SSkill.Attribute{0}.JPG", int.Parse(dr[13].ToString()) + 1));
                pictureBoxsskill3.Image = PicLoader.Read(String.Format("SSkill.Attribute{0}.JPG", int.Parse(dr[14].ToString()) + 1));
                string[] skillname = new string[] {"攻击学","防御学","后勤学","启蒙学","外交学","冥想学"};
                ToolTip tooltip1 = new ToolTip();
                tooltip1.SetToolTip(pictureBoxsskill1, skillname[int.Parse(dr[12].ToString())]);
                ToolTip tooltip2 = new ToolTip();
                tooltip2.SetToolTip(pictureBoxsskill2, skillname[int.Parse(dr[13].ToString())]);
                ToolTip tooltip3 = new ToolTip();
                tooltip3.SetToolTip(pictureBoxsskill3, skillname[int.Parse(dr[14].ToString())]);
                labelSpd.Text = dr[15].ToString();
                labelRag.Text = dr[16].ToString();
                labeldef.Text = string.Format("{0:0.0}", double.Parse(dr[17].ToString()) + double.Parse(labelagi.Text) * 0.14 - 2);
            }
            dr.Close();

            strcmd = String.Format("SELECT TOP 4 * FROM Skill where [ID] >= {0} order by [ID]", (id - 1) * 4 + 1);
            cmd = new OleDbCommand(strcmd, conn);
            dr = cmd.ExecuteReader();
            int ex = 1;
            while (dr.Read())
            {
                (Controls["skillBox" + ex] as SkillBox).Hname = dr[1].ToString();
                (Controls["skillBox" + ex] as SkillBox).Hkey = dr[2].ToString();
                (Controls["skillBox" + ex] as SkillBox).Des = dr[5].ToString();
                (Controls["skillBox" + ex] as SkillBox).Id = (id - 1) * 4 + ex;
                ex++;
            }
            conn.Close();
 ////           pictureBoxskill1.BackgroundImage = PicLoader.Read(String.Format("Skill.s{0}.JPG", int.Parse(labelid.Text) * 4 - 3));
  //          pictureBoxskill2.BackgroundImage = PicLoader.Read(String.Format("Skill.s{0}.JPG", int.Parse(labelid.Text) * 4 - 2));
 //           pictureBoxskill3.BackgroundImage = PicLoader.Read(String.Format("Skill.s{0}.JPG", int.Parse(labelid.Text) * 4 - 1));
    //        pictureBoxskill4.BackgroundImage = PicLoader.Read(String.Format("Skill.s{0}.JPG", int.Parse(labelid.Text) * 4));
            pictureBoxhero.Image = PicLoader.Read(String.Format("Heros.{0}.JPG", int.Parse(labelid.Text)));
            ShowSkill(1);
            updateLog();
        }

        private void updateLog() {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd = String.Format("SELECT ID,Version,[Content] FROM Log where [Content] like '%{0}%' order by ID desc", labelname.Text);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            richTextBox2.Clear();
            string lv = "";
            int ip = 0;
            while (dr.Read())
            {
                if (lv != dr[1].ToString()) {
                    ip = richTextBox2.Text.Length;
                    richTextBox2.AppendText(dr[1].ToString() + "\n");
                    richTextBox2.Select(ip, richTextBox2.Text.Length - ip);
                    richTextBox2.SelectionColor = Color.Red;
                    lv = dr[1].ToString();
                }
                string des = dr[2].ToString();
                if (des.Substring(0, labelname.Text.Length + 3) == String.Format("<{0}>的", labelname.Text))
                {
                    des = des.Substring(labelname.Text.Length + 3);
                }
                richTextBox2.AppendText(des + "\n");
            }
            conn.Close();
        }

        private void updateInfo() {
            int al, ah;
            labelstr.Text = String.Format("{0}", (int)((double)bstr + double.Parse(labelstrp.Text) * (lv - 1)));
            labelagi.Text = String.Format("{0}", (int)((double)bagi + double.Parse(labelagip.Text) * (lv - 1)));
            labelint.Text = String.Format("{0}", (int)((double)bint + double.Parse(labelintp.Text) * (lv - 1)));
            labeldef.Text = String.Format("{0:0.0}", (double)bdef + double.Parse(labelagi.Text) * 0.14 - 2);
            string[] ak = batk.Split('-');
            if (labeljob.Text == "战士" || labeljob.Text == "护卫")
            {
                al = (int)(double.Parse(ak[0]) + double.Parse(labelstrp.Text) * (lv - 1));
                ah = (int)(double.Parse(ak[1]) + double.Parse(labelstrp.Text) * (lv - 1));
            }
            else if (labeljob.Text == "法师" || labeljob.Text == "贤者")
            {
                al = (int)(double.Parse(ak[0]) + double.Parse(labelintp.Text) * (lv - 1));
                ah = (int)(double.Parse(ak[1]) + double.Parse(labelintp.Text) * (lv - 1));
            }
            else
            {
                al = (int)(double.Parse(ak[0]) + double.Parse(labelagip.Text) * (lv - 1));
                ah = (int)(double.Parse(ak[1]) + double.Parse(labelagip.Text) * (lv - 1));
            }
            labelatk.Text = String.Format("{0}-{1}", al, ah);
            labelmhp.Text = String.Format("{0}",int.Parse(labelstr.Text) * 20 + 150);
            labelmmp.Text = String.Format("{0}", int.Parse(labelint.Text) * 12);
            if (lv >= 10)
                labellv.Text = string.Format("Lv{0}", lv);
            else
                labellv.Text = string.Format("Lv0{0}", lv);
        }

        private void ShowSkill(int id) {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            sid = (int.Parse(labelid.Text) - 1) * 4 + id;
            string strcmd = String.Format("SELECT * FROM Skill where [ID] = {0}", sid);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelSname.Text = dr[1].ToString();
                labelkey.Text = String.Format("快捷键:{0}", dr[2].ToString());
                richTextBox1.Clear();
                richTextBox1.AppendText(dr[5].ToString()+"\n");
                if (dr[3].ToString() != "")
                    richTextBox1.AppendText(String.Format("魔法消耗 {0}\n", dr[3].ToString()));
                if (dr[4].ToString() != "")
                    richTextBox1.AppendText(String.Format("冷却时间 {0}秒\n", dr[4].ToString()));
                for (int i = 0; i < 5; i++)
                {
                    if (dr[6 + i].ToString() != "")
                        richTextBox1.AppendText(String.Format("等级{0} - {1}\n", (i + 1).ToString(), dr[6 + i].ToString()));
                }
                gradeMaker1.Value = int.Parse(dr[11].ToString());
            }
            conn.Close();
            int ip = 0;
            if ((ip = richTextBox1.Text.IndexOf("冷却时间", ip)) != -1)
            {
                richTextBox1.Select(ip, 4);
                richTextBox1.SelectionColor = Color.LightGreen;
            }
            ip = 0;
            if ((ip = richTextBox1.Text.IndexOf("魔法消耗", ip)) != -1)
            {
                richTextBox1.Select(ip, 4);
                richTextBox1.SelectionColor = Color.LightBlue;
            }
            ip = 0;
            while ((ip = richTextBox1.Text.IndexOf("等级", ip)) != -1)
            {
                richTextBox1.Select(ip, 3);
                richTextBox1.SelectionColor = Color.Orange;
                ip++;
            }
            richTextBox1.Select(richTextBox1.Text.Length - 1, 0);
        }

        private void pictureBoxskill1_MouseEnter(object sender, EventArgs e)
        {
            int id = ((sender as SkillBox).Id % 4);
            if (id == 0) id = 4;
            ShowSkill(id);
            (sender as SkillBox).BackColor2 = Color.RoyalBlue;
        }

        private void pictureBoxskill1_MouseLeave(object sender, EventArgs e)
        {
            (sender as SkillBox).BackColor2 = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = hid[shop * 11 + int.Parse(((Button)sender).Name.Substring(6)) - 1];
            LoadInfo();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            shop = int.Parse(((Button)sender).Name.Substring(7)) - 1;
            for (int i = 0; i < 11; i++)
            {
                if (hid[shop * 11 + i] != 0)
                {
                    ((Button)panel4.Controls["button" + (i + 1)]).Show();
                    ((Button)panel4.Controls["button" + (i + 1)]).BackgroundImage = PicLoader.Read(String.Format("Heros.{0}.JPG", hid[shop * 11 + i]));
                }
                else
                    ((Button)panel4.Controls["button" + (i + 1)]).Hide();
            }
            id = hid[shop * 11];
            LoadInfo();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lv < 30)
            {
                lv++;
                updateInfo();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lv > 1)
            {
                lv--;
                updateInfo();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiParent.MdiChildren;
            Form p = this.MdiParent;
            foreach (Form cf in charr)
            {
                if (cf is IDataView)
                    return;
                else
                    cf.Close();
            }
            IDataView iv = new IDataView();
            iv.MdiParent = p;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void gradeMaker1_ValueChanged(int value)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            String strcmd = String.Format("update Skill set [Grade] = {0} where ID = {1}", value, sid);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}