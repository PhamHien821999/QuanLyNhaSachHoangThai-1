using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
   public class PhieuNhap
    {
        private string SoPhieu;
        public string soPhieu
        {
            get { return SoPhieu; }
            set { SoPhieu = value; }
        }
        private string NhaCungCap;
        public string nhaCungCap
        {
            get { return NhaCungCap; }
            set { NhaCungCap = value; }
        }
        private string NhanVien;
        public string nhanVien
        {
            get { return NhanVien; }
            set { NhanVien = value; }
        }
        private DateTime NgayNhap;
        public DateTime ngayNhap
        {
            get { return NgayNhap; }
            set { NgayNhap = value; }
        }
        //constructor 
        public PhieuNhap() { }
        public PhieuNhap(string SoPhieu, string NhaCungCap, string NhanVien, DateTime NgayNhap)
        {
            this.SoPhieu = SoPhieu;
            this.NhaCungCap = NhaCungCap;
            this.NhanVien = NhanVien;
            this.NgayNhap = NgayNhap;
        }

    }
}
