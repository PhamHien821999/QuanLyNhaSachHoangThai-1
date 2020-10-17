using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
   public class TheLoai:TacGia
    {
        private string MaTL;
        public string maTL
        {
            get { return MaTL; }
            set { MaTL = value; }
        }
        private string TenTL;
        public string tenTL
        {
            get { return TenTL; }
            set { TenTL = value; }
        }
        //constructor
        public TheLoai() { }
        public TheLoai(string MaTL, string TenTL)
        {
            this.MaTL = MaTL;
            this.TenTL = TenTL;
        }
        public TheLoai(string MaTL, string TenTL, string MaTG, string TenTG):base(MaTG, TenTG)
        {
            this.MaTL = MaTL;
            this.TenTL = TenTL;
        }
        
     
    }
}
