using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy.DTO;

namespace QuanLy.DAL
{
    class KhachHangDAL
    {
        Connection connection = new Connection();
        SqlConnection con1;
        public DataTable LoadKhachHang()
        {
            return connection.LoadData("Select * from KhachHang");

        }
        public DataTable TimKiemKhachHang(string TenKH, string SDT)
        {
            con1 = connection.getConnection();
            con1.Open();
            string SQL = "select * from KhachHang where TenKH like N'"+TenKH+"' or SDT = '"+SDT+"'";
            SqlCommand cmd = new SqlCommand(SQL, con1);
            SqlDataAdapter Adap = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            Adap.Fill(tb);
            return tb;
        }
      
    }
}
