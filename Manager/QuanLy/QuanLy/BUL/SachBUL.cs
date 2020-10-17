using QuanLy.DAL;
using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.BUL
{
    public class SachBUL
    {
        SachDAL sach = new SachDAL();
        public DataTable TimKiemSach(string MaSach, string Tensach)
        {
            return sach.TimKiemSach(MaSach, Tensach);
        }

        public DataTable LoadSach()
        {
            return sach.LoadSach();
        }
        public DataTable TheLoai()
        {
            return sach.theLoai();
        }

        public DataTable TacGia()
        {
            return sach.TacGia();
        }

        public bool ThemSach(Sach s)
        {
            return sach.themBook(s);
        }

        public bool SuaSach(Sach s)
        {
            return sach.SuaBook(s);
        }

        public bool XoaSach(Sach s)
        {
            return sach.XoaBook(s);
        }
    }
}