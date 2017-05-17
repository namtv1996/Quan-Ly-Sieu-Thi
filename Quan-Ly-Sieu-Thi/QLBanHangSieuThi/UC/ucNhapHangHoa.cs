using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHangSieuThi.Model;
using System.Data.SqlClient;

namespace QLBanHangSieuThi.UC
{
    public partial class ucNhapHangHoa : UserControl
    {
        public ucNhapHangHoa()
        {
            InitializeComponent();
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += BtnCancel_Click;
            btnAdd.Click += BtnAdd_Click;
            this.Load += UcNhapHangHoa_Load;
            dgvList.CellClick += DgvList_CellClick;
            txtEntryPrice.Validating += TxtEntryPrice_Validated;
            nudQuantity.Validating += TxtEntryPrice_Validated;
        }

        private void TxtEntryPrice_Validated(object sender, EventArgs e)
        {
            if (txtEntryPrice.Text != string.Empty)
            {
                txtTotalCost.Text = (int.Parse(txtEntryPrice.Text) * nudQuantity.Value).ToString();
            }
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Bỏ chọn nhập hàng hóa này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    dgvList.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void LoadData()
        {
            using (var db = new MyContext())
            {
                cmbProducer.DataSource = db.NhaCungCaps.ToList();
                cmbProducer.DisplayMember = "tenncc";
                cmbProducer.ValueMember = "mancc";

                cmbStore.DataSource = db.Khoes.ToList();
                cmbStore.DisplayMember = "tenkho";
                cmbStore.ValueMember = "makho";
            }
        }

        private void UcNhapHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvList.Rows[0].Clone();
            row.Cells[1].Value = txtGoodsName.Text;
            row.Cells[2].Value = cmbStore.SelectedValue;
            row.Cells[4].Value = txtEntryPrice.Text;
            row.Cells[5].Value = nudQuantity.Value;
            row.Cells[7].Value = dtpManufactureDate.Value;
            row.Cells[8].Value = dtpExpiredDate.Value;
            row.Cells[9].Value = txtState.Text;
            row.Cells[11].Value = txtTotalCost.Text;
            row.Cells[3].Value = cmbProducer.SelectedValue;
            row.Cells[6].Value = dtpEntryDate.Value;
            row.Cells[10].Value = txtEntryPlace.Text;

            dgvList.Rows.Add(row);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bỏ nhập tất cả?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                dgvList.Rows.Clear();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 1)
            {
                using (var db = new MyContext())
                {
                    try
                    {
                        foreach (DataGridViewRow row in dgvList.Rows)
                        {
                            if (row.Index < dgvList.Rows.Count-1)
                            {
                                var res = db.Database.ExecuteSqlCommand("sp_hh_nhap " +
                                    "@tenhh, @gianhap, @ngaysx, @hansd, @tinhtrang, @soluong, @makho," +
                                    "@ngaynhap, @mancc, @diadiem, @tonggia",
                                    new object[] {
                                new SqlParameter("@tenhh", row.Cells["tenhh"].Value),
                                new SqlParameter("@gianhap", row.Cells["gianhap"].Value),
                                new SqlParameter("@ngaysx", row.Cells["ngaysx"].Value),
                                new SqlParameter("@hansd", row.Cells["hansd"].Value),
                                new SqlParameter("@tinhtrang", row.Cells["tinhtrang"].Value),
                                new SqlParameter("@soluong", row.Cells["soluong"].Value),
                                new SqlParameter("@makho", row.Cells["makho"].Value),
                                new SqlParameter("@ngaynhap", row.Cells["ngaynhap"].Value),
                                new SqlParameter("@mancc", row.Cells["mancc"].Value),
                                new SqlParameter("@diadiem", row.Cells["diadiem"].Value),
                                new SqlParameter("@tonggia", row.Cells["tonggia"].Value),
                                    });

                                if (res < 0)
                                {
                                    MessageBox.Show("Nhập lỗi!");
                                }
                                FormRefresh();
                            }
                        }
                        MessageBox.Show("Nhập thành công!");
                        dgvList.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void FormRefresh()
        {
            txtGoodsName.Text = string.Empty;
            txtState.Text = string.Empty;
            nudQuantity.Value = 1;
            txtTotalCost.Text = string.Empty;
            txtEntryPrice.Text = string.Empty;
            txtEntryPlace.Text = string.Empty;
        }
    }
}
