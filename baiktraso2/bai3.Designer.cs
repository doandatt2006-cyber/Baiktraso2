namespace baiktraso2
{
    partial class bai3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNapLai = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoSoBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMucBacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMucKhoaPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDoctorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLy,
            this.menuCuaSo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);

            // menuHeThong
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangXuat,
            this.menuNapLai,
            this.menuThoat});
            this.menuHeThong.Text = "Hệ thống";

            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);

            this.menuNapLai.Text = "Nạp lại dữ liệu";
            this.menuNapLai.Click += new System.EventHandler(this.menuNapLai_Click);

            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);

            // menuQuanLy
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHoSoBenhNhan,
            this.menuDanhMucBacSi,
            this.menuDanhMucKhoaPhong});
            this.menuQuanLy.Text = "Quản lý";

            this.menuHoSoBenhNhan.Text = "Hồ sơ Bệnh nhân";
            this.menuHoSoBenhNhan.Click += new System.EventHandler(this.menuHoSoBenhNhan_Click);

            this.menuDanhMucBacSi.Text = "Danh mục Bác sĩ (Lịch trực)";
            this.menuDanhMucBacSi.Click += new System.EventHandler(this.menuDanhMucBacSi_Click);

            this.menuDanhMucKhoaPhong.Text = "Danh mục Khoa/Phòng";
            this.menuDanhMucKhoaPhong.Click += new System.EventHandler(this.menuDanhMucKhoaPhong_Click);

            // menuCuaSo
            this.menuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCascade,
            this.menuTileHorizontal,
            this.menuTileVertical,
            this.menuCloseAll});
            this.menuCuaSo.Text = "Cửa sổ";

            this.menuCascade.Text = "Xếp tầng (Cascade)";
            this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);

            this.menuTileHorizontal.Text = "Sắp xếp Ngang (Tile Horizontal)";
            this.menuTileHorizontal.Click += new System.EventHandler(this.menuTileHorizontal_Click);

            this.menuTileVertical.Text = "Sắp xếp Dọc (Tile Vertical)";
            this.menuTileVertical.Click += new System.EventHandler(this.menuTileVertical_Click);

            this.menuCloseAll.Text = "Đóng tất cả";
            this.menuCloseAll.Click += new System.EventHandler(this.menuCloseAll_Click);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDoctorStatus,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);

            this.lblDoctorStatus.Text = "Bác sĩ trực: BS. Nguyễn Văn An (Khoa Cấp cứu)";
            this.lblDoctorStatus.Spring = true;
            this.lblDoctorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 16);
            this.progressBar.Value = 100;

            // bai3 (MDI Container Parent Form)
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI 3: HỆ THỐNG MDI QUẢN LÝ BỆNH VIỆN & TRUY XUẤT HỒ SƠ BỆNH ÁN";
            this.menuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuNapLai;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuHoSoBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMucBacSi;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMucKhoaPhong;
        private System.Windows.Forms.ToolStripMenuItem menuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem menuCloseAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDoctorStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}