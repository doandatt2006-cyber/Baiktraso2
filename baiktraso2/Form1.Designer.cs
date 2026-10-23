namespace baiktraso2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtMemberId = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            cboPackage = new ComboBox();
            dtpStartDate = new DateTimePicker();
            txtFee = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvMembers = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(120, 20);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(200, 27);
            txtMemberId.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(120, 50);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 27);
            txtFullName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 80);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 2;
            // 
            // cboPackage
            // 
            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPackage.FormattingEnabled = true;
            cboPackage.Location = new Point(120, 110);
            cboPackage.Name = "cboPackage";
            cboPackage.Size = new Size(200, 28);
            cboPackage.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(120, 140);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 27);
            dtpStartDate.TabIndex = 4;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(120, 170);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(200, 27);
            txtFee.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(350, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(350, 60);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 30);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa thông tin";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(350, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa hội viên";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(350, 140);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(20, 210);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(650, 200);
            dgvMembers.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 11;
            label1.Text = "Nhập mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 12;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 81);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 13;
            label3.Text = "SDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 110);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 14;
            label4.Text = "Gói tập";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 140);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 15;
            label5.Text = "Ngày ĐK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 170);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 16;
            label6.Text = "Phí dịch vụ";
            // 
            // Form1
            // 
            ClientSize = new Size(789, 430);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMemberId);
            Controls.Add(txtFullName);
            Controls.Add(txtPhone);
            Controls.Add(cboPackage);
            Controls.Add(dtpStartDate);
            Controls.Add(txtFee);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvMembers);
            Name = "Form1";
            Text = "Quản lý dịch vụ phòng Gym & Hội viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}