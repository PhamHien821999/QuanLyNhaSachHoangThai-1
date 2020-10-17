using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLy.DTO;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace QuanLy.DAL
{
    public class SachDAL
    {
        Connection con = new Connection();
        SqlConnection con1;
        public DataTable LoadSach()
        {
            return con.LoadData("Select * from Sach");

        }
        public DataTable TimKiemSach(string Masach,string TenSach)
        {
            con1 = con.getConnection();
            con1.Open();
            string SQL = "select s.MaSach,s.TenSach, tl.TenTL, tg.TenTG, DonGiaBan, SoLuongCo from Sach s inner join TacGia tg on s.MaTG = tg.MaTG inner join TheLoai tl on tl.MaTL = s.MaTL where s.MaSach ='"+Masach+ "' or s.TenSach like N'" + TenSach + "' ";
            SqlCommand cmd = new SqlCommand(SQL, con1);
            SqlDataAdapter Adap = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            Adap.Fill(tb);
            return tb;
        }
        public DataTable theLoai()
        {
            return con.LoadData("Select * from theLoai");
        }

        public DataTable TacGia()
        {
            return con.LoadData("Select * from TacGia");
        }
        public bool themBook(Sach s)
        {
            con1 = con.getConnection();
            try
            {
                con1.Open();
                string SQL = string.Format("insert into Sach values(@MaSach, @TenSach, @MaTL, @MaTG, @DonGiaBan, @SoLuongCo)");
                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MaSach", s.maSach);
                cmd.Parameters.AddWithValue("@TenSach", s.tenSach);
                cmd.Parameters.AddWithValue("@MaTL", s.maTL);
                cmd.Parameters.AddWithValue("@MaTG", s.maTG);
                cmd.Parameters.AddWithValue("@DonGiaBan", s.donGiaBan);
                cmd.Parameters.AddWithValue("@SoLuongCo", s.soluongCo);

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
        public bool SuaBook(Sach s)
        {
            con1 = con.getConnection();
            try
            {
                con1.Open();
                string SQL = string.Format("UPDATE Sach SET TenSach =@TenSach, MaTL = @MaTL, MaTG=  @MaTG, DonGiaBan=@DonGiaBan, SoLuongCo = @SoLuongCo where  MaSach =@MaSach ");

                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MaSach", s.maSach);
                cmd.Parameters.AddWithValue("@TenSach", s.tenSach);
                cmd.Parameters.AddWithValue("@MaTL", s.maTL);
                cmd.Parameters.AddWithValue("@MaTG", s.maTG);
                cmd.Parameters.AddWithValue("@DonGiaBan", s.donGiaBan);
                cmd.Parameters.AddWithValue("@SoLuongCo", s.soluongCo);

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
        public bool XoaBook(Sach s)
        {
            con1 = con.getConnection();
            try
            {
                con1.Open();
                string SQL = string.Format("DELETE FROM Sach WHERE MaSach =@MaSach");

                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MaSach", s.maSach);
                cmd.Parameters.AddWithValue("@TenSach", s.tenSach);
                cmd.Parameters.AddWithValue("@MaTL", s.maTL);
                cmd.Parameters.AddWithValue("@MaTG", s.maTG);
                cmd.Parameters.AddWithValue("@DonGiaBan", s.donGiaBan);
                cmd.Parameters.AddWithValue("@SoLuongCo", s.soluongCo);
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
