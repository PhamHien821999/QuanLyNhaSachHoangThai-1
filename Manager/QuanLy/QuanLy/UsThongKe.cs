using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy.BUL;

namespace QuanLy
{
    public partial class UsThongKe : UserControl
    {
        ThongKeBUL tk = new ThongKeBUL();
        public UsThongKe()
        {
            InitializeComponent();
        }

        private void UsThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if(dTP_From.Value != dTP_To.Value)
            {
                dGV_ThongKe.DataSource = tk.ThongKe(Convert.ToDateTime(dTP_From.Value.ToString("MM/dd/yyyy")), Convert.ToDateTime(dTP_To.Value.ToString("MM/dd/yyyy")));
                txtTongTien.Text = Convert.ToString(tk.tongtien(Convert.ToDateTime(dTP_From.Value.ToString("MM/dd/yyyy")), Convert.ToDateTime(dTP_To.Value.ToString("MM/dd/yyyy"))));
                MessageBox.Show("Thống kê thành công!");
            }
            else
            {
                MessageBox.Show("Thống kê thất bại!");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            dTP_From.Value = Convert.ToDateTime(DateTime.Today.ToString());
            dTP_To.Value = Convert.ToDateTime(DateTime.Today.ToString());
            txtTongTien.Clear();
            dGV_ThongKe.DataSource = tk.ThongKe(Convert.ToDateTime(dTP_From.Value.ToString("MM/dd/yyyy")), Convert.ToDateTime(dTP_To.Value.ToString("MM/dd/yyyy")));
            MessageBox.Show("Hủy thành công");
        }
    }
}
