using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
   public class ChiTietHoaDon 
    {
        private string SHD;   
        public string shd
        {
            get { return SHD; }
            set { SHD = value; }
        }
        private string MaSach;
        public string maSach
        {
            get { return MaSach; }
            set { MaSach = value; }
        }
        private int SoLuongBan;
        public int soLuongBan
        {
            get { return SoLuongBan; }
            set { SoLuongBan = value; }
        }
        private float DonGiaBan;
        public float donGiaBan
        {
            get { return DonGiaBan; }
            set { DonGiaBan = value; }
        }
        //constuctor
        public ChiTietHoaDon(string SHD, string MaSach, int SoLuongBan, float DonGia)
        {
            this.SHD = SHD;
            this.MaSach = MaSach;
            this.SoLuongBan = SoLuongBan;
            this.DonGiaBan = DonGia;
        }
    }
}
