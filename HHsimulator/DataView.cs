using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHsimulator
{
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
        }

        private void DataView_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet1.Item”中。您可以根据需要移动或移除它。
            this.itemTableAdapter.Fill(this.dataDataSet1.Item);
        }
    }
}