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
    public partial class FrmReportSP : Form
    {
        public FrmReportSP()
        {
            InitializeComponent();
        }

        private void FrmReportSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBH_CS_NHA_NGOCDataSet.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.QLBH_CS_NHA_NGOCDataSet.SanPham);

            this.reportViewer1.RefreshReport();
        }
    }
}
