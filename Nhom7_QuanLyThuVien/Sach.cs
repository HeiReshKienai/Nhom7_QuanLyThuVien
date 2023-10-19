
using Nhom7_QuanLyThuVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nhom7_QuanLyThuVien {
    public partial class frmQLSach : Form {
        //khai báo DBContext
        static QLThuVienDBcontext context = new QLThuVienDBcontext();
        List<SACH> SACHes = context.SACHes.ToList();
        private void BidingSACHToGridview(List<SACH> SACHes) {
            dgvQLSach.Rows.Clear();
            foreach (var item in SACHes) {
                int index = dgvQLSach.Rows.Add();
                dgvQLSach.Rows[index].Cells[0].Value = item.MaSach;
                dgvQLSach.Rows[index].Cells[1].Value = item.TenSach;
                dgvQLSach.Rows[index].Cells[2].Value = item.TacGia;
                dgvQLSach.Rows[index].Cells[3].Value = item.NamXuatBan;
                dgvQLSach.Rows[index].Cells[4].Value = item.NhaXuatBan;
                dgvQLSach.Rows[index].Cells[5].Value = item.TriGia;
                dgvQLSach.Rows[index].Cells[6].Value = item.NgayNhap;
            }
        }
        public frmQLSach() {
            InitializeComponent();
            BidingSACHToGridview(SACHes);
            btnXoa.Click += btnXoa_Click;
            dgvQLSach.CellClick += dgvQLSach_CellClick;
        }

        private void btnThem_Click(object sender, EventArgs e) {
            // Lấy giá trị đầu vào từ người dùng
            string tenSach = txtTenSach.Text;
            string tacGia = txtTacGia.Text;
            string namXuatBan = txtNamXuatBan.Text;
            string nhaXuatBan = txtNhaXuatBan.Text;
            string triGia = txtTriGia.Text;
            string ngayNhap = txtNgayNhap.Text;

            // Xác thực các giá trị đầu vào
            if (string.IsNullOrWhiteSpace(tenSach) || string.IsNullOrWhiteSpace(tacGia) || string.IsNullOrWhiteSpace(namXuatBan) ||
                string.IsNullOrWhiteSpace(nhaXuatBan) || string.IsNullOrWhiteSpace(triGia) || string.IsNullOrWhiteSpace(ngayNhap)) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác thực định dạng và độ dài NamXuatBan
            if (!int.TryParse(namXuatBan, out int namXuatBanNumber) || namXuatBanNumber < 1000 || namXuatBanNumber > 9999) {
                MessageBox.Show("Năm xuất bản không hợp lệ. Vui lòng nhập một số từ 1000 đến 9999.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác thực định dạng NhaXuatBan
            if (nhaXuatBan.Any(char.IsDigit)) {
                MessageBox.Show("Nhà xuất bản không được chứa chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác thực định dạng TriGia
            if (!decimal.TryParse(triGia, out decimal triGiaNumber)) {
                MessageBox.Show("Trị giá sách không hợp lệ. Vui lòng nhập một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác thực định dạng NgayNhap
            if (!DateTime.TryParseExact(ngayNhap, new string[] { "dd-MM-yyyy", "dd/MM/yyyy" }, null, System.Globalization.DateTimeStyles.None, out DateTime ngayNhapDate)) {
                MessageBox.Show("Ngày nhập không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy hoặc dd/MM/yyyy và sử dụng dấu '-' hoặc '/' để phân tách ngày, tháng và năm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Tạo một đối tượng SACH mới với các giá trị đầu vào
            SACH newSach = new SACH {
                TenSach = tenSach,
                TacGia = tacGia,
                NamXuatBan = namXuatBanNumber,
                NhaXuatBan = nhaXuatBan,
                TriGia = (double?)triGiaNumber,
                NgayNhap = ngayNhapDate
            };

            // Thêm đối tượng SACH mới vào cơ sở dữ liệu
            context.SACHes.Add(newSach);
            context.SaveChanges();

            // Làm mới DataGridView
            BidingSACHToGridview(context.SACHes.ToList());

            // Hiển thị thông báo thành công
            MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa các trường đầu vào
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNamXuatBan.Text = "";
            txtNhaXuatBan.Text = "";
            txtTriGia.Text = "";
            txtNgayNhap.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e) {
            // Kiểm tra xem có mục được chọn trong DataGridView hay không
            if (dgvQLSach.SelectedRows.Count > 0) {
                // Lấy mã sách của dòng được chọn và chuyển sang kiểu int
                if (int.TryParse(dgvQLSach.SelectedRows[0].Cells[0].Value.ToString(), out int maSach)) {
                    // Tìm kiếm sách trong danh sách SACHes dựa trên mã sách
                    SACH sach = context.SACHes.FirstOrDefault(s => s.MaSach == maSach);

                    if (sach != null) {
                        // Lấy thông tin cần chỉnh sửa từ người dùng
                        string tenSach = txtTenSach.Text;
                        string tacGia = txtTacGia.Text;
                        string namXuatBan = txtNamXuatBan.Text;
                        string nhaXuatBan = txtNhaXuatBan.Text;
                        string triGia = txtTriGia.Text;
                        string ngayNhap = txtNgayNhap.Text;

                        // Kiểm tra và xác thực thông tin nhập liệu mới từ người dùng (tương tự như phần thêm sách)

                        if (!string.IsNullOrWhiteSpace(tenSach))
                            sach.TenSach = tenSach;

                        if (!string.IsNullOrWhiteSpace(tacGia))
                            sach.TacGia = tacGia;

                        if (int.TryParse(namXuatBan, out int namXuatBanNumber) && namXuatBanNumber >= 1000 && namXuatBanNumber <= 9999)
                            sach.NamXuatBan = namXuatBanNumber;

                        if (!string.IsNullOrWhiteSpace(nhaXuatBan) && !nhaXuatBan.Any(char.IsDigit))
                            sach.NhaXuatBan = nhaXuatBan;

                        if (decimal.TryParse(triGia, out decimal triGiaNumber))
                            sach.TriGia = (double?)triGiaNumber;

                        if (DateTime.TryParseExact(ngayNhap, new string[] { "dd-MM-yyyy", "dd/MM/yyyy" }, null, System.Globalization.DateTimeStyles.None, out DateTime ngayNhapDate))
                            sach.NgayNhap = ngayNhapDate;

                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        // Làm mới DataGridView
                        BidingSACHToGridview(context.SACHes.ToList());

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    // Hiển thị thông báo lỗi nếu mã sách không hợp lệ
                    MessageBox.Show("Mã sách không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                // Hiển thị thông báo lỗi nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn sách cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvQLSach_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dgvQLSach.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong dòng được chọn
                string maSach = row.Cells[0].Value.ToString();
                string tenSach = row.Cells[1].Value.ToString();
                string tacGia = row.Cells[2].Value.ToString();
                string namXuatBan = row.Cells[3].Value.ToString();
                string nhaXuatBan = row.Cells[4].Value.ToString();
                string triGia = row.Cells[5].Value.ToString();
                string ngayNhap = row.Cells[6].Value.ToString();

                // Đặt giá trị vào các ô nhập liệu tương ứng
                txtMaS.Text = maSach;
                txtTenSach.Text = tenSach;
                txtTacGia.Text = tacGia;
                txtNamXuatBan.Text = namXuatBan;
                txtNhaXuatBan.Text = nhaXuatBan;
                txtTriGia.Text = triGia;
                txtNgayNhap.Text = ngayNhap;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e) {
            // Kiểm tra xem có mục được chọn trong DataGridView hay không
            if (dgvQLSach.SelectedRows.Count > 0) {
                // Lấy mã sách của dòng được chọn và chuyển sang kiểu int
                if (int.TryParse(dgvQLSach.SelectedRows[0].Cells[0].Value.ToString(), out int maSach)) {
                    // Tìm kiếm sách trong danh sách SACHes dựa trên mã sách
                    SACH sach = context.SACHes.FirstOrDefault(s => s.MaSach == maSach);

                    if (sach != null) {
                        // Xóa sách khỏi danh sách và lưu thay đổi vào cơ sở dữ liệu
                        context.SACHes.Remove(sach);
                        context.SaveChanges();

                        // Làm mới DataGridView
                        BidingSACHToGridview(context.SACHes.ToList());

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    // Hiển thị thông báo lỗi nếu mã sách không hợp lệ
                    MessageBox.Show("Mã sách không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                // Hiển thị thông báo lỗi nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn sách cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                // Khi người dùng ấn phím "Enter", thực hiện tìm kiếm
                PerformSearch();
                e.Handled = true; // Ngăn việc nhập ký tự xuống dòng trong TextBox
            } else {
                // Lọc kết quả tìm kiếm dựa trên nội dung trong TextBox tìm kiếm
                FilterResults(txtTimKiem.Text.Trim().ToLower());
            }
        }
        private void PerformSearch() {
            // Lấy từ khóa tìm kiếm từ TextBox txtTimKiem
            string keyword = txtTimKiem.Text.Trim().ToLower();

            // Tìm kiếm dựa trên từ khóa trong danh sách SACHes
            var searchResults = SACHes.Where(s => s.TenSach.ToLower().Contains(keyword) || s.TacGia.ToLower().Contains(keyword)).ToList();

            // Cập nhật DataGridView với kết quả tìm kiếm
            BidingSACHToGridview(searchResults);
        }

        private void FilterResults(string filterKeyword) {
            if (!string.IsNullOrWhiteSpace(filterKeyword)) {
                var filteredResults = SACHes.Where(s => s.TenSach.ToLower().Contains(filterKeyword) || s.TacGia.ToLower().Contains(filterKeyword)).ToList();

                // Cập nhật DataGridView với kết quả lọc
                BidingSACHToGridview(filteredResults);
            } else {
                // Nếu không có từ khóa lọc, hiển thị kết quả tìm kiếm ban đầu
                BidingSACHToGridview(SACHes);
            }
        }

    }
}

