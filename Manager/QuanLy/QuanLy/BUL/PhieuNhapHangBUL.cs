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
    public class PhieuNhapHangBUL
    {
        PhieuNhapHangDAL PhieuNhap = new PhieuNhapHangDAL();
        public DataTable loadChiTietPhieuNhap(string SoPhieu)
        {
            return PhieuNhap.LoadPhieuNhap(SoPhieu);
        }
        public DataTable LoadNhanVien()
        {
            return PhieuNhap.LoadNhanVien();
        }
        public DataTable LoadSach()
        {
            return PhieuNhap.LoadSach();
        }
        public DataTable LoadNhaCungCap()
        {
            return PhieuNhap.LoadNhaCungCap();
        }
        public bool ThemPhieuNhap(PhieuNhap pn)
        {
            return PhieuNhap.ThemPhieuNhap(pn);
        }
        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap ctpn)
        {
            return PhieuNhap.ThemChiTietPhieuNhap(ctpn);
        }
        public bool XoaChiTietPhieuNhap(string SoPhieu)
        {
            return PhieuNhap.XoaChiTietPhieuNhap(SoPhieu);
        }
        public long TongTien(string SoPhieu)
        {
            return PhieuNhap.TongTien(SoPhieu);
        }
        public bool XoaPhieuNhap(string SoPhieu)
        {
            return PhieuNhap.XoaPhieuNhap(SoPhieu);
        }
    }
}
