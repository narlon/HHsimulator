namespace HHsimulator
{
    partial class IDataView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agiPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new HHsimulator.dataDataSet();
            this.heroTableAdapter = new HHsimulator.dataDataSetTableAdapters.HeroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.attackDataGridViewTextBoxColumn,
            this.defDataGridViewTextBoxColumn,
            this.strDataGridViewTextBoxColumn,
            this.agiDataGridViewTextBoxColumn,
            this.intDataGridViewTextBoxColumn,
            this.strpDataGridViewTextBoxColumn,
            this.agiPDataGridViewTextBoxColumn,
            this.intpDataGridViewTextBoxColumn,
            this.mHPDataGridViewTextBoxColumn,
            this.mMPDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.heroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(956, 634);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名字";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "职业";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jobDataGridViewTextBoxColumn.Width = 60;
            // 
            // attackDataGridViewTextBoxColumn
            // 
            this.attackDataGridViewTextBoxColumn.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn.HeaderText = "初始攻击";
            this.attackDataGridViewTextBoxColumn.Name = "attackDataGridViewTextBoxColumn";
            this.attackDataGridViewTextBoxColumn.ReadOnly = true;
            this.attackDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.attackDataGridViewTextBoxColumn.Width = 60;
            // 
            // defDataGridViewTextBoxColumn
            // 
            this.defDataGridViewTextBoxColumn.DataPropertyName = "Def";
            this.defDataGridViewTextBoxColumn.HeaderText = "初始护甲";
            this.defDataGridViewTextBoxColumn.Name = "defDataGridViewTextBoxColumn";
            this.defDataGridViewTextBoxColumn.ReadOnly = true;
            this.defDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.defDataGridViewTextBoxColumn.Width = 60;
            // 
            // strDataGridViewTextBoxColumn
            // 
            this.strDataGridViewTextBoxColumn.DataPropertyName = "Str";
            this.strDataGridViewTextBoxColumn.HeaderText = "初始力量";
            this.strDataGridViewTextBoxColumn.Name = "strDataGridViewTextBoxColumn";
            this.strDataGridViewTextBoxColumn.ReadOnly = true;
            this.strDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.strDataGridViewTextBoxColumn.Width = 60;
            // 
            // agiDataGridViewTextBoxColumn
            // 
            this.agiDataGridViewTextBoxColumn.DataPropertyName = "Agi";
            this.agiDataGridViewTextBoxColumn.HeaderText = "初始敏捷";
            this.agiDataGridViewTextBoxColumn.Name = "agiDataGridViewTextBoxColumn";
            this.agiDataGridViewTextBoxColumn.ReadOnly = true;
            this.agiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.agiDataGridViewTextBoxColumn.Width = 60;
            // 
            // intDataGridViewTextBoxColumn
            // 
            this.intDataGridViewTextBoxColumn.DataPropertyName = "Int";
            this.intDataGridViewTextBoxColumn.HeaderText = "初始智力";
            this.intDataGridViewTextBoxColumn.Name = "intDataGridViewTextBoxColumn";
            this.intDataGridViewTextBoxColumn.ReadOnly = true;
            this.intDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.intDataGridViewTextBoxColumn.Width = 60;
            // 
            // strpDataGridViewTextBoxColumn
            // 
            this.strpDataGridViewTextBoxColumn.DataPropertyName = "Strp";
            this.strpDataGridViewTextBoxColumn.HeaderText = "力量成长";
            this.strpDataGridViewTextBoxColumn.Name = "strpDataGridViewTextBoxColumn";
            this.strpDataGridViewTextBoxColumn.ReadOnly = true;
            this.strpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.strpDataGridViewTextBoxColumn.Width = 60;
            // 
            // agiPDataGridViewTextBoxColumn
            // 
            this.agiPDataGridViewTextBoxColumn.DataPropertyName = "AgiP";
            this.agiPDataGridViewTextBoxColumn.HeaderText = "敏捷成长";
            this.agiPDataGridViewTextBoxColumn.Name = "agiPDataGridViewTextBoxColumn";
            this.agiPDataGridViewTextBoxColumn.ReadOnly = true;
            this.agiPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.agiPDataGridViewTextBoxColumn.Width = 60;
            // 
            // intpDataGridViewTextBoxColumn
            // 
            this.intpDataGridViewTextBoxColumn.DataPropertyName = "Intp";
            this.intpDataGridViewTextBoxColumn.HeaderText = "智力成长";
            this.intpDataGridViewTextBoxColumn.Name = "intpDataGridViewTextBoxColumn";
            this.intpDataGridViewTextBoxColumn.ReadOnly = true;
            this.intpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.intpDataGridViewTextBoxColumn.Width = 60;
            // 
            // mHPDataGridViewTextBoxColumn
            // 
            this.mHPDataGridViewTextBoxColumn.DataPropertyName = "MHP";
            this.mHPDataGridViewTextBoxColumn.HeaderText = "初始生命";
            this.mHPDataGridViewTextBoxColumn.Name = "mHPDataGridViewTextBoxColumn";
            this.mHPDataGridViewTextBoxColumn.ReadOnly = true;
            this.mHPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mHPDataGridViewTextBoxColumn.Width = 60;
            // 
            // mMPDataGridViewTextBoxColumn
            // 
            this.mMPDataGridViewTextBoxColumn.DataPropertyName = "MMP";
            this.mMPDataGridViewTextBoxColumn.HeaderText = "初始魔法";
            this.mMPDataGridViewTextBoxColumn.Name = "mMPDataGridViewTextBoxColumn";
            this.mMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.mMPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mMPDataGridViewTextBoxColumn.Width = 60;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "移动速度";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.speedDataGridViewTextBoxColumn.Width = 60;
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "攻击范围";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            this.rangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rangeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rangeDataGridViewTextBoxColumn.Width = 60;
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataMember = "Hero";
            this.heroBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // heroTableAdapter
            // 
            this.heroTableAdapter.ClearBeforeFill = true;
            // 
            // IDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(996, 628);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IDataView";
            this.ShowIcon = false;
            this.Text = "DataView";
            this.Load += new System.EventHandler(this.DataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource heroBindingSource;
        private HHsimulator.dataDataSetTableAdapters.HeroTableAdapter heroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agiPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
    }
}