using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Deerchao.War3Share.W3gParser;
using System.IO;
using System.Data.OleDb;

namespace HHsimulator
{
    public partial class ReplayView : Form
    {
        private Replay replay;
        public ReplayView()
        {
            InitializeComponent();
        }

        private void ReplayView_Load(object sender, EventArgs e)
        {
        }

        private void UpdateInfo(string path) {
            replay = new Replay(path);
            richTextBoxChat.Clear();
            foreach (ChatInfo ci in replay.Chats)
            {
                int ip;
                int ip2;
                ip = richTextBoxChat.Text.Length;
                richTextBoxChat.AppendText(String.Format("{0}: ", ci.From.Name));
                ip2 = richTextBoxChat.Text.Length;
                richTextBoxChat.Select(ip, ip2 - ip - 1);
                richTextBoxChat.SelectionColor = Color.FromName(ci.From.Color.ToString());

                richTextBoxChat.AppendText(String.Format("{0} ", ci.Message));

                ip = richTextBoxChat.Text.Length;
                richTextBoxChat.AppendText(String.Format("({0})\n", ci.Time.ToString().Substring(0, 8)));
                ip2 = richTextBoxChat.Text.Length;
                richTextBoxChat.Select(ip, ip2 - ip - 1);
                richTextBoxChat.SelectionColor = Color.Red;
            }
            TimeSpan large = new TimeSpan(0);
            dataGridViewPlayer.Rows.Clear();
            comboBoxPlayer.Items.Clear();
            foreach (Player p in replay.Players)
            {
                if (!p.IsComputer)
                {
                    if (p.GetTime() > large)
                        large = p.GetTime();
                    string[] row0 = { p.Name, p.TeamNo.ToString(), p.Handicap.ToString() + "%", p.Actions.ToString(), p.GetTime().ToString().Substring(0, 8), p.Apm.ToString() };
                    dataGridViewPlayer.Rows.Add(row0);
                    dataGridViewPlayer.Rows[dataGridViewPlayer.Rows.Count - 1].Cells[0].Style.ForeColor = Color.FromName(p.Color.ToString());
                    comboBoxPlayer.Items.Add(p.Name);
                }
            }
            comboBoxPlayer.SelectedIndex = 0;
            comboBoxItemType.SelectedIndex = 0;
            FillMapInfo(large);
        }

        private void FillMapInfo(TimeSpan time) {
            labelFileLength.Text = replay.Size.ToString();
            labelGameTime.Text = time.ToString().Substring(0, 8);
            labelGameName.Text = replay.GameName;
            labelGameType.Text = replay.GameType.ToString();
            labelGameVersion.Text = String.Format("1.{0}", replay.Version.ToString());
            labelHost.Text = replay.Host.Name.ToString();
            labelMapPath.Text = replay.Map.Path;
            if (replay.Map.Path.Contains("Eternia"))
                pictureBoxLogo.Image = PicLoader.Read("Basic.logo.JPG");
            else
                pictureBoxLogo.Image = null;
        }

        private void comboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewItems.Items.Clear();
            imageListItems.Images.Clear();
            foreach (Player p in replay.Players)
            {
                if (!p.IsComputer && p.Name == comboBoxPlayer.SelectedItem.ToString())
                {
                    foreach (OrderItem oi in p.Items.BuildOrders)
                    {
                        int range = ChineseItemString.GetStringFromItemId(oi.Name).IndexOf('-');
                        int id = int.Parse(ChineseItemString.GetStringFromItemId(oi.Name).Substring(0, range));
                        bool flag = false;
                        if (comboBoxItemType.SelectedIndex == 0)
                            flag = true;
                        else if (comboBoxItemType.SelectedIndex == 1 && id >= 107 && id <= 114)
                            flag = true;
                        else if (comboBoxItemType.SelectedIndex == 2 && id <= 43)
                            flag = true;
                        else if (comboBoxItemType.SelectedIndex == 3 && ((id >= 44 && id <= 106) || (id >= 115 && id <= 118)))
                            flag = true;
                        if (flag)
                        {
                            imageListItems.Images.Add(PicLoader.Read(String.Format("Items.C{0}.JPG", id)));
                            ListViewItem item = new ListViewItem("", imageListItems.Images.Count - 1);
                            item.SubItems.Add(TimeSpan.FromSeconds(oi.Time / 1000).ToString());
                            item.SubItems.Add(ChineseItemString.GetStringFromItemId(oi.Name).Substring(range + 1));
                            listViewItems.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.SelectedPath = textBoxPath.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog1.SelectedPath;
                UpdateFiles(folderBrowserDialog1.SelectedPath);
            }
        }

        private void UpdateFiles(string path) {
            listViewFiles.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files) {
                if (file.Extension == ".w3g")
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(String.Format("{0}KB", file.Length / 1024));
                    listViewFiles.Items.Add(item);
                }
            }
        }

        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count != 0)
            {
                string path = listViewFiles.SelectedItems[0].Text;
                UpdateInfo(String.Format("{0}\\{1}", textBoxPath.Text , path));
            }
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count != 0)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|data.mdb";
                conn.Open();
                string strcmd = String.Format("SELECT [id],[Effect] FROM [Item] where [Name] = '{0}'", listViewItems.SelectedItems[0].SubItems[2].Text);
                OleDbCommand cmd = new OleDbCommand(strcmd, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pictureBoxItem.Image = PicLoader.Read(String.Format("Items.C{0}.JPG", dr[0].ToString()));
                    labelItemName.Text = listViewItems.SelectedItems[0].SubItems[2].Text;
                    textBoxDes.Text = dr[1].ToString();
                }
                conn.Close();
            }
        }

        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (replay != null)
                comboBoxPlayer_SelectedIndexChanged(null, e);
        }

        private void tabControl_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);//这只是个例子,你可以按照你的需要改写   
        }  
    }
}