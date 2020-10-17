using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuanLy.DTO;
using System.Windows.Forms;

namespace QuanLy.DAL
{
    public class LoginDAL
    {
        Connection connection = new Connection();
        SqlConnection con1 ;
        public string getID(string username, string pass)
        {
            string LoaiTaiKhoan = "";
            try
            {
                con1 = connection.getConnection();
                con1.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenTK ='" + username + "' and MatKhau='" + pass + "'", con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        LoaiTaiKhoan = dr["LoaiTaiKhoan"].ToString();
                    }
                }
                con1.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!xin vui lòng kiểm tra lại");
            }
            return LoaiTaiKhoan;
        }
        public DataTable LoadData()
        {
            return connection.LoadData("Select * from TaiKhoan");

        }
        public bool themAccount(Account Acc)
        {
            con1 = connection.getConnection();
            try
            {
                // Ket noi
                con1.Open();

                // Query string 
                string SQL = string.Format("INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTaiKhoan) VALUES (@TenTK, @MatKhau, @LoaiTaiKhoan)");

                // Command 
                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MatKhau", Acc.passWord);
                cmd.Parameters.AddWithValue("@LoaiTaiKhoan", Acc.loaiTaiKhoan);
                cmd.Parameters.AddWithValue("@TenTK", Acc.userName);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception )
            {

            }
            finally
            {
                // Dong ket noi
                con1.Close();
            }
            return false;
        }
        public bool SuaAccount(Account Acc)
        {
            con1 = connection.getConnection();
            try
            {
                // Ket noi
                con1.Open();

                // Query string
                string SQL = string.Format("UPDATE TaiKhoan SET MatKhau =@MatKhau, LoaiTaiKhoan = @LoaiTaiKhoan WHERE TenTK = @TenTk ");

                // Command 
                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MatKhau", Acc.passWord);
                cmd.Parameters.AddWithValue("@LoaiTaiKhoan", Acc.loaiTaiKhoan);
                cmd.Parameters.AddWithValue("@TenTK", Acc.userName);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception )
            {

            }
            finally
            {
                // Dong ket noi
                con1.Close();
            }

            return false;
        }
        public bool XoaAccount(Account Acc)
        {
            con1 = connection.getConnection();
            try
            {
                // Ket noi
                con1.Open();

                // Query string - vì xóa chỉ cần tenTk nên chúng ta ko cần 1 DTO, UserName là đủ
                string SQL = string.Format("DELETE FROM TaiKhoan WHERE TenTK = @TenTK");

                // Command 
                SqlCommand cmd = new SqlCommand(SQL, con1);
                cmd.Parameters.AddWithValue("@MatKhau", Acc.passWord);
                cmd.Parameters.AddWithValue("@LoaiTaiKhoan", Acc.loaiTaiKhoan);
                cmd.Parameters.AddWithValue("@TenTK", Acc.userName);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception )
            {

            }
            finally
            {
                // Dong ket noi
                con1.Close();
            }

            return false;
        }
    }
}
