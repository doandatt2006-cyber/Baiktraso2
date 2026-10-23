using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace baiktraso2
{
    public partial class bai2 : Form
    {
        private BindingList<BookModel> bookList = new BindingList<BookModel>();
        private BindingSource bookBindingSource = new BindingSource();
        private string selectedImagePath = "";

        public bai2()
        {
            InitializeComponent();
        }

        private void bai2_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            bookList.ListChanged += (s, ev) => UpdateStatusStrip();
            UpdateStatusStrip();
        }

        private void SetupDataGridView()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.ReadOnly = true;
            dgvBooks.MultiSelect = false;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.Columns.Clear();

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BookModel.BookId), HeaderText = "Mã sách", Width = 90 });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BookModel.Title), HeaderText = "Tên sách", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BookModel.Price), HeaderText = "Giá sách", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BookModel.Quantity), HeaderText = "Số lượng", Width = 80 });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BookModel.TotalValue), HeaderText = "Tổng giá trị", Width = 110, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(BookModel.CoverPath), HeaderText = "Tên file ảnh", Width = 120 });

            bookBindingSource.DataSource = bookList;
            dgvBooks.DataSource = bookBindingSource;

            dgvBooks.SelectionChanged += DgvBooks_SelectionChanged;
        }

        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null && bookBindingSource.Current is BookModel selectedBook)
            {
                txtBookId.Text = selectedBook.BookId;
                txtTitle.Text = selectedBook.Title;
                txtPrice.Text = selectedBook.Price.ToString("N0");
                txtQuantity.Text = selectedBook.Quantity.ToString();
                selectedImagePath = selectedBook.CoverPath;

                if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                {
                    picBookCover.ImageLocation = selectedImagePath;
                }
                else
                {
                    picBookCover.Image = null;
                }
            }
        }

        private void btnBrowseCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "File hình ảnh (*.png;*.jpg)|*.png;*.jpg|Tất cả file (*.*)|*.*";
                ofd.Title = "Chọn ảnh bìa sách";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    picBookCover.ImageLocation = selectedImagePath;
                }
            }
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtBookId.Text))
            {
                errorProvider1.SetError(txtBookId, "Mã sách không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Tên sách không được để trống!");
                isValid = false;
            }

            string priceClean = txtPrice.Text.Replace(",", "").Replace(".", "").Trim();
            if (!decimal.TryParse(priceClean, out decimal price) || price <= 0)
            {
                errorProvider1.SetError(txtPrice, "Giá sách phải là số dương!");
                isValid = false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty <= 0)
            {
                errorProvider1.SetError(txtQuantity, "Số lượng phải là số nguyên dương!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string priceClean = txtPrice.Text.Replace(",", "").Replace(".", "").Trim();

            BookModel newBook = new BookModel
            {
                BookId = txtBookId.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                Price = decimal.Parse(priceClean),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                CoverPath = selectedImagePath
            };

            bookList.Add(newBook);
            ClearForm();
            MessageBox.Show("Thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bookBindingSource.Current is BookModel currentBook)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa sách '{currentBook.Title}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bookBindingSource.RemoveCurrent();
                    ClearForm();
                }
            }
        }

        private void saveCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.Title = "Xuất dữ liệu báo cáo sách";
                sfd.FileName = "BaoCaoNhaSach.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine("Mã sách,Tên sách,Giá sách,Số lượng,Đường dẫn ảnh");
                            foreach (var book in bookList)
                            {
                                sw.WriteLine($"{book.BookId},{book.Title},{book.Price},{book.Quantity},{book.CoverPath}");
                            }
                        }
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void openCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV File (*.csv)|*.csv";
                ofd.Title = "Mở file CSV dữ liệu sách";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName);
                        bookList.Clear();

                        for (int i = 1; i < lines.Length; i++)
                        {
                            if (string.IsNullOrWhiteSpace(lines[i])) continue;
                            string[] parts = lines[i].Split(',');

                            if (parts.Length >= 5)
                            {
                                bookList.Add(new BookModel
                                {
                                    BookId = parts[0].Trim(),
                                    Title = parts[1].Trim(),
                                    Price = decimal.Parse(parts[2].Trim()),
                                    Quantity = int.Parse(parts[3].Trim()),
                                    CoverPath = parts[4].Trim()
                                });
                            }
                        }
                        MessageBox.Show("Đọc dữ liệu từ CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc file CSV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateStatusStrip()
        {
            int totalBooks = bookList.Count;
            decimal totalValue = bookList.Sum(b => b.TotalValue);

            lblTotalBooks.Text = $"Tổng số đầu sách: {totalBooks}";
            lblTotalValue.Text = $"Tổng giá trị kho: {totalValue:N0} VNĐ";
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ClearForm()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            picBookCover.Image = null;
            selectedImagePath = "";
            errorProvider1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}