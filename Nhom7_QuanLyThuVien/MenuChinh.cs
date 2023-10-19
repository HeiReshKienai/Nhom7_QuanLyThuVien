
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
    public partial class MenuChinh : Form {
        public MenuChinh() {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void bangcapToolStripMenuItem_Click(object sender, EventArgs e) {
            BangCap frm = new BangCap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mởThôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e) {
            frmQLSach frm = new frmQLSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mởĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e) {
            DocGiafrm frm = new DocGiafrm();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void mỏToolStripMenuItem_Click(object sender, EventArgs e) {
            QuanLyNhanVienfrm frm = new QuanLyNhanVienfrm();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
