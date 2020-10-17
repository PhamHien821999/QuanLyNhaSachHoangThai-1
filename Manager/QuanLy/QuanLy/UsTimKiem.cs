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
using QuanLy.DAL;

namespace QuanLy
{
    public partial class UsTimKiem : UserControl
    {
        SachBUL book = new SachBUL();
        KhachHangBUL kh = new KhachHangBUL();
        public UsTimKiem()
        {
            InitializeComponent();
        }

        private void UsTimKiem_Load(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxSach()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
        }

        //Tìm Kiếm Sách Theo tên Sách
        private void btnSearchBook_Click(object sender, EventArgs e)
        {

            if(txtTenSach.Text != "" || txtMaSach.Text !="" )
            {
                MessageBox.Show("Tìm kiếm thành công");
                dGV_Sach.DataSource = book.TimKiemSach(txtMaSach.Text, txtTenSach.Text);

            }
            else
            {
               
                   MessageBox.Show("Bạn Phải Nhập thông tin trước khi tìm kiếm");
                }
            }

        private void btnThoatSach_Click(object sender, EventArgs e)
        {
            ClearTextBoxSach();
            dGV_Sach.DataSource = book.TimKiemSach(txtMaSach.Text, txtTenSach.Text);
            MessageBox.Show("Hủy thành công");
        }


        /*
         * Tìm kiếm theo khách hàng
         * 
         */
         private void ClearTextBoxKhachHang()
        {
            txtTenKH.Clear();
            txtSDT.Clear();
        }
        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" || txtSDT.Text != "")
            {
                MessageBox.Show("Tìm Kiếm thành công");
                dGV_KhachHang.DataSource = kh.TimKiemKhachHang(txtTenKH.Text, txtSDT.Text);

            }
            else
            {
                MessageBox.Show("Bạn Phải Nhập thông tin trước khi tìm kiếm");

            }
        }

        private void btnHuyKH_Click(object sender, EventArgs e)
        {
            ClearTextBoxKhachHang();
            dGV_KhachHang.DataSource = kh.TimKiemKhachHang(txtTenKH.Text, txtSDT.Text);
            MessageBox.Show("Hủy thành công");
        }
       
    }
}
