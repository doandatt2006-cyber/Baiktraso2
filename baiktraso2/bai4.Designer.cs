namespace baiktraso2
{
    partial class bai4
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
            grpCriteria = new GroupBox();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            lblBranch = new Label();
            cboBranch = new ComboBox();
            btnCalculate = new Button();
            btnCancel = new Button();
            grpStatus = new GroupBox();
            lblProcessingStatus = new Label();
            pgbLoading = new ProgressBar();
            dgvRevenueData = new DataGridView();
            grpCriteria.SuspendLayout();
            grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).BeginInit();
            SuspendLayout();
            // 
            // grpCriteria
            // 
            grpCriteria.Controls.Add(lblFromDate);
            grpCriteria.Controls.Add(dtpFromDate);
            grpCriteria.Controls.Add(lblToDate);
            grpCriteria.Controls.Add(dtpToDate);
            grpCriteria.Controls.Add(lblBranch);
            grpCriteria.Controls.Add(cboBranch);
            grpCriteria.Controls.Add(btnCalculate);
            grpCriteria.Controls.Add(btnCancel);
            grpCriteria.Location = new Point(16, 12);
            grpCriteria.Name = "grpCriteria";
            grpCriteria.Size = new Size(752, 100);
            grpCriteria.TabIndex = 0;
            grpCriteria.TabStop = false;
            grpCriteria.Text = "Tiêu chí thống kê";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Location = new Point(16, 28);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(65, 20);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(84, 26);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(120, 27);
            dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Location = new Point(210, 28);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(75, 20);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(289, 26);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(120, 27);
            dtpToDate.TabIndex = 3;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Location = new Point(415, 28);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(77, 20);
            lblBranch.TabIndex = 4;
            lblBranch.Text = "Chi nhánh:";
            // 
            // cboBranch
            // 
            cboBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBranch.FormattingEnabled = true;
            cboBranch.Location = new Point(486, 24);
            cboBranch.Name = "cboBranch";
            cboBranch.Size = new Size(245, 28);
            cboBranch.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(0, 122, 204);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(486, 58);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(130, 32);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "📊 Thống Kê";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(622, 58);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 32);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "⛔ Hủy Thao Tác";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(lblProcessingStatus);
            grpStatus.Controls.Add(pgbLoading);
            grpStatus.Location = new Point(16, 120);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(752, 75);
            grpStatus.TabIndex = 1;
            grpStatus.TabStop = false;
            grpStatus.Text = "Trạng thái xử lý";
            // 
            // lblProcessingStatus
            // 
            lblProcessingStatus.AutoSize = true;
            lblProcessingStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblProcessingStatus.Location = new Point(16, 22);
            lblProcessingStatus.Name = "lblProcessingStatus";
            lblProcessingStatus.Size = new Size(192, 20);
            lblProcessingStatus.TabIndex = 0;
            lblProcessingStatus.Text = "Sẵn sàng thực hiện thống kê.";
            // 
            // pgbLoading
            // 
            pgbLoading.Location = new Point(16, 42);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(715, 20);
            pgbLoading.TabIndex = 1;
            // 
            // dgvRevenueData
            // 
            dgvRevenueData.AllowUserToAddRows = false;
            dgvRevenueData.AllowUserToDeleteRows = false;
            dgvRevenueData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRevenueData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenueData.Location = new Point(16, 205);
            dgvRevenueData.Name = "dgvRevenueData";
            dgvRevenueData.ReadOnly = true;
            dgvRevenueData.RowHeadersWidth = 51;
            dgvRevenueData.Size = new Size(752, 275);
            dgvRevenueData.TabIndex = 2;
            // 
            // bai4
            // 
            ClientSize = new Size(784, 492);
            Controls.Add(dgvRevenueData);
            Controls.Add(grpStatus);
            Controls.Add(grpCriteria);
            Name = "bai4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BÀI 4: BẢNG ĐIỀU KHIỂN THỐNG KÊ DOANH THU MULTI-THREADING";
            Load += bai4_Load;
            grpCriteria.ResumeLayout(false);
            grpCriteria.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblProcessingStatus;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.DataGridView dgvRevenueData;
    }
}