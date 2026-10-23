using System;
using System.Linq;
using System.Windows.Forms;

namespace baiktraso2
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        // Hàm generic mở Form con MDI: Ngăn chặn mở trùng lặp
        private void OpenChildForm<T>() where T : Form, new()
        {
            Form childForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (childForm != null)
            {
                // Nếu Form đã mở, kích hoạt đưa lên trên cùng
                childForm.Activate();
            }
            else
            {
                // Khởi tạo mới, gán MdiParent và hiển thị
                childForm = new T();
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void menuHoSoBenhNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmPatientProfiles>();
        }

        private void menuDanhMucBacSi_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmDoctorSchedule>();
        }

        private void menuDanhMucKhoaPhong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Danh mục Khoa/Phòng đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Các thao tác điều hướng cửa sổ MDI
        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            menuCloseAll_Click(sender, e);
            MessageBox.Show("Đã đăng xuất khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuNapLai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã nạp lại toàn bộ dữ liệu hệ thống bệnh viện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}