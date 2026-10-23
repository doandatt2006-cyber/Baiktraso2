using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace baiktraso2
{
    public partial class Form1 : Form
    {
        private BindingList<MemberModel> memberList = new BindingList<MemberModel>();
        private BindingSource memberBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitComboBox();
            SetupDataGridView();
            SetupDataBinding();
            GenerateNewMemberId();
        }

        private void InitComboBox()
        {
            cboPackage.Items.Clear();
            cboPackage.Items.Add("Theo tháng");
            cboPackage.Items.Add("6 tháng");
            cboPackage.Items.Add("1 năm");
            cboPackage.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.ReadOnly = true;
            dgvMembers.MultiSelect = false;
            dgvMembers.AllowUserToAddRows = false;

            dgvMembers.Columns.Clear();

            // 1. Mã HV
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.MemberId),
                HeaderText = "Mã HV",
                Width = 70
            });

            // 2. Tên hội viên (Cho rộng 150px để hiển thị đầy đủ họ tên)
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.FullName),
                HeaderText = "Tên hội viên",
                Width = 150
            });

            // 3. SĐT
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.Phone),
                HeaderText = "SĐT",
                Width = 90
            });

            // 4. Gói tập
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.Package),
                HeaderText = "Gói tập",
                Width = 80
            });

            // 5. Ngày ĐK
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.StartDate),
                HeaderText = "Ngày ĐK",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            // 6. Phí dịch vụ
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.Fee),
                HeaderText = "Phí dịch vụ",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            memberBindingSource.DataSource = memberList;
            dgvMembers.DataSource = memberBindingSource;
        }

        private void SetupDataBinding()
        {
            txtMemberId.DataBindings.Add("Text", memberBindingSource, nameof(MemberModel.MemberId), true, DataSourceUpdateMode.Never);
            txtFullName.DataBindings.Add("Text", memberBindingSource, nameof(MemberModel.FullName), true, DataSourceUpdateMode.Never);
            txtPhone.DataBindings.Add("Text", memberBindingSource, nameof(MemberModel.Phone), true, DataSourceUpdateMode.Never);
            cboPackage.DataBindings.Add("Text", memberBindingSource, nameof(MemberModel.Package), true, DataSourceUpdateMode.Never);
            dtpStartDate.DataBindings.Add("Value", memberBindingSource, nameof(MemberModel.StartDate), true, DataSourceUpdateMode.Never);
            txtFee.DataBindings.Add("Text", memberBindingSource, nameof(MemberModel.Fee), true, DataSourceUpdateMode.Never, "0", "N0");
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider1.Clear();

            string namePattern = @"^[a-zA-Zàáảãạâầấẩẫậăằắẳẵặèéẻẽẹêềếểễệđìíỉĩịòóỏõọôồốổỗộơờớởỡợùúủũụưừứửữựỳýỷỹỵ\s]+$";
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider1.SetError(txtFullName, "Tên hội viên không được để trống!");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtFullName.Text.Trim(), namePattern))
            {
                errorProvider1.SetError(txtFullName, "Tên không được chứa số hoặc ký tự đặc biệt!");
                isValid = false;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{10}$"))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại phải đúng 10 chữ số!");
                isValid = false;
            }

            string feeClean = txtFee.Text.Replace(",", "").Replace(".", "").Trim();
            if (!long.TryParse(feeClean, out long feeValue) || feeValue <= 0)
            {
                errorProvider1.SetError(txtFee, "Phí dịch vụ phải là số nguyên dương!");
                isValid = false;
            }

            return isValid;
        }

        private void GenerateNewMemberId()
        {
            int nextId = memberList.Count + 1;
            txtMemberId.Text = $"HV{nextId:D3}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            dgvMembers.ClearSelection();

            txtFullName.Clear();
            txtPhone.Clear();
            cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            txtFee.Clear();

            GenerateNewMemberId();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string feeClean = txtFee.Text.Replace(",", "").Replace(".", "").Trim();

            MemberModel newMember = new MemberModel
            {
                MemberId = txtMemberId.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.SelectedItem?.ToString(),
                StartDate = dtpStartDate.Value,
                Fee = decimal.Parse(feeClean)
            };

            memberList.Add(newMember);
            MessageBox.Show("Thêm mới hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefresh_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (memberBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            MemberModel currentMember = (MemberModel)memberBindingSource.Current;
            string feeClean = txtFee.Text.Replace(",", "").Replace(".", "").Trim();

            currentMember.FullName = txtFullName.Text.Trim();
            currentMember.Phone = txtPhone.Text.Trim();
            currentMember.Package = cboPackage.SelectedItem?.ToString();
            currentMember.StartDate = dtpStartDate.Value;
            currentMember.Fee = decimal.Parse(feeClean);

            memberBindingSource.ResetCurrentItem();
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (memberBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MemberModel currentMember = (MemberModel)memberBindingSource.Current;

            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc muốn xóa hội viên '{currentMember.FullName}' ({currentMember.MemberId})?",
                "Cảnh báo xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                memberBindingSource.RemoveCurrent();
                MessageBox.Show("Đã xóa hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh_Click(sender, e);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}