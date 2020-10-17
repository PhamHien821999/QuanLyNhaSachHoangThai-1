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
   public  class ThongKeDAL
    {
        Connection con = new Connection();
        SqlConnection con1;

        public DataTable ThongKe(DateTime d1, DateTime d2)
        {
            return con.LoadData("select hd.SoHD, hd.MaNV, hd.MaKH,hd.NgayLap , (ct.DonGiaBan*ct.SoLuongBan) as'tongtien' from HoaDon hd inner join ChiTietHoaDon ct on hd.SoHD = ct.SoHD where hd.NgayLap between '"+d1+"' and '"+d2+"'");
        }

        //lấy tổng tiền theo Hóa đơn
        public float TongTien(DateTime d1, DateTime d2)
        {
            float price = 0;
            con1 = con.getConnection();
            try
            {
                con1.Open();
                string SQL = string.Format("select sum(ct.DonGiaBan*ct.SoLuongBan) as'tongtien' from HoaDon hd inner join ChiTietHoaDon ct on hd.SoHD = ct.SoHD where hd.NgayLap between '" + d1 + "' and '" + d2 + "'");
                SqlCommand cmd = new SqlCommand(SQL, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        price = Convert.ToInt64(dr["TongTien"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                
            }
            return price;
        }
    }
}
