using QuanLy.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLy.DTO;

namespace QuanLy.BUL
{
    class LoginBUL
    {
        LoginDAL login = new LoginDAL();
        Connection connection = new Connection();
        public string getLogin(string UserName, string PassWord)
        {
            string Loaitaikhoan = login.getID(UserName, PassWord);
            return Loaitaikhoan;
        }
        public DataTable getAccount()
        {
            return login.LoadData();
        }
        public bool themTaiKhoan(Account Acc)
        {
            return login.themAccount(Acc);
        }

        public bool suaTaiKhoan(Account Acc)
        {
            return login.SuaAccount(Acc);
        }

        public bool xoaTaiKhoan(Account Acc)
        {
            return login.XoaAccount(Acc);
        }
    }
}
