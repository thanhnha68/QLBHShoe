using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_N12_QLBH_GIAY
{
    public partial class frm_reportSP : Form
    {
        public frm_reportSP()
        {
            InitializeComponent();
            //this.Controls.Add(this.reportViewer1);
        }

        private void frm_reportSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CS_N12_5601_QLBH_GIAYDataSet.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.CS_N12_5601_QLBH_GIAYDataSet.SanPham);
            this.reportViewer1.RefreshReport();

        }
    }
}
