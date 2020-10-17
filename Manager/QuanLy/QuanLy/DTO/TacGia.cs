using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
   public  class  TacGia
    {
        private string MaTG;
        public string maTG
        {
            get { return MaTG; }
            set { MaTG = value; }
        }
        private string TenTG;
        public string tenTG
        {
            get { return TenTG; }
            set { TenTG = value; }
        }
        //constructor
        public TacGia() { }
        public TacGia(string MaTG, string TenTG)
        {
            this.MaTG = MaTG;
            this.TenTG = TenTG;
        }
    }
}
