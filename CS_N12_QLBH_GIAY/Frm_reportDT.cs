using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_N12_QLBH_GIAY
{
    public partial class Frm_reportDT : Form
    {
        public Frm_reportDT()
        {
            InitializeComponent();
        }

        private void Frm_reportDT_Load(object sender, EventArgs e)
        {
            this.f_doanhthuTableAdapter.Fill(this.CS_N12_5601_QLBH_GIAYDataSet.f_doanhthu, dtp_nam.Value.Year.ToString());

            this.rpv_dt.RefreshReport();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            rpv_dt.LocalReport.DataSources.Clear();
            // reportViewer1.LocalReport.DataSources.Add(rds);
            rpv_dt.RefreshReport();
        }
    }
}
