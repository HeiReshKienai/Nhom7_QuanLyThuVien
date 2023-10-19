namespace Nhom7_QuanLyThuVien {
    partial class frmQLSach {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQLSach = new System.Windows.Forms.DataGridView();
            this.dgvMaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhaXuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSach = new System.Windows.Forms.GroupBox();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.lblTriGia = new System.Windows.Forms.Label();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.lblMaS = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblThongTinSach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSach)).BeginInit();
            this.grbSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(882, 134);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(191, 26);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimkiem.Location = new System.Drawing.Point(806, 138);
            this.lblTimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(73, 20);
            this.lblTimkiem.TabIndex = 6;
            this.lblTimkiem.Text = "Tìm Kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(994, 494);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(77, 35);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(316, 494);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 35);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(228, 494);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(139, 494);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 35);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvQLSach
            // 
            this.dgvQLSach.AllowUserToAddRows = false;
            this.dgvQLSach.AllowUserToDeleteRows = false;
            this.dgvQLSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaS,
            this.dgvTenSach,
            this.dgvTacGia,
            this.dgvNgayXuatBan,
            this.dgvNhaXuatban,
            this.dgvTriGia,
            this.dgvNgayNhap});
            this.dgvQLSach.Location = new System.Drawing.Point(398, 164);
            this.dgvQLSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLSach.Name = "dgvQLSach";
            this.dgvQLSach.ReadOnly = true;
            this.dgvQLSach.RowHeadersWidth = 51;
            this.dgvQLSach.RowTemplate.Height = 24;
            this.dgvQLSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLSach.Size = new System.Drawing.Size(718, 327);
            this.dgvQLSach.TabIndex = 9;
            this.dgvQLSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSach_CellClick);
            // 
            // dgvMaS
            // 
            this.dgvMaS.HeaderText = "Mã Sách";
            this.dgvMaS.MinimumWidth = 6;
            this.dgvMaS.Name = "dgvMaS";
            this.dgvMaS.ReadOnly = true;
            this.dgvMaS.Width = 125;
            // 
            // dgvTenSach
            // 
            this.dgvTenSach.HeaderText = "Tên Sách";
            this.dgvTenSach.MinimumWidth = 6;
            this.dgvTenSach.Name = "dgvTenSach";
            this.dgvTenSach.ReadOnly = true;
            this.dgvTenSach.Width = 125;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.HeaderText = "Tác Giả";
            this.dgvTacGia.MinimumWidth = 6;
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.Width = 125;
            // 
            // dgvNgayXuatBan
            // 
            this.dgvNgayXuatBan.HeaderText = "Ngày Xuất Bản";
            this.dgvNgayXuatBan.MinimumWidth = 6;
            this.dgvNgayXuatBan.Name = "dgvNgayXuatBan";
            this.dgvNgayXuatBan.ReadOnly = true;
            this.dgvNgayXuatBan.Width = 125;
            // 
            // dgvNhaXuatban
            // 
            this.dgvNhaXuatban.HeaderText = "Nhà Xuất bản";
            this.dgvNhaXuatban.MinimumWidth = 6;
            this.dgvNhaXuatban.Name = "dgvNhaXuatban";
            this.dgvNhaXuatban.ReadOnly = true;
            this.dgvNhaXuatban.Width = 125;
            // 
            // dgvTriGia
            // 
            this.dgvTriGia.HeaderText = "Trị Giá";
            this.dgvTriGia.MinimumWidth = 6;
            this.dgvTriGia.Name = "dgvTriGia";
            this.dgvTriGia.ReadOnly = true;
            this.dgvTriGia.Width = 125;
            // 
            // dgvNgayNhap
            // 
            this.dgvNgayNhap.HeaderText = "Ngày Nhập";
            this.dgvNgayNhap.MinimumWidth = 6;
            this.dgvNgayNhap.Name = "dgvNgayNhap";
            this.dgvNgayNhap.ReadOnly = true;
            this.dgvNgayNhap.Width = 125;
            // 
            // grbSach
            // 
            this.grbSach.Controls.Add(this.txtTriGia);
            this.grbSach.Controls.Add(this.lblTriGia);
            this.grbSach.Controls.Add(this.txtNgayNhap);
            this.grbSach.Controls.Add(this.lblNgayNhap);
            this.grbSach.Controls.Add(this.lblTheLoai);
            this.grbSach.Controls.Add(this.txtNhaXuatBan);
            this.grbSach.Controls.Add(this.lblNhaXuatBan);
            this.grbSach.Controls.Add(this.txtNamXuatBan);
            this.grbSach.Controls.Add(this.lblNamXuatBan);
            this.grbSach.Controls.Add(this.txtTacGia);
            this.grbSach.Controls.Add(this.lblTacGia);
            this.grbSach.Controls.Add(this.txtMaS);
            this.grbSach.Controls.Add(this.lblMaS);
            this.grbSach.Controls.Add(this.txtTenSach);
            this.grbSach.Controls.Add(this.lblTenSach);
            this.grbSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSach.Location = new System.Drawing.Point(-9, 161);
            this.grbSach.Margin = new System.Windows.Forms.Padding(2);
            this.grbSach.Name = "grbSach";
            this.grbSach.Padding = new System.Windows.Forms.Padding(2);
            this.grbSach.Size = new System.Drawing.Size(403, 328);
            this.grbSach.TabIndex = 8;
            this.grbSach.TabStop = false;
            this.grbSach.Text = "Sách";
            // 
            // txtTriGia
            // 
            this.txtTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriGia.Location = new System.Drawing.Point(161, 240);
            this.txtTriGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(238, 32);
            this.txtTriGia.TabIndex = 0;
            // 
            // lblTriGia
            // 
            this.lblTriGia.AutoSize = true;
            this.lblTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriGia.Location = new System.Drawing.Point(10, 242);
            this.lblTriGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriGia.Name = "lblTriGia";
            this.lblTriGia.Size = new System.Drawing.Size(76, 26);
            this.lblTriGia.TabIndex = 1;
            this.lblTriGia.Text = "Trị Giá";
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayNhap.Location = new System.Drawing.Point(161, 284);
            this.txtNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(238, 32);
            this.txtNgayNhap.TabIndex = 0;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(10, 286);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(121, 26);
            this.lblNgayNhap.TabIndex = 1;
            this.lblNgayNhap.Text = "Ngày Nhập";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(10, 288);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(0, 26);
            this.lblTheLoai.TabIndex = 1;
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaXuatBan.Location = new System.Drawing.Point(161, 194);
            this.txtNhaXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(238, 32);
            this.txtNhaXuatBan.TabIndex = 0;
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaXuatBan.Location = new System.Drawing.Point(10, 197);
            this.lblNhaXuatBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(148, 26);
            this.lblNhaXuatBan.TabIndex = 1;
            this.lblNhaXuatBan.Text = "Nhà Xuất Bản";
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXuatBan.Location = new System.Drawing.Point(161, 151);
            this.txtNamXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(238, 32);
            this.txtNamXuatBan.TabIndex = 0;
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamXuatBan.Location = new System.Drawing.Point(10, 156);
            this.lblNamXuatBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(155, 26);
            this.lblNamXuatBan.TabIndex = 1;
            this.lblNamXuatBan.Text = "Năm Xuất Bản";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(161, 112);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(238, 32);
            this.txtTacGia.TabIndex = 0;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(10, 112);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(87, 26);
            this.lblTacGia.TabIndex = 1;
            this.lblTacGia.Text = "Tác Giả";
            // 
            // txtMaS
            // 
            this.txtMaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaS.Location = new System.Drawing.Point(161, 31);
            this.txtMaS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.ReadOnly = true;
            this.txtMaS.Size = new System.Drawing.Size(238, 32);
            this.txtMaS.TabIndex = 0;
            // 
            // lblMaS
            // 
            this.lblMaS.AutoSize = true;
            this.lblMaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaS.Location = new System.Drawing.Point(10, 33);
            this.lblMaS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaS.Name = "lblMaS";
            this.lblMaS.Size = new System.Drawing.Size(98, 26);
            this.lblMaS.TabIndex = 1;
            this.lblMaS.Text = "Mã Sách";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(161, 72);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(238, 32);
            this.txtTenSach.TabIndex = 0;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(10, 72);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(104, 26);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // lblThongTinSach
            // 
            this.lblThongTinSach.AutoSize = true;
            this.lblThongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSach.Location = new System.Drawing.Point(386, 101);
            this.lblThongTinSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinSach.Name = "lblThongTinSach";
            this.lblThongTinSach.Size = new System.Drawing.Size(205, 31);
            this.lblThongTinSach.TabIndex = 7;
            this.lblThongTinSach.Text = "Thông Tin Sách";
            // 
            // frmQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 623);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimkiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvQLSach);
            this.Controls.Add(this.grbSach);
            this.Controls.Add(this.lblThongTinSach);
            this.Name = "frmQLSach";
            this.Text = "Thông tin sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSach)).EndInit();
            this.grbSach.ResumeLayout(false);
            this.grbSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvQLSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNhaXuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayNhap;
        private System.Windows.Forms.GroupBox grbSach;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.Label lblTriGia;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.Label lblMaS;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblThongTinSach;
    }
}