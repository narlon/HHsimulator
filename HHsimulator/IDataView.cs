using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHsimulator
{
    public partial class IDataView : Form
    {
        public IDataView()
        {
            InitializeComponent();
        }

        private void DataView_Load(object sender, EventArgs e)
        {
            // TODO: ���д��뽫���ݼ��ص���dataDataSet.Hero���С������Ը�����Ҫ�ƶ����Ƴ�����
            this.heroTableAdapter.Fill(this.dataDataSet.Hero);

        }
    }
}