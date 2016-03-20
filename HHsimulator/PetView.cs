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
    public partial class PetView : Form
    {
        private int[] p;
        public PetView()
        {
            InitializeComponent();
        }

        private void PetView_Load(object sender, EventArgs e)
        {
            BackgroundImage = PicLoader.Read("Bg.t1.JPG");
            p = new int[8];
            for (int i = 0; i < 10; i++)
            {
                ((Button)panel4.Controls["buttons" + (i + 1)]).BackgroundImage = PicLoader.Read(String.Format("AttrRace.A{0}.JPG", i + 1));
            }
            ShowElement(0);
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            int shop = int.Parse(((Button)sender).Name.Substring(7)) - 1;
            ShowElement(shop);
        }

        private void ShowElement(int shop) {
            for (int i = 0; i < 8; i++)
                p[i] = 0;
            switch (shop)
            {
                case 0: p[0] = 33; p[1] = 34; p[2] = 35; p[3] = 36; p[4] = 37; p[5] = 52; p[6] = 47; p[7] = 53; break;
                case 1: p[0] = 29; p[1] = 30; p[2] = 31; p[3] = 32; p[4] = 46; p[5] = 57; break;
                case 2: p[0] = 13; p[1] = 14; p[2] = 15; p[3] = 16; p[4] = 38; p[5] = 45; break;
                case 3: p[0] = 21; p[1] = 22; p[2] = 23; p[3] = 24; p[4] = 43; p[5] = 55; break;
                case 4: p[0] = 9; p[1] = 10; p[2] = 11; p[3] = 12; p[4] = 39; p[5] = 48; break;
                case 5: p[0] = 5; p[1] = 6; p[2] = 7; p[3] = 8; p[4] = 40; p[5] = 56; break;
                case 6: p[0] = 25; p[1] = 26; p[2] = 27; p[3] = 28; p[4] = 44; p[5] = 58; break;
                case 7: p[0] = 17; p[1] = 18; p[2] = 19; p[3] = 20; p[4] = 41; p[5] = 49; break;
                case 8: p[0] = 1; p[1] = 2; p[2] = 3; p[3] = 4; p[4] = 42; p[5] = 54; break;
                case 9: p[0] = 50; p[1] = 51; p[2] = 59; break;
                default: break;
            }
            for (int i = 0; i < 8; i++)
            {
                if (p[i] != 0)
                {
                    ((Button)panel4.Controls["button" + (i + 1)]).Show();
                    ((Button)panel4.Controls["button" + (i + 1)]).BackgroundImage = PicLoader.Read(String.Format("Pet.{0}.JPG", p[i]));
                }
                else
                    ((Button)panel4.Controls["button" + (i + 1)]).Hide();
            }
            ShowPet(p[0]);
        }

        private void ShowPet(int id)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd = String.Format("SELECT * FROM Pet where [ID] = {0}", id);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labelname.Text = dr[1].ToString();
                labelatk.Text = dr[7].ToString();
                labelmhp.Text = dr[8].ToString();
                labelRag.Text = dr[9].ToString();
                labeldef.Text = dr[10].ToString();
                labelSpd.Text = dr[11].ToString();
                labelAts.Text = dr[12].ToString();
                labeldps.Text = String.Format("{0:0.0}", double.Parse(dr[14].ToString()));
                labelReg.Text = dr[6].ToString();
                textBoxHis.Text = dr[15].ToString();
                int aid = 0;
                switch (dr[4].ToString()) {
                    case "ÎÞ": aid = 1; break;
                    case "Ë®": aid = 2; break;
                    case "·ç": aid = 3; break;
                    case "»ð": aid = 4; break;
                    case "µØ": aid = 5; break;
                    case "±ù": aid = 6; break;
                    case "À×": aid = 7; break;
                    case "¹â": aid = 8; break;
                    case "°µ": aid = 9; break;
                    case "»Ã": aid = 10; break;
                    default: aid = 0; break;
                }
                pictureBox1.Image = PicLoader.Read(String.Format("AttrRace.A{0}.JPG", aid));
                ToolTip tooltip1 = new ToolTip();
                tooltip1.SetToolTip(pictureBox1, dr[4].ToString() + "ÊôÐÔ");
                switch (dr[5].ToString())
                {
                    case "Ò°ÊÞ": aid = 1; break;
                    case "ÍöÁé": aid = 2; break;
                    case "Áú": aid = 3; break;
                    case "Ä§Îï": aid = 4; break;
                    case "·ÉÐÐ": aid = 5; break;
                    case "»úÐµ": aid = 6; break;
                    case "À¥³æ": aid = 7; break;
                    case "Ö²Îï": aid = 8; break;
                    case "¶ñÄ§": aid = 9; break;
                    default: aid = 0; break;
                }
                pictureBox2.Image = PicLoader.Read(String.Format("AttrRace.R{0}.JPG", aid));
                ToolTip tooltip2 = new ToolTip();
                tooltip2.SetToolTip(pictureBox2, dr[5].ToString());
                pictureBoxhero.Image = PicLoader.Read(String.Format("Pet.{0}.JPG", id));
                labelre1.Text = "";
                if (dr[2].ToString() != "")
                {
                    labelre1.Text = String.Format("»ù±¾{0} ", dr[2].ToString());
                }
                if (dr[3].ToString() != "")
                {
                    labelre1.Text = String.Format("{0}{1}", labelre1.Text, dr[3].ToString());
                }
                int lv = int.Parse(dr[6].ToString());
                String s = "";
                for (int i = 0; i < lv; i++) {
                    s = s + "¡ï";
                }
                labellv.Text = s;
            }

            strcmd = String.Format("SELECT * FROM MSkill where [Group] = '{0}'", labelname.Text);
            cmd = new OleDbCommand(strcmd, conn);
            dr = cmd.ExecuteReader();
            for (int i = 0; i < 2; i++)
            {
                if (dr.Read())
                {
                    Panel p = ((Panel)(Controls["panel" + (i + 2)]));
                    ((PictureBox)(p.Controls["pictureBoxs" + (i + 1)])).Image = PicLoader.Read(String.Format("MSkill.{0}.JPG", dr[0].ToString()));
                    int ip;
                    int ip2;
                    RichTextBox r = ((RichTextBox)(p.Controls["richTextBoxs" + (i + 1)]));
                    r.Clear();
                    ip = r.Text.Length;
                    r.AppendText(String.Format("{0}\n", dr[1].ToString()));
                    ip2 = r.Text.Length;
                    r.Select(ip, ip2 - ip - 1);
                    r.SelectionColor = Color.Red;

                    r.AppendText(String.Format("{0}\n", dr[3].ToString()));

                    if (dr[2].ToString() != "")
                    {
                        ip = r.Text.Length;
                        r.AppendText(String.Format("ÀäÈ´Ê±¼ä{0}Ãë", dr[2].ToString()));
                        ip2 = r.Text.Length;
                        r.Select(ip, ip2 - ip);
                        r.SelectionColor = Color.LightBlue;
                    }
                }
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).Name.Substring(6)) - 1;
            ShowPet(p[id]);
        }
    }
}