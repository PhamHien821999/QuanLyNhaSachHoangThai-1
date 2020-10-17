using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy.DAL
{
   public  class PhieuNhapHangDAL
    {
        Connection connection = new Connection();
        SqlConnection con;

        //Lấy thông tin chi tiết hóa đơn có tên sách theo số hóa đơn
        public DataTable LoadPhieuNhap(string SoPhieu)
        {
            con = connection.getConnection();
            con.Open();
            string SQL = string.Format("select SoPhieu, TenSach, ct.SoLuongNhap, ct.donGiaNhap, (ct.SoLuongNhap*ct.donGiaNhap) as 'ThanhTien' from ChiTietPhieuNhap ct inner join Sach s on ct.MaSach = s.MaSach where SoPhieu='" + SoPhieu + "'");
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Lấy thông tin nhân viên
        public DataTable LoadNhanVien()
        {
            return connection.LoadData("Select * from Nhanvien");
        }

        //Lấy thông tin sách
        public DataTable LoadSach()
        {
            return connection.LoadData("select * from Sach");
        }

        //Lấy thông tin nhà cung cấp
        public DataTable LoadNhaCungCap()
        {
            return connection.LoadData("select * from NhaCungCap");
        }

        //Them PhieuNhap
        public bool ThemPhieuNhap(PhieuNhap pn)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("INSERT INTO PhieuNhap(SoPhieu,MaNV,NgayLap, MaNCC) VALUES (@SoPhieu,@MaNV,@NgayLap, @MaNCC)");
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.Parameters.AddWithValue("@SoPhieu", pn.soPhieu);
                cmd.Parameters.AddWithValue("@MaNV",pn.nhanVien );
                cmd.Parameters.AddWithValue("@NgayLap", pn.ngayNhap);
                cmd.Parameters.AddWithValue("@MaNCC", pn.nhaCungCap);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                // Dong ket noi
                con.Close();
            }
            return false;
        }

        //thêm sản phẩm mua vào phiếu nhập
        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap ct)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("INSERT INTO ChiTietPhieuNhap(SoPhieu,MaSach,SoLuongNhap,donGiaNhap) VALUES (@SoPhieu,@MaSach, @SoLuongNhap,@donGiaNhap)");
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.Parameters.AddWithValue("@SoPhieu", ct.soPhieu);
                cmd.Parameters.AddWithValue("@MaSach", ct.maSach);
                cmd.Parameters.AddWithValue("@SoLuongNhap", ct.soLuongNhap);
                cmd.Parameters.AddWithValue("@donGiaNhap",ct.donGiaNhap);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {
                //
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }
            return false;
        }

        //xóa hết sản phẩm theo số phiếu
        public bool XoaChiTietPhieuNhap(string SoPhieu)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("delete From ChiTietPhieuNhap where SoPhieu='" + SoPhieu + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                //
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }
            return false;
        }

        //lấy tổng tiền theo phieu nhap
        public long TongTien(string SoPhieu)
        {
            long price = 0;
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("select Sum(SoLuongNhap*donGiaNhap) As'TongTien' from ChiTietPhieuNhap where SoPhieu='" + SoPhieu + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
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
                MessageBox.Show("Lỗi kết nối!xin vui lòng kiểm tra lại");
            }
            return price;
        }

        //xóa phieu nhap
        public bool XoaPhieuNhap(string SoPhieu)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("delete From PhieuNhap  where SoPhieu='" + SoPhieu + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                //
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }
            return false;
        }
    }
}
