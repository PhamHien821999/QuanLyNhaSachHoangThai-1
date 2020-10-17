using QuanLy.BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class frmManager : Form
    {
        LoginBUL login = new LoginBUL();
        public frmManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GiaodienChinh();
            DisEnabledLgoin(true);
        }
        private void GiaodienChinh()
        {
            palHienThi.Controls.Clear();
            UsImagesInterFace fm = new UsImagesInterFace();
            fm.Dock = System.Windows.Forms.DockStyle.Fill;
            palHienThi.Controls.Add(fm);

        }
        public void DisEnabledLgoin(bool e)
        {
            btnLogin.Enabled = e;
            btnClose.Enabled = !e;
            btnTrangChu.Enabled = !e;
            btnKinhDoanh.Enabled = !e;
            btnQuanLy.Enabled = !e;
            btnEditAccount.Enabled = !e;
            btnThongKe.Enabled = !e;
            btnTimKiem.Enabled = !e;
        }
        private void phanQuyen(bool e)
        {
            btnLogin.Enabled = !e;
            btnClose.Enabled = e;
            btnTrangChu.Enabled = e;
            btnKinhDoanh.Enabled = e;
            btnQuanLy.Enabled = !e;
            btnEditAccount.Enabled = !e;
            btnThongKe.Enabled = !e;
            btnTimKiem.Enabled = e;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            //gọi form login
            frmLogin fLogin = null;
            //khai bao 1 layble để gọi lại form
            checkLogin:
            if (fLogin == null || fLogin.IsDisposed)
                fLogin = new frmLogin();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                //kiểm tra textbox
                if (fLogin.txtUserName.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào tên đăng nhập! ");
                    goto checkLogin;
                }
                //kiểm tra textbox
                if (fLogin.txtPass.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào mật khẩu! ");
                    goto checkLogin;
                }

                string check = "";
                string userName = fLogin.txtUserName.Text;
                string pass = fLogin.txtPass.Text;
                check = login.getLogin(userName, pass);
                if (check == "")
                {
                    MessageBox.Show("Đăng nhập thất bại. Kiểm tra lại tên đăng nhập hoặc mật khẩu");
                    goto checkLogin;
                }
                else
                {
                    if (check == "Quản Lý")
                    {
                        DisEnabledLgoin(false);
                        MessageBox.Show("Đăng nhập thành công với quyền quản lý");
                        this.Show();
                    }
                    else
                    {
                        phanQuyen(true);
                        MessageBox.Show("Đăng nhập thành công với quyền nhân viên");
                        this.Show();
                    }    
                }
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn thoát đăng nhập ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    DisEnabledLgoin(true);
                    GiaodienChinh();
                }
                this.Show();
            }

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            palHienThi.Controls.Clear();
            UsEditAccount fm = new  UsEditAccount();
            fm.Dock = System.Windows.Forms.DockStyle.Fill;
            palHienThi.Controls.Add(fm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                DisEnabledLgoin(true);
                GiaodienChinh();
                 
            }
        }

        private void frmManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No)
            {
                e.Cancel = true;  
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            GiaodienChinh();
        }

        private void btnKinhDoanh_Click(object sender, EventArgs e)
        {
            palHienThi.Controls.Clear();
            UsKinhDoanh fm = new UsKinhDoanh();
            fm.Dock = System.Windows.Forms.DockStyle.Fill;
            palHienThi.Controls.Add(fm);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            palHienThi.Controls.Clear();
            UsTimKiem frm = new UsTimKiem();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            palHienThi.Controls.Add(frm);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            palHienThi.Controls.Clear();
            UsQuanLy frm = new UsQuanLy();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            palHienThi.Controls.Add(frm);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            palHienThi.Controls.Clear();
            UsThongKe frm = new UsThongKe();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            palHienThi.Controls.Add(frm);
        }

        private void palHienThi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
