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
using QuanLy.DAL;
using System.Data.SqlClient;

namespace QuanLy
{
    public partial class UsKinhDoanh : UserControl
    {
        HoaDonBUL HD = new HoaDonBUL();
        PhieuNhapHangBUL PN = new PhieuNhapHangBUL();
        public UsKinhDoanh()
        {
            InitializeComponent();
        }

        //Load dữ liệu
        private void UsKinhDoanh_Load(object sender, EventArgs e)
        {
            ClearTextBoxHD();
            LoadComboBox_NhanVien();
            LoadComboBox_KhachHang();
            LoadSach();
            ClearTextBoxPN();
            LoadComboBox_NhanVien_PhieuNhap();
            Load_NhaCungCap();
            LoadSach_PhieuNhap();
            
        }

        //Gọi thông tin nhân viên lên comboBox
        private void LoadComboBox_NhanVien()
        {
            cbB_NhanVien.DataSource = HD.LoadNhanVien();
            cbB_NhanVien.DisplayMember = "TenNV";
            cbB_NhanVien.ValueMember = "MaNV";
            cbB_NhanVien.SelectedIndex = -1;

        }

        //Gọi tt khách hàng lên comboBox
        private void LoadComboBox_KhachHang()
        {
            cbB_KhachHang.DataSource = HD.loadKhachHang();
            cbB_KhachHang.DisplayMember = "TenKH";
            cbB_KhachHang.ValueMember = "MaKH";
            cbB_KhachHang.SelectedIndex = -1;

        }

        //Gọi tt sách lên comboBox
        private void LoadSach()
        {
            cbB_Sach.DataSource = HD.LoadSach();
            cbB_Sach.DisplayMember = "TenSach";
            cbB_Sach.ValueMember = "MaSach";
            cbB_Sach.SelectedIndex = -1;
        }

        //Xóa các textbox
        private void ClearTextBoxHD()
        {
            txtHD.Clear();
            cbB_KhachHang.SelectedIndex = -1;
            cbB_NhanVien.SelectedIndex = -1;
            cbB_Sach.SelectedIndex = -1;
            txtDonGiaBan.Clear();
            txtSLBan.Clear();
            dTPNgayLap.Text = DateTime.Today.ToString();
            lble_KH.Text = "";
            lbel_NgayLap.Text = "";
            lbel_NhanVien.Text = "";
            lbel_SHD.Text = "";
            txtTongTien.Clear();
        }
        private void ClearTextBoxSach()
        {
            cbB_Sach.SelectedIndex = -1;
            txtDonGiaBan.Clear();
            txtSLBan.Clear();
            txtTongTien.Text = "";
        }

        //Thiết lập button
        private void ThietLapButton(bool e)
        {
            btnTaoHD.Enabled = e;
            btnThemSP.Enabled = !e;
            btnHuy.Enabled = !e;
            btnXoaHD.Enabled = !e;
            btnTaoPhieu.Enabled = !e;
            btnThemSPN.Enabled = e;
            btnHuySPPN.Enabled = e;
            btnXoaPN.Enabled = e;
        }

