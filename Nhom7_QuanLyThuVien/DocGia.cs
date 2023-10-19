using Nhom7_QuanLyThuVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom7_QuanLyThuVien {
    public partial class DocGiafrm : Form {

        //khai báo DocGiadata
        static QLThuVienDBcontext context = new QLThuVienDBcontext();
        // Khai báo một danh sách chứa thông tin Đọc Giả
        List<DOCGIA> DOCGIAs = context.DOCGIAs.ToList();

        // Hàm để hiển thị danh sách Đọc Giả lên DataGridView
        private void BindDocGiaGrid(List<DOCGIA> DOCGIAs) {
            dgvDanhSach.Rows.Clear();
            foreach (var item in DOCGIAs) {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = item.MaDocGia;
                dgvDanhSach.Rows[index].Cells[1].Value = item.HoTenDocGia;
                dgvDanhSach.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvDanhSach.Rows[index].Cells[3].Value = item.DiaChi;
                dgvDanhSach.Rows[index].Cells[4].Value = item.Email;
                dgvDanhSach.Rows[index].Cells[5].Value = item.NgayLapThe;
                dgvDanhSach.Rows[index].Cells[6].Value = item.NgayHetHan;
                dgvDanhSach.Rows[index].Cells[7].Value = item.TienNo;
            }
        }
        // Sự kiện xảy ra khi một ô trong DataGridView được chọn
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            txtMaDG.Text = dgvDanhSach.Rows[index].Cells[0].Value.ToString();
            txtHoTenDG.Text = dgvDanhSach.Rows[index].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvDanhSach.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDanhSach.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dgvDanhSach.Rows[index].Cells[4].Value.ToString();
            dtpNgayLapThe.Text = dgvDanhSach.Rows[index].Cells[5].Value.ToString();
            dtpNgayHetHan.Text = dgvDanhSach.Rows[index].Cells[6].Value.ToString();
            txtTienNo.Text = dgvDanhSach.Rows[index].Cells[7].Value.ToString();
        }
        public DocGiafrm() {
            InitializeComponent();
            BindDocGiaGrid(DOCGIAs);
        }
        //Hàm kiểm tra xem người dùng nhập đủ thông tin chưa 
        public bool checkNull() {
            if (txtMaDG.Text == "" || txtHoTenDG.Text == "" || dtpNgaySinh.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || dtpNgayLapThe.Text == "" || dtpNgayHetHan.Text == "" || txtTienNo.Text == "")
                return true;  //đang bị để trống 
            return false; //không bị để trống 
        }

        private void txtMaDG_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b') {
                e.Handled = true;// chặn người dùng dăng nhập 
                MessageBox.Show("Chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }



        private void txtHoTenDG_TextChanged(object sender, EventArgs e) {
            if (txtHoTenDG.Text.Any(char.IsDigit)) {
                MessageBox.Show("Họ tên không được chứa chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Xóa ký tự số vừa nhập bằng cách cắt dữ liệu
                txtHoTenDG.Text = new string(txtHoTenDG.Text.Where(c => !char.IsDigit(c)).ToArray());
            }
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '@' || char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_') {
                e.Handled = false; // Cho phép người dùng nhập
            } else {
                e.Handled = true; // Chặn người dùng nhập
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtTienNo_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b') {
                e.Handled = true; // Chặn người dùng nhập
                MessageBox.Show("Chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e) {
            if (checkNull()) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Độc Giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newMaDocGia;
            if (!int.TryParse(txtMaDG.Text, out newMaDocGia)) {
                MessageBox.Show("Mã độc giả phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (context.DOCGIAs.Any(dg => dg.MaDocGia == newMaDocGia)) {
                MessageBox.Show("Mã độc giả này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newHoTenDocGia = txtHoTenDG.Text;

            if (string.IsNullOrEmpty(newHoTenDocGia) || newHoTenDocGia.Any(char.IsDigit)) {
                MessageBox.Show("Họ tên không được để trống và chỉ chứa chữ cái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime newNgaySinh = dtpNgaySinh.Value;
            string newDiaChi = txtDiaChi.Text;
            string newEmail = txtEmail.Text;

            if (string.IsNullOrEmpty(newEmail) || !newEmail.Contains("@") || !newEmail.Contains(".")) {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime newNgayLapThe = dtpNgayLapThe.Value;
            DateTime newNgayHetHan = dtpNgayHetHan.Value;

            if (newNgayLapThe > newNgayHetHan) {
                MessageBox.Show("Ngày lập thẻ phải nhỏ hơn ngày hết hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double newTienNo;
            if (!double.TryParse(txtTienNo.Text, out newTienNo)) {
                MessageBox.Show("Tiền nợ phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn thêm độc giả này?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                // Tạo một đối tượng DOCGIA mới và thêm vào cơ sở dữ liệu
                DOCGIA newDocGia = new DOCGIA {
                    MaDocGia = newMaDocGia,
                    HoTenDocGia = newHoTenDocGia,
                    NgaySinh = newNgaySinh,
                    DiaChi = newDiaChi,
                    Email = newEmail,
                    NgayLapThe = newNgayLapThe,
                    NgayHetHan = newNgayHetHan,
                    TienNo = newTienNo
                };

                context.DOCGIAs.Add(newDocGia);
                context.SaveChanges();

                // Cập nhật danh sách độc giả và hiển thị thông báo thành công
                DOCGIAs = context.DOCGIAs.ToList();
                BindDocGiaGrid(DOCGIAs);
                MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            int maDocGiaToDelete;
            if (!int.TryParse(txtMaDG.Text, out maDocGiaToDelete)) {
                MessageBox.Show("Mã độc giả phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var docGiaToDelete = context.DOCGIAs.FirstOrDefault(dg => dg.MaDocGia == maDocGiaToDelete);

            if (docGiaToDelete != null) {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa độc giả này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    context.DOCGIAs.Remove(docGiaToDelete);
                    context.SaveChanges();

                    // Cập nhật danh sách độc giả và hiển thị thông báo thành công
                    DOCGIAs = context.DOCGIAs.ToList();
                    BindDocGiaGrid(DOCGIAs);
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("Độc giả cần xóa không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (checkNull()) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Độc Giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maDocGiaToEdit;
            if (!int.TryParse(txtMaDG.Text, out maDocGiaToEdit)) {
                MessageBox.Show("Mã độc giả phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var docGiaToEdit = context.DOCGIAs.FirstOrDefault(dg => dg.MaDocGia == maDocGiaToEdit);

            if (docGiaToEdit != null) {
                string newHoTenDocGia = txtHoTenDG.Text;

                if (string.IsNullOrEmpty(newHoTenDocGia) || newHoTenDocGia.Any(char.IsDigit)) {
                    MessageBox.Show("Họ tên không được để trống và chỉ chứa chữ cái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime newNgaySinh = dtpNgaySinh.Value;
                string newDiaChi = txtDiaChi.Text;
                string newEmail = txtEmail.Text;

                if (string.IsNullOrEmpty(newEmail) || !newEmail.Contains("@") || !newEmail.Contains(".")) {
                    MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime newNgayLapThe = dtpNgayLapThe.Value;
                DateTime newNgayHetHan = dtpNgayHetHan.Value;

                if (newNgayLapThe > newNgayHetHan) {
                    MessageBox.Show("Ngày lập thẻ phải nhỏ hơn ngày hết hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double newTienNo;
                if (!double.TryParse(txtTienNo.Text, out newTienNo)) {
                    MessageBox.Show("Tiền nợ phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có muốn sửa độc giả này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    // Cập nhật thông tin độc giả
                    docGiaToEdit.HoTenDocGia = newHoTenDocGia;
                    docGiaToEdit.NgaySinh = newNgaySinh;
                    docGiaToEdit.DiaChi = newDiaChi;
                    docGiaToEdit.Email = newEmail;
                    docGiaToEdit.NgayLapThe = newNgayLapThe;
                    docGiaToEdit.NgayHetHan = newNgayHetHan;
                    docGiaToEdit.TienNo = newTienNo;

                    context.SaveChanges();

                    // Cập nhật danh sách độc giả và hiển thị thông báo thành công
                    DOCGIAs = context.DOCGIAs.ToList();
                    BindDocGiaGrid(DOCGIAs);
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset các thông tin nhập liệu Doc Gia
                    txtMaDG.Text = string.Empty;
                    txtHoTenDG.Text = string.Empty;
                    dtpNgaySinh.Value = DateTime.Now;
                    txtDiaChi.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    dtpNgayLapThe.Value = DateTime.Now;
                    dtpNgayHetHan.Value = DateTime.Now;
                    txtTienNo.Text = string.Empty;
                }
            } else {
                MessageBox.Show("Không tìm thấy độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) {
            // Truy vấn thông tin Đọc Giả cần tìm theo Họ Tên hoặc Email
            var kq = context.DOCGIAs.Where(s => s.HoTenDocGia.Contains(txtTimKiem.Text)

            || s.Email.Contains(txtTimKiem.Text)).ToList();
            BindDocGiaGrid(kq);
            if (txtTimKiem.Text.Length == 0) {
                lblKetQuaTimKiem.Text = "";
            } else {
                lblKetQuaTimKiem.Text = "Có " + kq.Count + " Đọc Giả cần tìm";
            }
        }

        private void btnTim_Click(object sender, EventArgs e) {
            try {
                DateTime ngayLapThe = dtpNgayLapThe.Value;

                // Truy vấn thông tin Đọc Giả cần tìm theo ngày lập thẻ
                var kq = context.DOCGIAs.Where(s => DbFunctions.TruncateTime(s.NgayLapThe) == ngayLapThe.Date).ToList();
                BindDocGiaGrid(kq);
                lblKetQuaTimKiem.Text = "Có " + kq.Count + " Đọc Giả cần tìm";
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnNgayHet_Click(object sender, EventArgs e) {
            try {
                DateTime ngayHetHan = dtpNgayHetHan.Value;

                // Truy vấn thông tin Đọc Giả cần tìm theo ngày het han
                var kq = context.DOCGIAs.Where(s => DbFunctions.TruncateTime(s.NgayHetHan) == ngayHetHan.Date).ToList();
                BindDocGiaGrid(kq);
                lblKetQuaTimKiem.Text = "Có " + kq.Count + " Đọc Giả cần tìm";
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();
        }


    }
}
