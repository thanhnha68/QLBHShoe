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
    public partial class FrmReportNCC : Form
    {
        public FrmReportNCC()
        {
            InitializeComponent();
        }

        private void FrmReportNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBH_CS_NHA_NGOCDataSet.NhaCungCap' table. You can move, or remove it, as needed.
            this.NhaCungCapTableAdapter.Fill(this.QLBH_CS_NHA_NGOCDataSet.NhaCungCap);

            this.reportViewer1.RefreshReport();
        }
    }
}
