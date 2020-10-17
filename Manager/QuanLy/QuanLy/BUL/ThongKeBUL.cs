using QuanLy.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.BUL
{
    public class ThongKeBUL
    {
        ThongKeDAL tk = new ThongKeDAL();
        public DataTable ThongKe(DateTime d1, DateTime d2)
        {
            return tk.ThongKe(d1,d2);
        }
        public float tongtien(DateTime d1, DateTime d2)
        {
            return tk.TongTien(d1,d2);
        }
    }
}
