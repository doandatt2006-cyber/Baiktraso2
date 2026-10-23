using System;
using System.Data;
using System.Windows.Forms;

namespace baiktraso2
{
    public partial class frmDoctorSchedule : Form
    {
        public frmDoctorSchedule()
        {
            InitializeComponent();
        }

        private void frmDoctorSchedule_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã BS");
            dt.Columns.Add("Họ và Tên");
            dt.Columns.Add("Chuyên Khoa");
            dt.Columns.Add("Ca Trực");
            dt.Columns.Add("Phòng Trực");

            dt.Rows.Add("BS01", "BS. Nguyễn Văn An", "Khoa Cấp cứu", "Sáng (07:00 - 15:00)", "P. Cấp cứu 1");
            dt.Rows.Add("BS02", "BS. Lê Thị Mai", "Khoa Nội", "Chiều (15:00 - 23:00)", "P. Khám 102");
            dt.Rows.Add("BS03", "BS. Phạm Minh Tuấn", "Khoa Ngoại", "Đêm (23:00 - 07:00)", "P. Phẫu thuật 3");

            dgvSchedule.DataSource = dt;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.ReadOnly = true;
        }
    }
}