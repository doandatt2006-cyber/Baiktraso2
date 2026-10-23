namespace baiktraso2
{
    partial class bai2
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openCsvToolStripMenuItem = new ToolStripMenuItem();
            saveCsvToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnTsOpen = new ToolStripButton();
            btnTsSave = new ToolStripButton();
            btnTsAdd = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblTotalBooks = new ToolStripStatusLabel();
            lblTotalValue = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            txtBookId = new TextBox();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            picBookCover = new PictureBox();
            btnBrowseCover = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvBooks = new DataGridView();
            lblId = new Label();
            lblTitle = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 28);
            menuStrip1.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openCsvToolStripMenuItem, saveCsvToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openCsvToolStripMenuItem
            // 
            openCsvToolStripMenuItem.Name = "openCsvToolStripMenuItem";
            openCsvToolStripMenuItem.Size = new Size(171, 26);
            openCsvToolStripMenuItem.Text = "Mở file CSV";
            openCsvToolStripMenuItem.Click += openCsvToolStripMenuItem_Click;
            // 
            // saveCsvToolStripMenuItem
            // 
            saveCsvToolStripMenuItem.Name = "saveCsvToolStripMenuItem";
            saveCsvToolStripMenuItem.Size = new Size(171, 26);
            saveCsvToolStripMenuItem.Text = "Lưu file CSV";
            saveCsvToolStripMenuItem.Click += saveCsvToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(171, 26);
            exitToolStripMenuItem.Text = "Thoát";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(129, 26);
            addToolStripMenuItem.Text = "Thêm";
            addToolStripMenuItem.Click += btnAdd_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(129, 26);
            deleteToolStripMenuItem.Text = "Xóa";
            deleteToolStripMenuItem.Click += btnDelete_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnTsOpen, btnTsSave, btnTsAdd });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 27);
            toolStrip1.TabIndex = 1;
            // 
            // btnTsOpen
            // 
            btnTsOpen.Name = "btnTsOpen";
            btnTsOpen.Size = new Size(85, 24);
            btnTsOpen.Text = "📂 Mở file";
            btnTsOpen.Click += openCsvToolStripMenuItem_Click;
            // 
            // btnTsSave
            // 
            btnTsSave.Name = "btnTsSave";
            btnTsSave.Size = new Size(86, 24);
            btnTsSave.Text = "💾 Lưu file";
            btnTsSave.Click += saveCsvToolStripMenuItem_Click;
            // 
            // btnTsAdd
            // 
            btnTsAdd.Name = "btnTsAdd";
            btnTsAdd.Size = new Size(105, 24);
            btnTsAdd.Text = "➕ Thêm mới";
            btnTsAdd.Click += btnAdd_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalBooks, lblTotalValue, lblClock });
            statusStrip1.Location = new Point(0, 519);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 26);
            statusStrip1.TabIndex = 15;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(110, 20);
            lblTotalBooks.Text = "Tổng số sách: 0";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(596, 20);
            lblTotalValue.Spring = true;
            lblTotalValue.Text = "Tổng giá trị kho: 0 VNĐ";
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(63, 20);
            lblClock.Text = "00:00:00";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(124, 56);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(180, 27);
            txtBookId.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(124, 92);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(180, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(124, 127);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 27);
            txtPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(124, 162);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 27);
            txtQuantity.TabIndex = 9;
            // 
            // picBookCover
            // 
            picBookCover.BorderStyle = BorderStyle.FixedSingle;
            picBookCover.Location = new Point(357, 56);
            picBookCover.Name = "picBookCover";
            picBookCover.Size = new Size(120, 130);
            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            picBookCover.TabIndex = 10;
            picBookCover.TabStop = false;
            // 
            // btnBrowseCover
            // 
            btnBrowseCover.Location = new Point(357, 192);
            btnBrowseCover.Name = "btnBrowseCover";
            btnBrowseCover.Size = new Size(120, 28);
            btnBrowseCover.TabIndex = 11;
            btnBrowseCover.Text = "Tải ảnh bìa";
            btnBrowseCover.Click += btnBrowseCover_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(124, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 28);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm sách";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(219, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 28);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa sách";
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Location = new Point(20, 230);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(744, 280);
            dgvBooks.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.Location = new Point(20, 60);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 2;
            lblId.Text = "Mã sách:";
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(20, 95);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Tên sách:";
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(20, 130);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Giá sách:";
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(20, 165);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(100, 23);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // bai2
            // 
            ClientSize = new Size(784, 545);
            Controls.Add(menuStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(lblId);
            Controls.Add(txtBookId);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(picBookCover);
            Controls.Add(btnBrowseCover);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dgvBooks);
            Controls.Add(statusStrip1);
            Name = "bai2";
            Text = "BÀI 2: QUẢN LÝ TÀI LIỆU SÁCH & XUẤT BÁO CÁO NHÀ SÁCH";
            Load += bai2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTsOpen;
        private System.Windows.Forms.ToolStripButton btnTsSave;
        private System.Windows.Forms.ToolStripButton btnTsAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalBooks;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalValue;
        private System.Windows.Forms.ToolStripStatusLabel lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.PictureBox picBookCover;
        private System.Windows.Forms.Button btnBrowseCover;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}