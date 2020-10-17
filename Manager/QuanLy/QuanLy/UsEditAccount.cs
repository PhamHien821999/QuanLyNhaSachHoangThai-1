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
using QuanLy.DTO;

namespace QuanLy
{
    public partial class UsEditAccount : UserControl
    {
        LoginBUL login = new LoginBUL();
        public UsEditAccount()
        {
            InitializeComponent();
        }

        private void UsEditAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ClearTextBox()
        {
            txtUserName.Clear();
            txtPass.Clear();
            cbBox_LoaiTaiKhoan.SelectedIndex = -1;
        }
        private void LoadData()
        {
            dGV_Account.DataSource = login.getAccount();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text != "" && txtPass.Text != "" && cbBox_LoaiTaiKhoan.Text != "")
            {
                //Tạo 1 DTO Login
                Account Acc = new Account(txtUserName.Text, txtPass.Text, cbBox_LoaiTaiKhoan.Text);
                //them tai khoan
                if (login.themTaiKhoan(Acc))
                {
                    MessageBox.Show("Thêm Tài Khoản Mới Thành Công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công ");
                }
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin đầy đủ trước khi thêm tài khoản");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPass.Text != "" && cbBox_LoaiTaiKhoan.Text != "")
            {
                //Tạo 1 DTO Login
                Account Acc1 = new Account(txtUserName.Text, txtPass.Text, cbBox_LoaiTaiKhoan.Text);
                //sua tai khoan
                if (login.suaTaiKhoan(Acc1))
                {
                    MessageBox.Show("Sửa Tài Khoản Thành Công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công ");
                }
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Hãy chọn Tài Khoản Muốn sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

           if(txtUserName.Text !="")
            {
                //Tạo 1 DTO Login
                Account Acc2 = new Account(txtUserName.Text, txtPass.Text, cbBox_LoaiTaiKhoan.Text);
                //sua tai khoan
                if (login.xoaTaiKhoan(Acc2))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                ClearTextBox();
            }

            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }

        }

        private void dGV_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dGV_Account.CurrentRow.Cells["TenTK"].Value.ToString();
            txtPass.Text = dGV_Account.CurrentRow.Cells["MatKhau"].Value.ToString();
            cbBox_LoaiTaiKhoan.Text = dGV_Account.CurrentRow.Cells["LoaiTaiKhoan"].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
