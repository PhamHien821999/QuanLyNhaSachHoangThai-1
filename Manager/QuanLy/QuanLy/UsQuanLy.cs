using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy.DTO;
using QuanLy.BUL;

namespace QuanLy
{
    public partial class UsQuanLy : UserControl
    {
        NhanVienBUL nv = new NhanVienBUL();
        SachBUL sach = new SachBUL();
        public UsQuanLy()
        {
            InitializeComponent();
        }

        private void UsQuanLy_Load(object sender, EventArgs e)
        {
            dGV_NhanVien.DataSource= nv.LoadNhanVien();
            dGV_Sach.DataSource = sach.LoadSach();
            //ComboBox_theLoai();
           // comboBox_TacGia();
        }
        //hàm clearTextBoxx
        private void ClearTextBox()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtGioiTinh.Clear();
            dTG_NgaySinh.Value = Convert.ToDateTime(DateTime.Today.ToString());
            txtDiaChi.Clear();
            txtSDTNV.Clear();
        }
        private void btnThem_NhanVien_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text != "" && txtTenNV.Text != ""&& txtGioiTinh.Text !="" && txtDiaChi.Text !="" && txtSDTNV.Text !="")
            {
                NhanVien nhanvien;
                nhanvien = new NhanVien(txtMaNV.Text, txtTenNV.Text,txtGioiTinh.Text,Convert.ToDateTime(dTG_NgaySinh.Value.ToString("MM/dd/yyyy")), txtDiaChi.Text, txtSDTNV.Text);
                if(nv.themNhanVien(nhanvien))
                {
                    dGV_NhanVien.DataSource = nv.LoadNhanVien();
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công!");
                }
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Nhập thông tin trước khi thêm mới!");
            }    
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtGioiTinh.Text !="" && txtTenNV.Text != "" && txtDiaChi.Text != "" && txtSDTNV.Text != "")
            {
                NhanVien nhanvien = new NhanVien(txtMaNV.Text, txtTenNV.Text, txtGioiTinh.Text, Convert.ToDateTime(dTG_NgaySinh.Value.ToString("MM/dd/yyyy")), txtDiaChi.Text, txtSDTNV.Text);

                if (nv.suaNhanVien(nhanvien))
                {
                    dGV_NhanVien.DataSource = nv.LoadNhanVien();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Nhập thông tin trước khi sửa!");
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" )
            {
                NhanVien nhanvien = new NhanVien(txtMaNV.Text, txtTenNV.Text, txtGioiTinh.Text, Convert.ToDateTime(dTG_NgaySinh.Value.ToString("MM/dd/yyyy")), txtDiaChi.Text, txtSDTNV.Text);
                if (nv.xoaNhanVien(nhanvien))
                {
                    dGV_NhanVien.DataSource = nv.LoadNhanVien();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin trước khi xóa!");
            }
        }

        private void dGV_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dGV_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = dGV_NhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            txtGioiTinh.Text = dGV_NhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            dTG_NgaySinh.Text = dGV_NhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dGV_NhanVien.CurrentRow.Cells["diaChiNV"].Value.ToString();
            txtSDTNV.Text = dGV_NhanVien.CurrentRow.Cells["SDTNV"].Value.ToString();
        }
        /*
         * Quản lý nhà sách
         * 
         */
         /*
         private void ComboBox_theLoai()
        {
            cbb_TheLoai.DataSource = sach.TheLoai();
            cbb_TheLoai.DisplayMember = "TenTL";
            cbb_TheLoai.ValueMember = "MaTL";
            cbb_TheLoai.SelectedIndex = -1;
        }

        private void comboBox_TacGia()
        {
            cbb_TacGia.DataSource = sach.TacGia();
            cbb_TacGia.DisplayMember = "TenTG";
            cbb_TacGia.ValueMember = "MaTG";
            cbb_TacGia.SelectedIndex = -1;
        }
        */
        private void ClearText()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoLuong.Clear();
            txtPrice.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtSoLuong.Text != "" && txtPrice.Text != "" && txtTheLoai.Text != "" && txtTacGia.Text != "")
            {
                Sach s =  new Sach(txtMaSach.Text, txtTenSach.Text, txtTheLoai.Text, txtTacGia.Text, Convert.ToSingle(txtPrice.Text), Convert.ToInt32(txtSoLuong.Text));
                if (sach.ThemSach(s))
                {
                    dGV_Sach.DataSource = sach.LoadSach();
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công!");
                }
                ClearText();
            }
            else
            {
                MessageBox.Show("Nhập thông tin trước khi thêm mới!");
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtSoLuong.Text != "" && txtPrice.Text != "" && txtTheLoai.Text != "" && txtTacGia.Text != "")
            {
                Sach s = new Sach(txtMaSach.Text, txtTenSach.Text, txtTheLoai.Text, txtTacGia.Text, Convert.ToSingle(txtPrice.Text), Convert.ToInt32(txtSoLuong.Text));
                if (sach.SuaSach(s))
                {
                    dGV_Sach.DataSource = sach.LoadSach();
                    MessageBox.Show(" sửa thành công!");
                }
                else
                {
                    MessageBox.Show("sửa không thành công!");
                }
                ClearText();
            }
            else
            {
                MessageBox.Show("Nhập thông tin trước khi sửa!");
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtSoLuong.Text != "" && txtPrice.Text != "" && txtTheLoai.Text != "" && txtTacGia.Text != "")
            {
                Sach s = new Sach(txtMaSach.Text, txtTenSach.Text,txtTheLoai.Text, txtTacGia.Text, Convert.ToSingle(txtPrice.Text), Convert.ToInt32(txtSoLuong.Text));
                if (sach.XoaSach(s))
                {
                    dGV_Sach.DataSource = sach.LoadSach();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                ClearText();
            }
            else
            {
                MessageBox.Show("Nhập thông tin trước khi xóa!");
            }
        }

        private void dGV_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dGV_Sach.CurrentRow.Cells["MaSach"].Value.ToString();
            txtTenSach.Text = dGV_Sach.CurrentRow.Cells["TenSach"].Value.ToString();
            txtSoLuong.Text = dGV_Sach.CurrentRow.Cells["SoLuongCo"].Value.ToString();
            txtPrice.Text = dGV_Sach.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtTheLoai.Text = dGV_Sach.CurrentRow.Cells["MaTL"].Value.ToString();
            txtTacGia.Text = dGV_Sach.CurrentRow.Cells["MaTG"].Value.ToString();
        }

    }
}
