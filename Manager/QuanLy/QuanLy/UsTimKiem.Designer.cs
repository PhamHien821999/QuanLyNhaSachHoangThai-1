namespace QuanLy
{
    partial class UsTimKiem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl_TimKiem = new System.Windows.Forms.TabControl();
            this.tabPg_Sach = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dGV_Sach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoatSach = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPg_KhachHang = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dGV_KhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHuyKH = new System.Windows.Forms.Button();
            this.btnSearchKH = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tabControl_TimKiem.SuspendLayout();
            this.tabPg_Sach.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sach)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPg_KhachHang.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_KhachHang)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 20);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl_TimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 494);
            this.panel2.TabIndex = 1;
            // 
            // tabControl_TimKiem
            // 
            this.tabControl_TimKiem.Controls.Add(this.tabPg_Sach);
            this.tabControl_TimKiem.Controls.Add(this.tabPg_KhachHang);
            this.tabControl_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_TimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_TimKiem.Location = new System.Drawing.Point(0, 0);
            this.tabControl_TimKiem.Name = "tabControl_TimKiem";
            this.tabControl_TimKiem.SelectedIndex = 0;
            this.tabControl_TimKiem.Size = new System.Drawing.Size(783, 494);
            this.tabControl_TimKiem.TabIndex = 0;
            // 
            // tabPg_Sach
            // 
            this.tabPg_Sach.Controls.Add(this.panel4);
            this.tabPg_Sach.Controls.Add(this.panel3);
            this.tabPg_Sach.Location = new System.Drawing.Point(4, 25);
            this.tabPg_Sach.Name = "tabPg_Sach";
            this.tabPg_Sach.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_Sach.Size = new System.Drawing.Size(775, 465);
            this.tabPg_Sach.TabIndex = 0;
            this.tabPg_Sach.Text = "Sách";
            this.tabPg_Sach.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dGV_Sach);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(769, 304);
            this.panel4.TabIndex = 4;
            // 
            // dGV_Sach
            // 
            this.dGV_Sach.AllowUserToAddRows = false;
            this.dGV_Sach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dGV_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TenTL,
            this.TenTG,
            this.DonGiaBan,
            this.SoLuongCo});
            this.dGV_Sach.Location = new System.Drawing.Point(49, 44);
            this.dGV_Sach.Name = "dGV_Sach";
            this.dGV_Sach.Size = new System.Drawing.Size(663, 240);
            this.dGV_Sach.TabIndex = 11;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 90;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Width = 120;
            // 
            // TenTL
            // 
            this.TenTL.DataPropertyName = "TenTL";
            this.TenTL.HeaderText = "Thể Loại";
            this.TenTL.Name = "TenTL";
            this.TenTL.ReadOnly = true;
            this.TenTL.Width = 90;
            // 
            // TenTG
            // 
            this.TenTG.DataPropertyName = "TenTG";
            this.TenTG.HeaderText = "Tác Giả";
            this.TenTG.Name = "TenTG";
            this.TenTG.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn Giá Bán";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.ReadOnly = true;
            this.DonGiaBan.Width = 120;
            // 
            // SoLuongCo
            // 
            this.SoLuongCo.DataPropertyName = "SoLuongCo";
            this.SoLuongCo.HeaderText = "Số Lượng Có";
            this.SoLuongCo.Name = "SoLuongCo";
            this.SoLuongCo.ReadOnly = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(223, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(233, 38);
            this.label22.TabIndex = 0;
            this.label22.Text = "Danh Sách Sách";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThoatSach);
            this.panel3.Controls.Add(this.btnSearchBook);
            this.panel3.Controls.Add(this.txtTenSach);
            this.panel3.Controls.Add(this.txtMaSach);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 155);
            this.panel3.TabIndex = 2;
            // 
            // btnThoatSach
            // 
            this.btnThoatSach.BackColor = System.Drawing.Color.Maroon;
            this.btnThoatSach.Location = new System.Drawing.Point(429, 104);
            this.btnThoatSach.Name = "btnThoatSach";
            this.btnThoatSach.Size = new System.Drawing.Size(94, 32);
            this.btnThoatSach.TabIndex = 9;
            this.btnThoatSach.Text = "Hủy";
            this.btnThoatSach.UseVisualStyleBackColor = false;
            this.btnThoatSach.Click += new System.EventHandler(this.btnThoatSach_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchBook.Location = new System.Drawing.Point(242, 104);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(94, 32);
            this.btnSearchBook.TabIndex = 7;
            this.btnSearchBook.Text = "Tìm Kiếm";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(102, 52);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(211, 22);
            this.txtTenSach.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(102, 17);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(211, 22);
            this.txtMaSach.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Tên Sách:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã Sách:";
            // 
            // tabPg_KhachHang
            // 
            this.tabPg_KhachHang.Controls.Add(this.panel6);
            this.tabPg_KhachHang.Controls.Add(this.panel5);
            this.tabPg_KhachHang.Location = new System.Drawing.Point(4, 25);
            this.tabPg_KhachHang.Name = "tabPg_KhachHang";
            this.tabPg_KhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_KhachHang.Size = new System.Drawing.Size(775, 465);
            this.tabPg_KhachHang.TabIndex = 1;
            this.tabPg_KhachHang.Text = "Khách Hàng";
            this.tabPg_KhachHang.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dGV_KhachHang);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(3, 158);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(769, 304);
            this.panel6.TabIndex = 2;
            // 
            // dGV_KhachHang
            // 
            this.dGV_KhachHang.AllowUserToAddRows = false;
            this.dGV_KhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dGV_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.GioiTinhKH,
            this.DiaChi,
            this.SDT});
            this.dGV_KhachHang.Location = new System.Drawing.Point(59, 44);
            this.dGV_KhachHang.Name = "dGV_KhachHang";
            this.dGV_KhachHang.Size = new System.Drawing.Size(653, 239);
            this.dGV_KhachHang.TabIndex = 10;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 120;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 150;
            // 
            // GioiTinhKH
            // 
            this.GioiTinhKH.DataPropertyName = "GioiTinh";
            this.GioiTinhKH.HeaderText = "Giới tính";
            this.GioiTinhKH.Name = "GioiTinhKH";
            this.GioiTinhKH.ReadOnly = true;
            this.GioiTinhKH.Width = 120;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 120;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh Sách Khách Hàng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHuyKH);
            this.panel5.Controls.Add(this.btnSearchKH);
            this.panel5.Controls.Add(this.txtTenKH);
            this.panel5.Controls.Add(this.txtSDT);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(769, 155);
            this.panel5.TabIndex = 1;
            // 
            // btnHuyKH
            // 
            this.btnHuyKH.BackColor = System.Drawing.Color.Maroon;
            this.btnHuyKH.Location = new System.Drawing.Point(435, 96);
            this.btnHuyKH.Name = "btnHuyKH";
            this.btnHuyKH.Size = new System.Drawing.Size(94, 43);
            this.btnHuyKH.TabIndex = 7;
            this.btnHuyKH.Text = "Hủy";
            this.btnHuyKH.UseVisualStyleBackColor = false;
            this.btnHuyKH.Click += new System.EventHandler(this.btnHuyKH_Click);
            // 
            // btnSearchKH
            // 
            this.btnSearchKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchKH.Location = new System.Drawing.Point(218, 96);
            this.btnSearchKH.Name = "btnSearchKH";
            this.btnSearchKH.Size = new System.Drawing.Size(94, 43);
            this.btnSearchKH.TabIndex = 6;
            this.btnSearchKH.Text = "Tìm Kiếm";
            this.btnSearchKH.UseVisualStyleBackColor = false;
            this.btnSearchKH.Click += new System.EventHandler(this.btnSearchKH_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(157, 20);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(190, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(501, 17);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(195, 22);
            this.txtSDT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // UsTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsTimKiem";
            this.Size = new System.Drawing.Size(783, 514);
            this.Load += new System.EventHandler(this.UsTimKiem_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl_TimKiem.ResumeLayout(false);
            this.tabPg_Sach.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPg_KhachHang.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_KhachHang)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl_TimKiem;
        private System.Windows.Forms.TabPage tabPg_Sach;
        private System.Windows.Forms.TabPage tabPg_KhachHang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dGV_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dGV_Sach;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnThoatSach;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnHuyKH;
        private System.Windows.Forms.Button btnSearchKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCo;
    }
}
