using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class ChiTietPhieuNhap
    {
        private string SoPhieu;
        public string soPhieu
        {
            get { return SoPhieu; }
            set { SoPhieu = value; }
        }
        private string MaSach;
        public string maSach
        {
            get { return MaSach; }
            set { MaSach = value; }
        }
        private int SoLuongNhap;
        public int soLuongNhap
        {
            get { return SoLuongNhap; }
            set { SoLuongNhap = value; }
        }
        private float DonGiaNhap;
        public float donGiaNhap
        {
            get { return DonGiaNhap; }
            set { DonGiaNhap = value; }
        }
        //constructor
        public ChiTietPhieuNhap() { }
        public ChiTietPhieuNhap(string SoPhieu, string MaSach, int SoLuongNhap, float DonGiaNhap) 
        {
            this.SoPhieu = SoPhieu;
            this.MaSach = MaSach;
            this.SoLuongNhap = SoLuongNhap;
            this.DonGiaNhap = DonGiaNhap;

        }
    }
}
