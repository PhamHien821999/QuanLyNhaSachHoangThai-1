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
    class NhanVienDAL
    {
        Connection con = new Connection();
        SqlConnection con1;
        public DataTable LoadNhanVien()
        {
            return con.LoadData("Select * from NhanVien");
        }
        public bool themEmployee(NhanVien nv)
        {
            con1 = con.getConnection();
            try
            {
                con1.Open();
                string SQL = string.Format("insert into NhanVien values(@MaNV, @TenNV, @GioiTinh, @NgaySinh, @DiaChi, @SDT)");
                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MaNV", nv.maNV);
                cmd.Parameters.AddWithValue("@TenNV", nv.tenNV);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", nv.diaChi);
                cmd.Parameters.AddWithValue("@SDT", nv.sdt);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

            }
            finally
            {
                // Dong ket noi
                con1.Close();
            }
            return false;
        }
        public bool SuaEmployee(NhanVien nv)
        {
            con1 = con.getConnection();
            try
            {
                con1.Open();
                string SQL = string.Format("UPDATE NhanVien SET TenNV =@TenNV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi=@DiaChi, SDT = @SDT where  MaNV =@MaNV ");

                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MaNV", nv.maNV);
                cmd.Parameters.AddWithValue("@TenNV", nv.tenNV);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", nv.diaChi);
                cmd.Parameters.AddWithValue("@SDT", nv.sdt);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

            }
            finally
            {
                con1.Close();
            }

            return false;
        }
        public bool XoaEmployee(NhanVien nv)
        {
            con1 = con.getConnection();
            try
            {
                con1.Open();
                string SQL = string.Format("DELETE FROM NhanVien WHERE MaNV =@MaNV");

                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MaNV", nv.maNV);
                cmd.Parameters.AddWithValue("@TenNV", nv.tenNV);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", nv.diaChi);
                cmd.Parameters.AddWithValue("@SDT", nv.sdt);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

            }
            finally
            {
                con1.Close();
            }

            return false;
        }
    }
}
