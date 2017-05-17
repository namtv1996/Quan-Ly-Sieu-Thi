namespace QLBanHangSieuThi.UC
{
    partial class ucXuatHangHoa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedList = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDropAll = new System.Windows.Forms.Button();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.dtpExportDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hansd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xdathanhtoan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xgiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtonggia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpExportDate);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.btnDropAll);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.tenhh,
            this.gianhap,
            this.giaban,
            this.soluong,
            this.ngaynhap,
            this.ngaysx,
            this.hansd,
            this.tinhtrang,
            this.mahh,
            this.makho,
            this.mancc});
            this.dgvList.Location = new System.Drawing.Point(3, 43);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(694, 178);
            this.dgvList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSelectedList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 344);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách xuất";
            // 
            // dgvSelectedList
            // 
            this.dgvSelectedList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.xdathanhtoan,
            this.xsoluong,
            this.xtenhh,
            this.xgiaban,
            this.xmahh,
            this.xtonggia});
            this.dgvSelectedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedList.Location = new System.Drawing.Point(3, 16);
            this.dgvSelectedList.Name = "dgvSelectedList";
            this.dgvSelectedList.Size = new System.Drawing.Size(694, 325);
            this.dgvSelectedList.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(496, 227);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(577, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDropAll
            // 
            this.btnDropAll.Location = new System.Drawing.Point(371, 227);
            this.btnDropAll.Name = "btnDropAll";
            this.btnDropAll.Size = new System.Drawing.Size(75, 23);
            this.btnDropAll.TabIndex = 3;
            this.btnDropAll.Text = "Bỏ tất cả";
            this.btnDropAll.UseVisualStyleBackColor = true;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(254, 16);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(173, 21);
            this.cmbCustomers.TabIndex = 4;
            // 
            // dtpExportDate
            // 
            this.dtpExportDate.Location = new System.Drawing.Point(494, 17);
            this.dtpExportDate.Name = "dtpExportDate";
            this.dtpExportDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExportDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Khách hàng";
            // 
            // select
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "+";
            this.select.DefaultCellStyle = dataGridViewCellStyle1;
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select.HeaderText = "Chọn";
            this.select.Name = "select";
            this.select.Text = "+";
            this.select.Width = 50;
            // 
            // tenhh
            // 
            this.tenhh.DataPropertyName = "tenhh";
            this.tenhh.HeaderText = "Tên hàng hóa";
            this.tenhh.Name = "tenhh";
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.Name = "gianhap";
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "giaban";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng tồn";
            this.soluong.Name = "soluong";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // ngaysx
            // 
            this.ngaysx.DataPropertyName = "ngaysx";
            this.ngaysx.HeaderText = "Ngày sản xuất";
            this.ngaysx.Name = "ngaysx";
            // 
            // hansd
            // 
            this.hansd.DataPropertyName = "hansd";
            this.hansd.HeaderText = "Hạn sử dụng";
            this.hansd.Name = "hansd";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // mahh
            // 
            this.mahh.DataPropertyName = "mahh";
            this.mahh.HeaderText = "Mã hàng hóa";
            this.mahh.Name = "mahh";
            // 
            // makho
            // 
            this.makho.DataPropertyName = "makho";
            this.makho.HeaderText = "Mã kho";
            this.makho.Name = "makho";
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Nhà cung cấp";
            this.mancc.Name = "mancc";
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "X";
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewButtonColumn1.HeaderText = "Bỏ chọn";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "X";
            this.dataGridViewButtonColumn1.Width = 50;
            // 
            // xdathanhtoan
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "True";
            this.xdathanhtoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.xdathanhtoan.FalseValue = "0";
            this.xdathanhtoan.HeaderText = "Đã thanh toán?";
            this.xdathanhtoan.Name = "xdathanhtoan";
            this.xdathanhtoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xdathanhtoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xdathanhtoan.TrueValue = "1";
            // 
            // xsoluong
            // 
            dataGridViewCellStyle4.NullValue = "1";
            this.xsoluong.DefaultCellStyle = dataGridViewCellStyle4;
            this.xsoluong.HeaderText = "Số lượng";
            this.xsoluong.Name = "xsoluong";
            // 
            // xtenhh
            // 
            this.xtenhh.HeaderText = "Tên hàng hóa";
            this.xtenhh.Name = "xtenhh";
            // 
            // xgiaban
            // 
            this.xgiaban.HeaderText = "Giá bán";
            this.xgiaban.Name = "xgiaban";
            // 
            // xmahh
            // 
            this.xmahh.HeaderText = "Mã hàng hóa";
            this.xmahh.Name = "xmahh";
            // 
            // xtonggia
            // 
            this.xtonggia.HeaderText = "Tổng giá";
            this.xtonggia.Name = "xtonggia";
            // 
            // ucXuatHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucXuatHangHoa";
            this.Size = new System.Drawing.Size(700, 600);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDropAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSelectedList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpExportDate;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DataGridViewButtonColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysx;
        private System.Windows.Forms.DataGridViewTextBoxColumn hansd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn makho;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xdathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn xgiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtonggia;
    }
}
