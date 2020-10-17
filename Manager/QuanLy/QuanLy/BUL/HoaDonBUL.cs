using QuanLy.DAL;
using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.BUL
{
  public  class HoaDonBUL
    {
        HoaDonDAL HD = new HoaDonDAL();
        public DataTable loadChiTietHoaDon(string SHD)
        {
            return HD.Load(SHD);
        }
        public DataTable LoadNhanVien()
        {
            return HD.LoadNhanVien();
        }
        public DataTable loadKhachHang()
        {
            return HD.LoadKhachHang();
        }
        public DataTable LoadSach()
        {
            return HD.LoadSach();
        }
        public bool ThemHoaDon(HoaDon hd)
        {
            return HD.ThemHD(hd);
        }
        public double getPrice(string st)
        {
            return HD.getPrice(st);
        }
        public bool ThemChiTietHoaDon(ChiTietHoaDon cthd)
        {
            return HD.ThemChiTietHoaDon(cthd);
        }
        public bool XoaChiTietHoaDon(string SHD)
        {
            return HD.XoaChiTietHoaDon(SHD);
        }
        public long TongTien(string SHD)
        {
            return HD.TongTien(SHD);
        }
        public bool XoaHoaDon(string SHD)
        {
            return HD.XoaHoaDon(SHD);
        }
        public DataTable ChiTietHoaDon(string SoHD)
        {
            return HD.LoadChiTietHoaDon(SoHD);
        }
        public int SoLuongSach(string MaSach)
        {
            return HD.LoadSLSach(MaSach);
        }
        //Cập nhật số lượng sp
        public bool UpDateSLBan(DataTable tb)
        {
            
            int SLCu = 0;
            int SLMoi = 0;
            DataTable tbSach = new DataTable();
            tbSach = LoadSach();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                for (int j = 0; j < tbSach.Rows.Count; j++)
                {
                    if (tbSach.Rows[j][0].ToString() == tb.Rows[i][1].ToString())
                    {
                        SLCu = int.Parse(tbSach.Rows[j][5].ToString());
                        SLMoi = int.Parse(tbSach.Rows[j][5].ToString()) - int.Parse(tb.Rows[i][2].ToString());
                        if (!HD.UpdateSPBan(tb.Rows[j][0].ToString(), SLMoi))
                            return false;
                        break;
                    }
                }
            }
            return true;
        }
    }
}
