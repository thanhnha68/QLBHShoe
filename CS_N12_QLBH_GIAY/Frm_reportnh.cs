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
using Microsoft.Reporting.WinForms;

namespace CS_N12_QLBH_GIAY
{
    public partial class Frm_reportnh : Form
    {
        public Frm_reportnh()
        {
            InitializeComponent();
        }
        Ketnoi data = new Ketnoi();
        private void Frm_reportnh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CS_N12_5601_QLBH_GIAYDataSet.sp_thongtinnhaphang' table. You can move, or remove it, as needed.
            this.sp_thongtinnhaphangTableAdapter.Fill(this.CS_N12_5601_QLBH_GIAYDataSet.sp_thongtinnhaphang,DateTime.Today);

            this.rpv_nhaphang.RefreshReport();
        }

        private void btn_taobc_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_thongtinnhaphang";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = data.getConnect();
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", dtp_ngaynhapsp.Value.ToShortDateString()));

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            rpv_nhaphang.ProcessingMode = ProcessingMode.Local;
            rpv_nhaphang.LocalReport.ReportPath = "ReportNH.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            //.table[0];
            rpv_nhaphang.LocalReport.DataSources.Clear();
            rpv_nhaphang.LocalReport.DataSources.Add(rds);
            rpv_nhaphang.RefreshReport();
        }
    }
}
