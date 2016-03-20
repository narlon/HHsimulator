namespace HHsimulator
{
    partial class ItemBox
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
            this.lbldes = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBoxd3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxd2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxd1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxhead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxd1)).BeginInit();
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
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbldes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbldes.Location = new System.Drawing.Point(180, 7);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(31, 13);
            this.lbldes.TabIndex = 5;
            this.lbldes.Text = "des";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(79, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(388, 36);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // pictureBoxd3
            // 
            this.pictureBoxd3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxd3.Location = new System.Drawing.Point(444, 3);
            this.pictureBoxd3.Name = "pictureBoxd3";
            this.pictureBoxd3.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxd3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxd3.TabIndex = 4;
            this.pictureBoxd3.TabStop = false;
            this.pictureBoxd3.MouseLeave += new System.EventHandler(this.pictureBoxd1_MouseLeave);
            this.pictureBoxd3.MouseEnter += new System.EventHandler(this.pictureBoxd1_MouseEnter);
            // 
            // pictureBoxd2
            // 
            this.pictureBoxd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxd2.Location = new System.Drawing.Point(407, 3);
            this.pictureBoxd2.Name = "pictureBoxd2";
            this.pictureBoxd2.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxd2.TabIndex = 3;
            this.pictureBoxd2.TabStop = false;
            this.pictureBoxd2.MouseLeave += new System.EventHandler(this.pictureBoxd1_MouseLeave);
            this.pictureBoxd2.MouseEnter += new System.EventHandler(this.pictureBoxd1_MouseEnter);
            // 
            // pictureBoxd1
            // 
            this.pictureBoxd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxd1.Location = new System.Drawing.Point(370, 3);
            this.pictureBoxd1.Name = "pictureBoxd1";
            this.pictureBoxd1.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxd1.TabIndex = 2;
            this.pictureBoxd1.TabStop = false;
            this.pictureBoxd1.MouseLeave += new System.EventHandler(this.pictureBoxd1_MouseLeave);
            this.pictureBoxd1.MouseEnter += new System.EventHandler(this.pictureBoxd1_MouseEnter);
            // 
            // pictureBoxhead
            // 
            this.pictureBoxhead.Location = new System.Drawing.Point(6, 4);
            this.pictureBoxhead.Name = "pictureBoxhead";
            this.pictureBoxhead.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxhead.TabIndex = 0;
            this.pictureBoxhead.TabStop = false;
            // 
            // ItemBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.pictureBoxd3);
            this.Controls.Add(this.pictureBoxd2);
            this.Controls.Add(this.pictureBoxd1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBoxhead);
            this.Name = "ItemBox";
            this.Size = new System.Drawing.Size(480, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxhead;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox pictureBoxd1;
        private System.Windows.Forms.PictureBox pictureBoxd2;
        private System.Windows.Forms.PictureBox pictureBoxd3;
        private System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
