using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
   public  class NhanVien
    {
        private string MaNV;
        public string maNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }

        private string TenNV;
        public string tenNV
        {
            get { return TenNV; }
            set { TenNV = value; }
        }
        private string GioiTinh;
        public string gioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        private DateTime NgaySinh;
        public DateTime ngaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        private string DiaChi;
        public string diaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        private string SDT;
        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }

       //constructor
        public NhanVien()
        {
        }
        public NhanVien(string MaNV, string TenNV, string GioiTinh, DateTime NgaySinh, string DiaChi, string SDT)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
        }
    }
}
