namespace HHsimulator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitemvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tskillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.sinfoToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beginToolStripMenuItem
            // 
            this.beginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.beginToolStripMenuItem.Name = "beginToolStripMenuItem";
            this.beginToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.beginToolStripMenuItem.Text = "开始";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heroToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.petToolStripMenuItem,
            this.hitemvToolStripMenuItem,
            this.demonToolStripMenuItem,
            this.tskillToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.infoToolStripMenuItem.Text = "信息";
            // 
            // heroToolStripMenuItem
            // 
            this.heroToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNArthas;
            this.heroToolStripMenuItem.Name = "heroToolStripMenuItem";
            this.heroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.heroToolStripMenuItem.Text = "英雄信息";
            this.heroToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonHero_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNPotionGreen;
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.itemToolStripMenuItem.Text = "物品信息";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonItem_Click);
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNSkink;
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.petToolStripMenuItem.Text = "幻兽信息";
            this.petToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonPet_Click);
            // 
            // hitemvToolStripMenuItem
            // 
            this.hitemvToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNCurse;
            this.hitemvToolStripMenuItem.Name = "hitemvToolStripMenuItem";
            this.hitemvToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.hitemvToolStripMenuItem.Text = "幻兽装备";
            this.hitemvToolStripMenuItem.Click += new System.EventHandler(this.hitemvToolStripMenuItem_Click);
            // 
            // demonToolStripMenuItem
            // 
            this.demonToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNManual3;
            this.demonToolStripMenuItem.Name = "demonToolStripMenuItem";
            this.demonToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.demonToolStripMenuItem.Text = "恶魔信息";
            this.demonToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonBoss_Click);
            // 
            // tskillToolStripMenuItem
            // 
            this.tskillToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNTent;
            this.tskillToolStripMenuItem.Name = "tskillToolStripMenuItem";
            this.tskillToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.tskillToolStripMenuItem.Text = "天赋技能";
            this.tskillToolStripMenuItem.Click += new System.EventHandler(this.tskillToolStripMenuItem_Click);
            // 
            // sinfoToolStripMenuItem
            // 
            this.sinfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem,
            this.logToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.sinfoToolStripMenuItem.Name = "sinfoToolStripMenuItem";
            this.sinfoToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sinfoToolStripMenuItem.Text = "周边";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNSpy;
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mapToolStripMenuItem.Text = "地图概况";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonMap_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNHumanBuild;
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logToolStripMenuItem.Text = "更新日志";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonLog_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNEngineeringUpgrade;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.systemToolStripMenuItem.Text = "系统说明";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sigToolStripMenuItem,
            this.replayToolStripMenuItem,
            this.webToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "工具";
            // 
            // sigToolStripMenuItem
            // 
            this.sigToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNStone;
            this.sigToolStripMenuItem.Name = "sigToolStripMenuItem";
            this.sigToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sigToolStripMenuItem.Text = "签名制作";
            this.sigToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonSig_Click);
            // 
            // replayToolStripMenuItem
            // 
            this.replayToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNOrcBattleStandard;
            this.replayToolStripMenuItem.Name = "replayToolStripMenuItem";
            this.replayToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.replayToolStripMenuItem.Text = "录像分析";
            this.replayToolStripMenuItem.Click += new System.EventHandler(this.replayToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Image = global::HHsimulator.Properties.Resources.BTNLogo;
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.webToolStripMenuItem.Text = "幻兽论坛";
            this.webToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonWeb_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aboutToolStripMenuItem.Text = "关于幻兽传说";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonThanks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1010, 691);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "幻兽传说De永恒世界模拟器1.08";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hitemvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tskillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replayToolStripMenuItem;

    }
}

