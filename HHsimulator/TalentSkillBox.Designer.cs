namespace HHsimulator
{
    partial class TalentSkillBox
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblname = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBoxhead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhead)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblname.ForeColor = System.Drawing.Color.LightBlue;
            this.lblname.Location = new System.Drawing.Point(76, 6);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(183, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(284, 63);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // pictureBoxhead
            // 
            this.pictureBoxhead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxhead.Location = new System.Drawing.Point(6, 4);
            this.pictureBoxhead.Name = "pictureBoxhead";
            this.pictureBoxhead.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxhead.TabIndex = 0;
            this.pictureBoxhead.TabStop = false;
            this.pictureBoxhead.Click += new System.EventHandler(this.pictureBoxhead_Click);
            this.pictureBoxhead.MouseEnter += new System.EventHandler(this.pictureBoxhead_MouseEnter);
            // 
            // TalentSkillBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBoxhead);
            this.Name = "TalentSkillBox";
            this.Size = new System.Drawing.Size(480, 75);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TalentSkillBox_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxhead;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
