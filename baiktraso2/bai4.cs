using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiktraso2
{
    public partial class bai4 : Form
    {
        private CancellationTokenSource _cts;

        public bai4()
        {
            InitializeComponent();
        }

        private void bai4_Load(object sender, EventArgs e)
        {
            cboBranch.Items.AddRange(new string[] {
                "Tất cả chi nhánh",
                "Chi nhánh 1 - Hà Nội",
                "Chi nhánh 2 - TP.HCM",
                "Chi nhánh 3 - Đà Nẵng"
            });
            cboBranch.SelectedIndex = 0;
            dtpFromDate.Value = DateTime.Now.AddDays(-30);
            dtpToDate.Value = DateTime.Now;

            btnCancel.Enabled = false;
            pgbLoading.Value = 0;
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvRevenueData.AutoGenerateColumns = false;
            dgvRevenueData.ReadOnly = true;
            dgvRevenueData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenueData.Columns.Clear();

            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(RevenueModel.TransactionId), HeaderText = "Mã Giao Dịch", Width = 110 });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(RevenueModel.TransactionDate), HeaderText = "Ngày Giao Dịch", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" } });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(RevenueModel.BranchName), HeaderText = "Chi Nhánh", Width = 170 });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(RevenueModel.CustomerName), HeaderText = "Khách Hàng", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(RevenueModel.Amount), HeaderText = "Doanh Thu (VNĐ)", Width = 140, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
            btnCancel.Enabled = true;
            pgbLoading.Value = 0;
            lblProcessingStatus.Text = "Đang kết nối CSDL và khởi tạo tiến trình tính toán...";
            dgvRevenueData.DataSource = null;

            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            // Tiến trình báo cáo phần trăm về UI Thread
            var progress = new Progress<int>(percent =>
            {
                pgbLoading.Value = percent;
                lblProcessingStatus.Text = $"Đang tổng hợp dữ liệu giao dịch lớn... {percent}%";
            });

            string selectedBranch = cboBranch.SelectedItem?.ToString();
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            try
            {
                // Đẩy tiến trình nặng xuống Background Thread bằng Task.Run
                List<RevenueModel> result = await Task.Run(() =>
                {
                    var list = new List<RevenueModel>();
                    int totalSteps = 50;

                    for (int i = 1; i <= totalSteps; i++)
                    {
                        // Kiểm tra nếu người dùng bấm Hủy
                        token.ThrowIfCancellationRequested();

                        // Giả lập tính toán nặng mất khoảng 5 giây
                        Thread.Sleep(100);

                        int percent = (i * 100) / totalSteps;
                        ((IProgress<int>)progress).Report(percent);
                    }

                    // Tải dữ liệu giả lập sau khi tính toán xong
                    Random rand = new Random();
                    for (int i = 1; i <= 25; i++)
                    {
                        list.Add(new RevenueModel
                        {
                            TransactionId = $"HD{1000 + i}",
                            TransactionDate = fromDate.AddDays(rand.Next(0, Math.Max(1, (toDate - fromDate).Days))),
                            BranchName = selectedBranch == "Tất cả chi nhánh" ? $"Chi nhánh {rand.Next(1, 4)}" : selectedBranch,
                            CustomerName = $"Khách hàng {i}",
                            Amount = rand.Next(100, 1500) * 10000m
                        });
                    }

                    return list;
                }, token);

                // Cập nhật lên UI sau khi hoàn tất
                dgvRevenueData.DataSource = result;
                lblProcessingStatus.Text = $"Thống kê thành công! Tổng cộng {result.Count} giao dịch.";
            }
            catch (OperationCanceledException)
            {
                lblProcessingStatus.Text = "Đã hủy thao tác!";
                pgbLoading.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblProcessingStatus.Text = "Quá trình xử lý bị lỗi!";
            }
            finally
            {
                btnCalculate.Enabled = true;
                btnCancel.Enabled = false;
                _cts?.Dispose();
                _cts = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}