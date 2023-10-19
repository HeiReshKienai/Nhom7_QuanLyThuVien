using Nhom7_QuanLyThuVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom7_QuanLyThuVien {
    public partial class BangCap : Form {
        static QLThuVienDBcontext context = new QLThuVienDBcontext();
        List<BANGCAP> listBANGCAPS = context.BANGCAPs.ToList();

        public BangCap() {          
            InitializeComponent();
        }

        private void BangCap_Load(object sender, EventArgs e) {
            //gán giá trị tiếp theo vào text box mã bằng cấp
            int nextMaBangCap = listBANGCAPS.Max(b => b.MaBangCap) + 1;
            txtMaBangCap.Text = nextMaBangCap.ToString();
            //load dữ liệu vào bảng
            BindGrid(listBANGCAPS);
        }
        //load dữ liệu vào bảng
        private void BindGrid(List<BANGCAP> listBANGCAPS) {
            dgvBangCap.Rows.Clear();
            foreach (var item in listBANGCAPS) {
                int index = dgvBangCap.Rows.Add();
                dgvBangCap.Rows[index].Cells[0].Value = item.MaBangCap;
                dgvBangCap.Rows[index].Cells[1].Value = item.TenBangCap;

            }
        }
        //xuất dữ liệu ngược vào text box
        private void dgvBangCap_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = e.RowIndex;

            txtMaBangCap.Text =dgvBangCap.Rows[index].Cells[0].Value.ToString();
            txtTenBangCap.Text = dgvBangCap.Rows[index].Cells[1].Value.ToString();

        }


        private void btnXoa_Click(object sender, EventArgs e) {
            try {
                DialogResult result = MessageBox.Show("Bạn có muốn Xoá Không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    int maBangCap = int.Parse(txtMaBangCap.Text);
                    var deleteBangCap = context.BANGCAPs.FirstOrDefault(s => s.MaBangCap == maBangCap);

                    if (deleteBangCap != null) {
                        DialogResult deleteOption = MessageBox.Show("Bạn có muốn chỉ xóa tên bắng cấp không và giữ lại mã bằng cấp không ?", "Lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (deleteOption == DialogResult.Yes) {
                            deleteBangCap.TenBangCap = ""; 
                        } else {
                            context.BANGCAPs.Remove(deleteBangCap);
                        }

                        context.SaveChanges();
                        dgvBangCap.Rows.Clear();

                        var bc = context.BANGCAPs.ToList();
                        BindGrid(bc);
                        MessageBox.Show("Xóa thành công", "Thông báo");

                        int nextMaBangCap = listBANGCAPS.Max(b => b.MaBangCap) + 1;
                        txtMaBangCap.Text = nextMaBangCap.ToString();
                        txtTenBangCap.Text = "";

                    } else {
                        MessageBox.Show("Bằng Cấp cần xoá không tồn tại", "Thông báo");
                    }
                } else if (result == DialogResult.No) {
                    MessageBox.Show("Bạn không đồng ý xóa Bằng Cấp");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public bool CheckNull() {
            if (txtMaBangCap.Text == "" || txtTenBangCap.Text == "" ) { return true; }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e) {
            try {
                // Kiểm tra rỗng
                if (!CheckNull()) {
                   int maBangCap = int.Parse(txtMaBangCap.Text);
                    bool maBangCapExists = context.BANGCAPs.Any(b => b.MaBangCap == maBangCap);
                    if (maBangCapExists) {
                        MessageBox.Show("Mã bằng cấp đã tồn tại trong cơ sở dữ liệu!");
                        return;
                    }

                    string tenBangCap = txtTenBangCap.Text;
                    bool tenBangCapExists = context.BANGCAPs.Any(b => b.TenBangCap == tenBangCap);
                    if (tenBangCapExists) {
                        DialogResult result = MessageBox.Show("Tên bằng cấp đã tồn tại trong cơ sở dữ liệu! Bạn có muốn tiếp tục thêm?", "Xác nhận", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No) {
                            return;
                        }
                    }

                    BANGCAP bangCap = new BANGCAP();
                    bangCap.TenBangCap = tenBangCap;
                    context.BANGCAPs.Add(bangCap);
                    context.SaveChanges();

                    dgvBangCap.Rows.Clear();
                    listBANGCAPS = context.BANGCAPs.ToList();
                    BindGrid(listBANGCAPS);

                    MessageBox.Show("Thêm thành công Bằng cấp có mã là " + bangCap.MaBangCap + "!"); 

                    int nextMaBangCap = listBANGCAPS.Max(b => b.MaBangCap) + 1;
                    txtMaBangCap.Text = nextMaBangCap.ToString();
                    
                    txtTenBangCap.Text = "";
                } else {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin Bằng cấp");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnSua_Click(object sender, EventArgs e) {
            try {
                // kiểm tra Rỗng
                if (!CheckNull()) {
                    int maBangCap = int.Parse(txtMaBangCap.Text);
                    var updateBangCap = context.BANGCAPs.FirstOrDefault(s => s.MaBangCap == maBangCap);
                        if (updateBangCap != null) {
                            updateBangCap.TenBangCap = txtTenBangCap.Text;

                            context.SaveChanges();
                            listBANGCAPS = context.BANGCAPs.ToList();

                            dgvBangCap.Rows.Clear();
                            BindGrid(listBANGCAPS);

                            int nextMaBangCap = listBANGCAPS.Max(b => b.MaBangCap) + 1;
                            txtMaBangCap.Text = nextMaBangCap.ToString();
                            txtTenBangCap.Text = "";
                            MessageBox.Show("Cập nhật Thông tin thành công!", "Thong báo");
                        } else {
                            MessageBox.Show("Cập nhật thông tin không thành công!", "Thông báo");
                        }
                    } 
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        //linq
        private void txtTimKiem_TextChanged(object sender, EventArgs e) {
            string searchStr = txtTimKiem.Text.Trim();

            List<BANGCAP> filteredList = listBANGCAPS.Where(s =>
                s.MaBangCap.ToString().IndexOf(searchStr, StringComparison.OrdinalIgnoreCase) >= 0 ||
                s.TenBangCap.IndexOf(searchStr, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            BindGrid(filteredList);
        }

        private void txtTenBangCap_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                e.Handled = true; // Ngăn không cho phép nhập số
                MessageBox.Show("Chỉ nhập chữ!", "Thông báo", MessageBoxButtons.OK);
            }
        }


    }
}
