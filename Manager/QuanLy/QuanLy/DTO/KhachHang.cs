using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class KhachHang
    {
        private string MaKH;
        public string maKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }

        private string TenKH;
        public string tenKH
        {
            get { return TenKH; }
            set { TenKH = value; }
        }
        private string GioiTinh;
        public string gioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
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
        public KhachHang()
        {
        }
        public KhachHang(string MaKH, string TenKH, string GioiTinh, string DiaChi, string SDT )
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
        }
    }
}
