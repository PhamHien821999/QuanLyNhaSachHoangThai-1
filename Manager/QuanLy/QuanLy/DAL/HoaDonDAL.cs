using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLy.DTO;

namespace QuanLy.DAL
{
    public class HoaDonDAL
    {
        Connection connection = new Connection();

        internal DataTable ThemHD()
        {
            throw new NotImplementedException();
        }

        SqlConnection con;

        //Lấy thông tin chi tiết hóa đơn có tên sách theo số hóa đơn
        public DataTable Load(string SHD)
        {
            con = connection.getConnection();
            con.Open();
            string SQL = string.Format("select SoHD, TenSach, ct.DonGiaBan, ct.SoLuongBan, (ct.DonGiaBan*ct.SoLuongBan) as 'ThanhTien' from ChiTietHoaDon ct inner join Sach s on ct.MaSach = s.MaSach where SoHD='" + SHD + "'");
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Lấy  thông tin Nhân viên
        public DataTable LoadNhanVien()
        {
            return connection.LoadData("Select * from Nhanvien");
        }

        //lấy thông tin Khách hàng
        public DataTable LoadKhachHang()
        {
            return connection.LoadData("select * from KhachHang");
        }

        //Lấy thông tin sách
        public DataTable LoadSach()
        {
            return connection.LoadData("select * from Sach");
        }

        //Lấy giá tiền sách theo mã sách
        public float getPrice(string MaSach)
        {
            float price = 0;
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("select *  from Sach where MaSach='" + MaSach + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        price = Convert.ToSingle(dr["DonGiaBan"].ToString());
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối!xin vui lòng kiểm tra lại");
            }
            return price;
        }

        //Them Hoa Don
        public bool ThemHD(HoaDon hd)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("INSERT INTO HoaDon(SoHD,NgayLap, MaKH, MaNV) VALUES (@Hoadon,@NgayLap,@KhachHang, @NhanVien)"); 
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.Parameters.AddWithValue("@Hoadon", hd.shd);
                cmd.Parameters.AddWithValue("@NhanVien", hd.nhanVien);
                cmd.Parameters.AddWithValue("@KhachHang", hd.khachhang);
                cmd.Parameters.AddWithValue("@NgayLap", hd.ngayLap);
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

        //thêm sản phẩm mua vào hóa đơn
        public bool ThemChiTietHoaDon(ChiTietHoaDon hd)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("INSERT INTO ChiTietHoaDon(SoHD,MaSach,SoLuongBan,DonGiaBan) VALUES (@Hoadon,@MaSach, @SoLuong,@donGiaBan)");
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.Parameters.AddWithValue("@Hoadon", hd.shd);
                cmd.Parameters.AddWithValue("@MaSach", hd.maSach);
                cmd.Parameters.AddWithValue("@donGiaBan", hd.donGiaBan);
                cmd.Parameters.AddWithValue("@SoLuong", hd.soLuongBan);
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

        //xóa hết sản phẩm theo số hóa đơn
        public bool XoaChiTietHoaDon(string SHD)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("delete From ChiTietHoaDon  where SoHD='" + SHD + "'");
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

        //lấy tổng tiền theo Hóa đơn
        public long TongTien(string SHD)
        {
            long price = 0;
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("select Sum(DonGiaBan*SoLuongBan) As'TongTien' from ChiTietHoaDon where SoHD='" + SHD + "'");
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
        //xóa hóa đon
        public bool XoaHoaDon(string SHD)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("delete From HoaDon  where SoHD='" + SHD + "'");
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

        //Load Chi Tiet Hoa don
        public DataTable LoadChiTietHoaDon(string SoHD)
        {
              return connection.LoadData("select * from ChiTietHoaDon where SoHD =' "+SoHD+"'");
        }

        //lấy So Luong Sach Trong Kho
        public int LoadSLSach(string MaSach)
        {
            int SoLuong = 0;
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("select *  from Sach where MaSach='" + MaSach + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        SoLuong = Convert.ToInt32(dr["SoLuongCo"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!xin vui lòng kiểm tra lại");
            }
            return SoLuong;
        }

        //Cập nhập số luong sản phẩm bán
        public bool UpdateSPBan(string MaSach, int SL)
        {
            con = connection.getConnection();
            try
            {
                con.Open();
                string SQL = string.Format("UPDATE Sach SET SoLuongCo = "+SL+ " WHERE MaSach = '"+ MaSach + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
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
    }
}
