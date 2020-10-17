using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class Sach : TheLoai
    {
        private string MaSach;
        public string maSach
        {
            get { return MaSach; }
            set { MaSach = value; }
        }
        private string TenSach;
        public string tenSach
        {
            get { return TenSach; }
            set { TenSach= value; }
        }
        private float DonGiaBan;
        public float donGiaBan
        {
            get { return DonGiaBan; }
            set { DonGiaBan = value; }
        }
        private int SoLuongCo;
        public int soluongCo
        {
            get { return SoLuongCo; }
            set { SoLuongCo = value; }
        }
        //constructor
        public Sach() { }
        public Sach(string MaSach, string TenSach, int SoLuongCo, float DonGiaBan)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.SoLuongCo = SoLuongCo;
            this.DonGiaBan = DonGiaBan;
        }
        public Sach(string MaSach, string TenSach, int SoLuongCo, float DonGiaBan,string MaTL, string TenTL, string MaTG, string TenTG): base(MaTL, TenTL, MaTG, TenTG)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.SoLuongCo = SoLuongCo;
            this.DonGiaBan = DonGiaBan;
        }
        public Sach(string MaSach, string TenSach, string MaTL, string MaTG, float DonGiaBan, int SoLuongCo)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.maTL = MaTL;
            this.maTG = MaTG;
            this.DonGiaBan = DonGiaBan;
            this.SoLuongCo = SoLuongCo;

        }
        public Sach(string MaSach, float DonGia)
        {
            this.MaSach = MaSach;
            this.DonGiaBan = DonGia;

        }
    }
}