        //chọn tên Sách sẽ hiển thị giá tiền lên txtGia
        private void cbB_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbB_Sach.Text != "")
            {
                txtDonGiaBan.Text = Convert.ToString(HD.getPrice(cbB_Sach.SelectedValue.ToString()));
            }
            else
            {
                txtDonGiaBan.Clear();
            }
        }

        /*
         * <i>Phần Lập Hóa Đơn<i/>
         *<p>Chức Năng: Lập hóa đơn, Xóa Hóa đơn, thêm sản phẩm cho hóa đơn, xóa sản phẩm trong hóa đơn, tạo mới lại hóa đơn<p/>
         * <p>Update: 7/5/2020</p>
         * @return H2S
         */
        //Lập hóa đơn 
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (txtHD.Text != "" && cbB_KhachHang.Text != "" && cbB_NhanVien.Text != "")
            {
                //Tạo 1 DTO Login
                HoaDon hd = new HoaDon(txtHD.Text, Convert.ToDateTime(dTPNgayLap.Value.ToString("MM/dd/yyyy")), cbB_KhachHang.SelectedValue.ToString(), cbB_NhanVien.SelectedValue.ToString());
                //them tai khoan
                if (HD.ThemHoaDon(hd))
                {
                    MessageBox.Show("Thêm hóa đơn Mới Thành Công");
                    lble_KH.Text = cbB_KhachHang.Text;
                    lbel_NhanVien.Text = cbB_NhanVien.Text;
                    lbel_NgayLap.Text = dTPNgayLap.Value.ToString("dd/MM/yyyy");
                    lbel_SHD.Text = txtHD.Text;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công ");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin đầy đủ trước khi thêm hóa đơn");
            }
        }

        //Thêm Sản Phẩm mới vào hóa đơn
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtHD.Text != "" && cbB_Sach.Text != "" && txtSLBan.Text != "")
            {
                int sl = HD.SoLuongSach(cbB_Sach.SelectedValue.ToString());
                if (sl < Convert.ToInt32(txtSLBan.Text))
                {
                    MessageBox.Show("Sách trong còn lại không đủ hết. Xin vui Lòng Chọn số Lượng sách nhỏ hơn hoặc bằng " + sl);
                }
                else
                {
                    ChiTietHoaDon hd = new ChiTietHoaDon(txtHD.Text, cbB_Sach.SelectedValue.ToString(), Convert.ToInt32(txtSLBan.Text), Convert.ToSingle(txtDonGiaBan.Text));
                        if (HD.ThemChiTietHoaDon(hd))
                        {
                            dGV_Sach.DataSource = HD.loadChiTietHoaDon(txtHD.Text);
                            MessageBox.Show("Thêm sản phẩm mới Thành Công");
                            ClearTextBoxSach();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công ");
                        }


                    }
            }
            else
                {
                MessageBox.Show("Cần nhập thông tin đầy đủ trước khi thêm sản phẩm cần mua");
            }
        }

        //Hủy sản phẩm mới thêm vào hóa đơn
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtHD.Text != "")
            {
                if (HD.XoaChiTietHoaDon(txtHD.Text))
                {
                    dGV_Sach.DataSource = HD.loadChiTietHoaDon(txtHD.Text);
                    MessageBox.Show("Xóa sản phẩm thành công");
                    ClearTextBoxSach();

                }
                else
                {
                    MessageBox.Show("xóa không thành công ");
                }
            }
            else
            {
                MessageBox.Show("Nhập Số Hóa đơn trước khi xóa");
            }
        }

        //Thanh toán tiền theo hóa đơn
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtHD.Text != "")
            { 
                txtTongTien.Text = Convert.ToString(HD.TongTien(txtHD.Text));
                //ThietLapButton(false);
            }
            else
            {
                MessageBox.Show("Thanh Toán không Thành công");
            }
        }

        //xoa hóa dơn
         private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn Chắc Chắn Muốn tạo mới hóa đơn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (HD.XoaHoaDon(txtHD.Text))
                {
                    MessageBox.Show("Xóa Hóa đơn thành công");
                    ClearTextBoxHD();
                    dGV_Sach.DataSource = HD.loadChiTietHoaDon(txtHD.Text);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
        }

        //Tạo mới hóa đơn
        private void btnTaoMoi_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxHD();
            dGV_Sach.DataSource = HD.loadChiTietHoaDon(txtHD.Text);
            //ThietLapButton(true);
        }

        /*
         * <i>Phần Phiếu Nhập hàng</i>
         * <p>Chức năng: lập phiếu, xóa phiếu, thêm sản phẩm cho phiếu, xóa sản phẩm, tạo mới phiếu</p>
         * <p>Update: 7/5/2020</p>
         * @return H2S
         * 
         */

        //Gọi thông tin nhân viên lên comboBox
        private void LoadComboBox_NhanVien_PhieuNhap()
        {
            cbBNhanVienPN.DataSource = PN.LoadNhanVien();
            cbBNhanVienPN.DisplayMember = "TenNV";
            cbBNhanVienPN.ValueMember = "MaNV";
            cbBNhanVienPN.SelectedIndex = -1;

        }

        //Gọi tt sách lên comboBox
        private void LoadSach_PhieuNhap()
        {
            cbBSachPN.DataSource = PN.LoadSach();
            cbBSachPN.DisplayMember = "TenSach";
            cbBSachPN.ValueMember = "MaSach";
            cbBSachPN.SelectedIndex = -1;
        }

        //Gọi tt Nhà cung cấp lên comboBox
        private void Load_NhaCungCap()
        {
            cbBNCC.DataSource = PN.LoadNhaCungCap();
            cbBNCC.DisplayMember = "TenNCC";
            cbBNCC.ValueMember = "MaNCC";
            cbBNCC.SelectedIndex = -1;
        }

        //Xóa textbox
        private void ClearTextBoxPN()
        {
            txtSoPhieu.Clear();
            cbBNCC.SelectedIndex = -1;
            cbBNhanVienPN.SelectedIndex = -1;
            cbBSachPN.SelectedIndex = -1;
            txtDonGiaNhap.Clear();
            txtSLNhap.Clear();
            dTPNgayLapPhieu.Text = DateTime.Today.ToString();
            lblSoPhieu.Text = "";
            lbNgayLapPN.Text = "";
            lbelNCC.Text = "";
            lbNhanVien.Text = "";
            txtTongTienPN.Clear();
        }
        private void ClearTextBoxSachPN()
        {
            cbBSachPN.SelectedIndex = -1;
            txtDonGiaNhap.Clear();
            txtSLNhap.Clear();
            txtTongTienPN.Text = "";
        }

        //Lập Phiếu nhập Sách
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.Text != "" && cbBNhanVienPN.Text != "" && cbBNCC.Text != "")
            {
                //Tạo 1 DTO Login
                PhieuNhap pn = new PhieuNhap(txtSoPhieu.Text, cbBNCC.SelectedValue.ToString(), cbBNhanVienPN.SelectedValue.ToString(),Convert.ToDateTime(dTPNgayLapPhieu.Value.ToString("MM/dd/yyyy")));
                //them tai khoan
                if (PN.ThemPhieuNhap(pn))
                {
                    MessageBox.Show("Thêm Phiếu Nhập Hàng Mới Thành Công");
                    lblSoPhieu.Text = txtSoPhieu.Text;
                    lbelNCC.Text = cbBNCC.Text;
                    lbNgayLapPN.Text =dTPNgayLapPhieu.Value.ToString("dd/MM/yyyy");
                    lbNhanVien.Text = cbBNhanVienPN.Text;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công ");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin đầy đủ trước khi thêm phiếu");
            }
        }

        //them Sản Phẩm
        private void btnThemSPN_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.Text != "" && cbBSachPN.Text != "" && txtSLNhap.Text != "" && txtDonGiaNhap.Text != "")
            {
                //Tạo 1 DTO Login
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap(txtSoPhieu.Text, cbBSachPN.SelectedValue.ToString(), Convert.ToInt32(txtSLNhap.Text), Convert.ToSingle(txtDonGiaNhap.Text));
                //them tai khoan
                if (PN.ThemChiTietPhieuNhap(ctpn))
                {
                    dGVPhieuNhap.DataSource = PN.loadChiTietPhieuNhap(txtSoPhieu.Text);
                    MessageBox.Show("Thêm sản phẩm mới Thành Công");
                    ClearTextBoxSachPN();

                }
                else
                {
                    MessageBox.Show("Thêm không thành công ");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin đầy đủ trước khi thêm sản phẩm cần nhập");
            }
        }

        //Xóa sản phẩm trong phiếu nhập
        private void btnHuySPPN_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.Text != "")
            {
                if (PN.XoaChiTietPhieuNhap(txtSoPhieu.Text))
                {
                    dGVPhieuNhap.DataSource = PN.loadChiTietPhieuNhap(txtSoPhieu.Text);
                    MessageBox.Show("Xóa sản phẩm thành công");
                    ClearTextBoxSachPN();

                }
                else
                {
                    MessageBox.Show("xóa không thành công ");
                }
            }
            else
            {
                MessageBox.Show("Nhập Số phiếu nhập trước khi xóa");
            }
        }

        //Thanh Toán 
        private void btnthanhToanPN_Click_1(object sender, EventArgs e)
        {
            if (txtSoPhieu.Text != "")
            {
                txtTongTienPN.Text = Convert.ToString(PN.TongTien(txtSoPhieu.Text));
                //ThietLapButton(false);
            }
            else
            {
                MessageBox.Show("Thanh Toán không Thành công");
            }
        }

        //Xóa Phiếu nhập
        private void btnXoaPN_Click_1(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn Chắc Chắn Muốn tạo mới hóa đơn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (PN.XoaPhieuNhap(txtSoPhieu.Text))
                {
                    MessageBox.Show("Xóa Hóa đơn thành công");
                    ClearTextBoxPN();
                    dGVPhieuNhap.DataSource = PN.loadChiTietPhieuNhap(txtSoPhieu.Text);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
        }

        //Tạo mới phiếu nhập
        private void btnTaoMoiPN_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxPN();
            dGVPhieuNhap.DataSource = PN.loadChiTietPhieuNhap(txtSoPhieu.Text);
            //ThietLapButton(true);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSLBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
