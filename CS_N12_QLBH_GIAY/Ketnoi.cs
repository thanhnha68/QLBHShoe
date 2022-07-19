using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS_N12_QLBH_GIAY
{
    class Ketnoi
    {
        private string strConn = @"Data Source =THANHNHA\SQL09;Initial Catalog=QLBH_CS_NHA_NGOC;Integrated Security=True";
        // private string strConn = @"Data Source=. \THANHNHA;Initial Catalog=CS_N12_5601_QLBH_GIAY;Integrated Security=True";
        public SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            return conn;
        }
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection ketnoi = new SqlConnection(strConn))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                thucthi.ExecuteNonQuery();

                ketnoi.Close();
            }
            return data;
        }

        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection Ketnoi = new SqlConnection(strConn))
            {
                Ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, Ketnoi);
                SqlDataAdapter laydulieu = new SqlDataAdapter(thucthi);
                laydulieu.Fill(dt);
                Ketnoi.Close();
            }
            return dt;
        }

        public  SqlDataReader ThucHienReader(string select)
        {
            using (SqlConnection Ketnoi = new SqlConnection(strConn))
            {
                Ketnoi.Open();
                SqlCommand cmd = new SqlCommand(select, Ketnoi);
                try
                {
                    return cmd.ExecuteReader();
                }
                catch (SqlException)
                {
                    return null;
                }
            }
        }
       
    }
}
