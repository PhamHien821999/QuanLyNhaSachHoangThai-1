using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
  public  class NhaCungCap
    {
        private string MaNCC;
        public string maNCC
        {
            get { return MaNCC; }
            set { MaNCC = value; }
        }
        private string TenNCC;
        public string tenNCC
        {
            get { return TenNCC; }
            set { TenNCC = value; }
        }
        private string DiaChi;
        public string diaChi
        {
            get { return DiaChi; }
            set { diaChi = value; }
        }
        private string SDT;
        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }
        //constructor
        public NhaCungCap() { }
        public NhaCungCap(string MaNCC, string TenNCC, string DiaChi, string SDT)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
        }
    }
}
