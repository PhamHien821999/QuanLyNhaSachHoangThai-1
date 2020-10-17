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
    class KhachHangBUL
    {
        KhachHangDAL kh = new KhachHangDAL();
        public DataTable LoadKhachHang()
        {
            return kh.LoadKhachHang();
        }
        public DataTable TimKiemKhachHang(string tenKH, string SDT)
        {
            return kh.TimKiemKhachHang(tenKH,SDT) ;
        }
    }
}
