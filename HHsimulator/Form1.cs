using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHsimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            toolStripButtonThanks_Click(null, e);
        }

        private void toolStripButtonHero_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr) {
                if (cf is HeroView)
                    return;
                else
                    cf.Close();
            }

            HeroView hv = new HeroView();
            hv.Id = 1;
            hv.MdiParent = this;
            hv.StartPosition = FormStartPosition.Manual;
            hv.Location = new Point(0,0);
            hv.Show();
        }

        private void toolStripButtonItem_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is ItemView)
                    return;
                else
                    cf.Close();
            }

            ItemView iv = new ItemView();
            iv.Id = 1;
            iv.MdiParent = this;

            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void toolStripButtonWeb_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is MyWeb)
                    return;
                else
                    cf.Close();
            }

            MyWeb iv = new MyWeb();
            iv.MdiParent = this;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void toolStripButtonMap_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is MapView)
                    return;
                else
                    cf.Close();
            }

            MapView iv = new MapView();
            iv.MdiParent = this;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void toolStripButtonBoss_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is BossView)
                    return;
                else
                    cf.Close();
            }

            BossView iv = new BossView();
            iv.MdiParent = this;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void toolStripButtonSig_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is Signiture)
                    return;
                else
                    cf.Close();
            }

            Signiture iv = new Signiture();
            iv.MdiParent = this;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void toolStripButtonPet_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is PetView)
                    return;
                else
                    cf.Close();
            }

            PetView iv = new PetView();
            iv.MdiParent = this;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void toolStripButtonLog_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is LogView)
                    return;
                else
                    cf.Close();
            }

            LogView iv = new LogView();
            iv.MdiParent = this;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void toolStripButtonThanks_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is Thanks)
                    return;
                else
                    cf.Close();
            }

            Thanks iv = new Thanks();
            iv.MdiParent = this;
            iv.StartPosition = FormStartPosition.Manual;
            iv.Location = new Point(0, 0);
            iv.Show();
        }

        private void hitemvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is HItemView)
                    return;
                else
                    cf.Close();
            }

            HItemView hit = new HItemView();
            hit.MdiParent = this;
            hit.StartPosition = FormStartPosition.Manual;
            hit.Location = new Point(0, 0);
            hit.Show();
        }

        private void tskillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is TalentSkillView)
                    return;
                else
                    cf.Close();
            }

            TalentSkillView tsv = new TalentSkillView();
            tsv.MdiParent = this;
            tsv.StartPosition = FormStartPosition.Manual;
            tsv.Location = new Point(0, 0);
            tsv.Show();
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is SystemView)
                    return;
                else
                    cf.Close();
            }

            SystemView sv = new SystemView();
            sv.MdiParent = this;
            sv.StartPosition = FormStartPosition.Manual;
            sv.Location = new Point(0, 0);
            sv.Show();
        }

        private void replayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            foreach (Form cf in charr)
            {
                if (cf is ReplayView)
                    return;
                else
                    cf.Close();
            }

            ReplayView sv = new ReplayView();
            sv.MdiParent = this;
            sv.StartPosition = FormStartPosition.Manual;
            sv.Location = new Point(0, 0);
            sv.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}