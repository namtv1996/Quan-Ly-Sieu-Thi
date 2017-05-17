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
using QLBanHangSieuThi.Object;
using System.Data.SqlClient;

namespace QLBanHangSieuThi.UC
{
    public partial class ucXuatHangHoa : UserControl
    {
        private MyContext db = new MyContext();

        public ucXuatHangHoa()
        {
            InitializeComponent();
            Load += UcXuatHangHoa_Load;
            dgvList.CellClick += DgvList_CellClick;
            dgvSelectedList.CellClick += DgvSelectedList_CellClick;
            btnDropAll.Click += BtnDropAll_Click;
            btnCancel.Click += BtnCancel_Click;
            btnSubmit.Click += BtnSubmit_Click;
            dgvSelectedList.DataError += DgvSelectedList_DataError;
        }

        private void DgvSelectedList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // DO NOTHING HERE
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvSelectedList.Rows.Count > 1)
            {
                try
                {
                    foreach (DataGridViewRow row in dgvSelectedList.Rows)
                    {
                        if (row.Index < dgvSelectedList.Rows.Count - 1)
                        {
                            bool b = row.Cells[1].Value == DBNull.Value ? false : true;

                            var res = db.Database.ExecuteSqlCommand("sp_hh_xuat " +
                                "@mahh, @makh, @soluong, @ngayxuat, @tongtien, @dathanhtoan",
                                new object[]
                                {
                                new SqlParameter("@mahh", row.Cells[5].Value),
                                new SqlParameter("@makh", cmbCustomers.SelectedValue),
                                new SqlParameter("@soluong", row.Cells[2].Value),
                                new SqlParameter("@ngayxuat", dtpExportDate.Value),
                                new SqlParameter("@tongtien", row.Cells[6].Value),
                                new SqlParameter("@dathanhtoan", b ? 1: 0),
                                });
                            if (res < 0)
                            {
                                MessageBox.Show("Loi!");
                            }
                        }
                    }
                    MessageBox.Show("Đã xuất hàng thành công!");
                    dgvSelectedList.Rows.Clear();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            dgvSelectedList.Rows.Clear();
            LoadData();
        }

        private void BtnDropAll_Click(object sender, EventArgs e)
        {
            dgvSelectedList.Rows.Clear();
        }

        private void DgvSelectedList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && MessageBox.Show("Bỏ chọn xuất hàng này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvSelectedList.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = (DataGridViewRow)dgvSelectedList.Rows[0].Clone();
                double gia = (double)dgvList.CurrentRow.Cells["giaban"].Value;
                row.Cells[5].Value = dgvList.CurrentRow.Cells["mahh"].Value;
                row.Cells[3].Value = dgvList.CurrentRow.Cells["tenhh"].Value;
                row.Cells[4].Value = dgvList.CurrentRow.Cells["giaban"].Value;
                row.Cells[6].Value = gia;

                dgvSelectedList.Rows.Add(row);
            }
        }

        private void LoadData()
        {
            dgvList.DataSource = db.Database.SqlQuery<ChiTietHangHoa>("sp_hh_xem",
                new object[] { }).ToList();
        }

        private void UcXuatHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbCustomers.DataSource = db.KhachHangs.ToList();
            cmbCustomers.DisplayMember = "tenkh";
            cmbCustomers.ValueMember = "makh";
            dgvList.ClearSelection();
        }
    }
}
