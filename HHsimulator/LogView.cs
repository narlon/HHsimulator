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
    public partial class LogView : Form
    {
        public LogView()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                UpdateTable();            
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                UpdateTable();
            }
        }

        private void UpdateTable()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
            conn.Open();
            string strcmd;
            if (comboBox2.SelectedIndex == 0)
                strcmd = String.Format("SELECT * FROM Log Where [Version] = '{0}' order by [Order] desc", comboBox1.SelectedItem.ToString());
            else if(comboBox2.SelectedIndex == 1)
                strcmd = String.Format("SELECT * FROM Log Where [Version] = '{0}' and [Prioty] >= 3 order by [Order] desc", comboBox1.SelectedItem.ToString());
            else if (comboBox2.SelectedIndex == 2)
                strcmd = String.Format("SELECT * FROM Log Where [Version] = '{0}' and [Type] = 'Bal' order by [Order] desc", comboBox1.SelectedItem.ToString());
            else
                strcmd = String.Format("SELECT * FROM Log Where [Version] = '{0}' and [Type] = 'Bug' order by [Order] desc", comboBox1.SelectedItem.ToString());
            richTextBox1.Clear();
            OleDbCommand cmd = new OleDbCommand(strcmd, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            string l = "";
            int ip = 0;
            bool first = true;
            while (dr.Read())
            {
                if (dr[3].ToString() != l) {
                    if (!first)
                        richTextBox1.AppendText("\n");
                    else
                        first = false;
                    ip = richTextBox1.Text.Length;
                    richTextBox1.AppendText(dr[3].ToString());
                    richTextBox1.Select(ip, richTextBox1.Text.Length - ip);
                    richTextBox1.SelectionColor = Color.Gold;
                    richTextBox1.SelectionFont = new System.Drawing.Font("ËÎÌו", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    richTextBox1.AppendText("\n");
                    l = dr[3].ToString();
                }
                ip = richTextBox1.Text.Length;
                richTextBox1.AppendText(dr[2].ToString() + "\n");
                richTextBox1.Select(ip, richTextBox1.Text.Length - ip);
                richTextBox1.SelectionColor = Color.FromArgb(255, 255 - (int.Parse(dr[4].ToString()) - 1) * 50, 255 - (int.Parse(dr[4].ToString()) - 1) * 50);
            }
            conn.Close();
        }

        private void LogView_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}