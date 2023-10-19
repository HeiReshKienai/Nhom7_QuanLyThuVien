using Nhom7_QuanLyThuVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom7_QuanLyThuVien {
    public partial class QuanLyNhanVienfrm : Form {
        // Khai Báo BDcontext
        static QLThuVienDBcontext context = new QLThuVienDBcontext();
        List<NHANVIEN> nhanvienList = context.NHANVIENs.ToList();
        List<BANGCAP> bangcapList = context.BANGCAPs.ToList();


        // Fill cho cbb bằng cấp
        public void fillbangcapToCBB(List<BANGCAP> bangcap) {
            cbbBangCap.DataSource = bangcap;
            cbbBangCap.ValueMember = "MaBangCap";
            cbbBangCap.DisplayMember = "TenBangCap";
        }
        // đổ dữ liệu cho dgv
        public void DoDuLieuVao(List<NHANVIEN> nhanviens) {
            dgvDanhSach.Rows.Clear();

            foreach (var item in nhanviens) {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = item.MaNhanVien;
                dgvDanhSach.Rows[index].Cells[1].Value = item.HoTenNhanVien;
                dgvDanhSach.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvDanhSach.Rows[index].Cells[3].Value = item.DiaChi;
                dgvDanhSach.Rows[index].Cells[4].Value = item.DienThoai;
                dgvDanhSach.Rows[index].Cells[5].Value = item.BANGCAP.TenBangCap;
            }
        }


        public QuanLyNhanVienfrm() {
            InitializeComponent();
            fillbangcapToCBB(bangcapList);
            DoDuLieuVao(nhanvienList);
        }

        // Hàm kiểm tra đầu vào
        public bool checkNull() {
            if (txtMaNhanVien.Text == "" || txtHoVaTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "") {
                return true;
            }

            return false;
        }



        //ham them 1 nhan vien
        public void addNhanVien(NHANVIEN n) {
            context.NHANVIENs.Add(n);
            context.SaveChanges();
            MessageBox.Show("Thêm thành công");
        }

        private void btnThem_Click(object sender, EventArgs e) {
            // Kiểm tra các trường đầu vào có rỗng hay không
            if (checkNull()) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Tạo một đối tượng NHANVIEN mới từ các giá trị nhập vào
            NHANVIEN newNhanVien = new NHANVIEN {
                MaNhanVien = Convert.ToInt32(txtMaNhanVien.Text),
                HoTenNhanVien = txtHoVaTen.Text,
                NgaySinh = DateTime.Parse(txtNgaySinh.Text), // Chuyển đổi chuỗi thành ngày
                DiaChi = txtDiaChi.Text,
                DienThoai = txtSDT.Text,
                MaBangCap = ((BANGCAP)cbbBangCap.SelectedItem).MaBangCap // Lấy giá trị MaBangCap từ ComboBox
            };

            addNhanVien(newNhanVien);
            // Cập nhật lại danh sách nhân viên trong DataGridView
            nhanvienList.Add(newNhanVien);
            DoDuLieuVao(nhanvienList);

            txtMaNhanVien.Text = "";
            txtHoVaTen.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";


        }

        private void btnXoa_Click(object sender, EventArgs e) {
            int maNhanVien = int.Parse(txtMaNhanVien.Text); // Chuyển đổi kiểu chuỗi thành kiểu int

            // Tìm nhân viên cần xóa trong danh sách
            var xoaNhanVien = nhanvienList.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);

            if (xoaNhanVien != null) {
                // Xóa nhân viên trong danh sách
                nhanvienList.Remove(xoaNhanVien);

                // Xóa nhân viên trong cơ sở dữ liệu
                context.NHANVIENs.Remove(xoaNhanVien);
                context.SaveChanges();

                DoDuLieuVao(nhanvienList); // Cập nhật lại DataGridView
                MessageBox.Show("Xóa nhân viên thành công");
            } else {
                MessageBox.Show("Không tìm thấy nhân viên cần xóa");
            }
        }


        //đổ dữ liệu từ dataGridview  vào textbox và cbb
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            txtMaNhanVien.Text = dgvDanhSach.Rows[index].Cells[0].Value.ToString(); ;
            txtHoVaTen.Text = dgvDanhSach.Rows[index].Cells[1].Value.ToString();
            txtNgaySinh.Text = dgvDanhSach.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDanhSach.Rows[index].Cells[3].Value.ToString();
            txtSDT.Text = dgvDanhSach.Rows[index].Cells[4].Value.ToString();
            cbbBangCap.Text = dgvDanhSach.Rows[index].Cells[5].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e) {
            int maNhanVien = int.Parse(txtMaNhanVien.Text); // Chuyển đổi kiểu chuỗi thành kiểu int
            var SuaNhanVien = context.NHANVIENs.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);

            if (SuaNhanVien != null) {
                SuaNhanVien.HoTenNhanVien = txtHoVaTen.Text;
                SuaNhanVien.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                SuaNhanVien.DiaChi = txtDiaChi.Text;
                SuaNhanVien.DienThoai = txtSDT.Text;
                SuaNhanVien.MaBangCap = cbbBangCap.SelectedIndex + 1;
                context.SaveChanges();
                var nhanviens = context.NHANVIENs.ToList();
                DoDuLieuVao(nhanvienList);
                MessageBox.Show("Sửa Nhân Viên Thành Công");
            } else {
                MessageBox.Show("Không Tìm Thấy NV cần sửa");
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e) {
            string keyword = txtTimKiem.Text.Trim(); // Lấy nội dung tìm kiếm và loại bỏ khoảng trắng đầu và cuối

            // Lọc danh sách nhân viên dựa trên từ khóa tìm kiếm
            List<NHANVIEN> TuKhoa = nhanvienList.Where(nv => nv.HoTenNhanVien.ToLower().Contains(keyword.ToLower())).ToList();
            DoDuLieuVao(TuKhoa);
        }
    }
}
