namespace Nhom7_QuanLyThuVien {
    partial class MenuChinh {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucnangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bangcapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởThôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởĐọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mỏToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucnangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chucnangToolStripMenuItem
            // 
            this.chucnangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bangcapToolStripMenuItem,
            this.mởThôngTinSáchToolStripMenuItem,
            this.mởĐọcGiảToolStripMenuItem,
            this.mỏToolStripMenuItem});
            this.chucnangToolStripMenuItem.Name = "chucnangToolStripMenuItem";
            this.chucnangToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.chucnangToolStripMenuItem.Text = "Mở";
            // 
            // bangcapToolStripMenuItem
            // 
            this.bangcapToolStripMenuItem.Name = "bangcapToolStripMenuItem";
            this.bangcapToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.bangcapToolStripMenuItem.Text = "Mở bảng bằng cấp";
            this.bangcapToolStripMenuItem.Click += new System.EventHandler(this.bangcapToolStripMenuItem_Click);
            // 
            // mởThôngTinSáchToolStripMenuItem
            // 
            this.mởThôngTinSáchToolStripMenuItem.Name = "mởThôngTinSáchToolStripMenuItem";
            this.mởThôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mởThôngTinSáchToolStripMenuItem.Text = "Mở bảng thông tin sách";
            this.mởThôngTinSáchToolStripMenuItem.Click += new System.EventHandler(this.mởThôngTinSáchToolStripMenuItem_Click);
            // 
            // mởĐọcGiảToolStripMenuItem
            // 
            this.mởĐọcGiảToolStripMenuItem.Name = "mởĐọcGiảToolStripMenuItem";
            this.mởĐọcGiảToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mởĐọcGiảToolStripMenuItem.Text = "Mở bảng Đọc giả";
            this.mởĐọcGiảToolStripMenuItem.Click += new System.EventHandler(this.mởĐọcGiảToolStripMenuItem_Click);
            // 
            // mỏToolStripMenuItem
            // 
            this.mỏToolStripMenuItem.Name = "mỏToolStripMenuItem";
            this.mỏToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mỏToolStripMenuItem.Text = "Mở bảng nhân viên";
            this.mỏToolStripMenuItem.Click += new System.EventHandler(this.mỏToolStripMenuItem_Click);
            // 
            // MenuChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucnangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bangcapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởThôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởĐọcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mỏToolStripMenuItem;
    }
}

