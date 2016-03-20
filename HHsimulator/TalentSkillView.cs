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
    public partial class TalentSkillView : Form
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public TalentSkillView()
        {
            InitializeComponent();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            BackgroundImage = PicLoader.Read("Bg.t1.JPG");
            LoadInfo("¾ö¶Ï");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CClear();
            LoadInfo((sender as Button).Tag.ToString());
        }

        private void CClear() {
            for (int i = 1; i <= 12; i++)
                ((TalentSkillBox)(Controls["talentSkillBox" + i])).CClear();
        }
        private void LoadInfo(string type)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd = String.Format("SELECT * FROM [TSkill] where [Type] = '{0}' order by [Prior]", type);
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            int id = 1;
            while (dr.Read())
            {
                ((TalentSkillBox)(Controls["talentSkillBox" + id])).Head = PicLoader.Read(String.Format("TSkill.{0}.JPG", dr[0].ToString()));
                ((TalentSkillBox)(Controls["talentSkillBox" + id])).DName = dr[1].ToString();
                ((TalentSkillBox)(Controls["talentSkillBox" + id])).Effect = dr[2].ToString();
                ((TalentSkillBox)(Controls["talentSkillBox" + id])).Str = int.Parse(dr[3].ToString());
                ((TalentSkillBox)(Controls["talentSkillBox" + id])).Agi = int.Parse(dr[4].ToString());
                ((TalentSkillBox)(Controls["talentSkillBox" + id])).Intp = int.Parse(dr[5].ToString());
                ((TalentSkillBox)(Controls["talentSkillBox" + id])).SetChart(int.Parse(dr[3].ToString()), int.Parse(dr[4].ToString()), int.Parse(dr[5].ToString()),dr[2].ToString());
                ((TalentSkillBox)(Controls["talentSkillBox" + id])).Effect2 = dr[6].ToString();
                if (dr[6].ToString() != "")
                {
                    ((TalentSkillBox)(Controls["talentSkillBox" + id])).Str2 = int.Parse(dr[7].ToString());
                    ((TalentSkillBox)(Controls["talentSkillBox" + id])).Agi2 = int.Parse(dr[8].ToString());
                    ((TalentSkillBox)(Controls["talentSkillBox" + id])).Intp2 = int.Parse(dr[9].ToString());
                }
                id++;
            }
            conn.Close();
        }
    }
}