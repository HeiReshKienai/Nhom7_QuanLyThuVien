namespace Nhom7_QuanLyThuVien {
    partial class BangCap {
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
            this.dgvBangCap = new System.Windows.Forms.DataGridView();
            this.MaBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaBangCap = new System.Windows.Forms.Label();
            this.lblTenBangCap = new System.Windows.Forms.Label();
            this.txtMaBangCap = new System.Windows.Forms.TextBox();
            this.txtTenBangCap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBangCap
            // 
            this.dgvBangCap.AllowUserToAddRows = false;
            this.dgvBangCap.AllowUserToDeleteRows = false;
            this.dgvBangCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBangCap,
            this.TenBangCap});
            this.dgvBangCap.Location = new System.Drawing.Point(387, 67);
            this.dgvBangCap.Name = "dgvBangCap";
            this.dgvBangCap.ReadOnly = true;
            this.dgvBangCap.RowHeadersWidth = 51;
            this.dgvBangCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangCap.Size = new System.Drawing.Size(257, 295);
            this.dgvBangCap.TabIndex = 0;
            this.dgvBangCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangCap_CellClick);
            // 
            // MaBangCap
            // 
            this.MaBangCap.HeaderText = "Mã Bằng Cấp";
            this.MaBangCap.MinimumWidth = 6;
            this.MaBangCap.Name = "MaBangCap";
            this.MaBangCap.ReadOnly = true;
            // 
            // TenBangCap
            // 
            this.TenBangCap.HeaderText = "Tên Bằng Cấp";
            this.TenBangCap.MinimumWidth = 6;
            this.TenBangCap.Name = "TenBangCap";
            this.TenBangCap.ReadOnly = true;
            // 
            // lblMaBangCap
            // 
            this.lblMaBangCap.AutoSize = true;
            this.lblMaBangCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBangCap.Location = new System.Drawing.Point(18, 112);
            this.lblMaBangCap.Name = "lblMaBangCap";
            this.lblMaBangCap.Size = new System.Drawing.Size(120, 24);
            this.lblMaBangCap.TabIndex = 1;
            this.lblMaBangCap.Text = "Mã bằng cấp";
            // 
            // lblTenBangCap
            // 
            this.lblTenBangCap.AutoSize = true;
            this.lblTenBangCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBangCap.Location = new System.Drawing.Point(18, 162);
            this.lblTenBangCap.Name = "lblTenBangCap";
            this.lblTenBangCap.Size = new System.Drawing.Size(128, 24);
            this.lblTenBangCap.TabIndex = 1;
            this.lblTenBangCap.Text = "Tên bằng cấp";
            // 
            // txtMaBangCap
            // 
            this.txtMaBangCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBangCap.Location = new System.Drawing.Point(179, 112);
            this.txtMaBangCap.Name = "txtMaBangCap";
            this.txtMaBangCap.ReadOnly = true;
            this.txtMaBangCap.Size = new System.Drawing.Size(146, 29);
            this.txtMaBangCap.TabIndex = 2;
            // 
            // txtTenBangCap
            // 
            this.txtTenBangCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBangCap.Location = new System.Drawing.Point(179, 161);
            this.txtTenBangCap.Name = "txtTenBangCap";
            this.txtTenBangCap.Size = new System.Drawing.Size(146, 29);
            this.txtTenBangCap.TabIndex = 2;
            this.txtTenBangCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenBangCap_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(33, 243);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(147, 243);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(257, 243);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 41);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(488, 33);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(146, 29);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(383, 33);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(90, 24);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bằng Cấp";
            // 
            // BangCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenBangCap);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtMaBangCap);
            this.Controls.Add(this.lblTenBangCap);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.lblMaBangCap);
            this.Controls.Add(this.dgvBangCap);
            this.Name = "BangCap";
            this.Text = "Bằng cấp";
            this.Load += new System.EventHandler(this.BangCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangCap;
        private System.Windows.Forms.Label lblMaBangCap;
        private System.Windows.Forms.Label lblTenBangCap;
        private System.Windows.Forms.TextBox txtMaBangCap;
        private System.Windows.Forms.TextBox txtTenBangCap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBangCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBangCap;
        private System.Windows.Forms.Label label1;
    }
}