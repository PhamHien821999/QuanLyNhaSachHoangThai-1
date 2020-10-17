using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy.DAL;
using QuanLy.DTO;


namespace QuanLy.BUL
{
    class NhanVienBUL
    {
        NhanVienDAL nv = new NhanVienDAL();
        public DataTable LoadNhanVien()
        {
            return nv.LoadNhanVien();
        }
        public bool themNhanVien(NhanVien NV)
        {
            return nv.themEmployee(NV);
        }

        public bool suaNhanVien(NhanVien NV)
        {
            return nv.SuaEmployee(NV);
        }

        public bool xoaNhanVien(NhanVien NV)
        {
            return nv.XoaEmployee(NV);
        }
    }
}
