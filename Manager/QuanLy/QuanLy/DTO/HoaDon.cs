using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class HoaDon
    {
        private string SHD;
        public string shd
        {
            get { return SHD; }
            set { SHD = value; }
        }
        private DateTime NgayLap;
        public DateTime ngayLap
        {
            get { return NgayLap; }
            set { NgayLap = value; }
        }
        private string KhachHang;
        public string khachhang
        {
            get { return KhachHang; }
            set { KhachHang = value; }
        }

        private string NhanVien;

        public string nhanVien
        {
            get { return NhanVien; }
            set { NhanVien = value; }
        }
        //constructor
        public HoaDon() { }
        public HoaDon(string SHD, DateTime NgayLap, string KhachHang, string NhanVien)
        {
            this.SHD = SHD;
            this.NgayLap = NgayLap;
            this.KhachHang = KhachHang;
            this.NhanVien = NhanVien;
        }
    }
}
