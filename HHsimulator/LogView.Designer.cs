namespace HHsimulator
{
    partial class LogView
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelkey = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(12, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 556);
            this.panel3.TabIndex = 26;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(24, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(921, 519);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // labelkey
            // 
            this.labelkey.AutoSize = true;
            this.labelkey.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.labelkey.ForeColor = System.Drawing.Color.White;
            this.labelkey.Location = new System.Drawing.Point(205, 21);
            this.labelkey.Name = "labelkey";
            this.labelkey.Size = new System.Drawing.Size(72, 20);
            this.labelkey.TabIndex = 12;
            this.labelkey.Text = "筛选器";
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSname.ForeColor = System.Drawing.Color.White;
            this.labelSname.Location = new System.Drawing.Point(14, 21);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(51, 20);
            this.labelSname.TabIndex = 11;
            this.labelSname.Text = "版本";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.08",
            "1.07",
            "1.06",
            "1.05b",
            "1.05",
            "1.04",
            "1.03",
            "1.02",
            "1.01",
            "1.00"});
            this.comboBox1.Location = new System.Drawing.Point(71, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 20);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "全部",
            "只看重要更新",
            "只看平衡",
            "只看Bug修正"});
            this.comboBox2.Location = new System.Drawing.Point(282, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 20);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(996, 628);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSname);
            this.Controls.Add(this.labelkey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogView";
            this.ShowIcon = false;
            this.Text = "LogView";
            this.Load += new System.EventHandler(this.LogView_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelkey;
        private System.Windows.Forms.Label labelSname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}