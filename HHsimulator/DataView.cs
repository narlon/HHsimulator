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
            // TODO: ���д��뽫���ݼ��ص���dataDataSet1.Item���С������Ը�����Ҫ�ƶ����Ƴ�����
            this.itemTableAdapter.Fill(this.dataDataSet1.Item);
        }
    }
}