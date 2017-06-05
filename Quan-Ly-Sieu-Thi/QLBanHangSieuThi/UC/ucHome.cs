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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            Load += UcHome_Load;
            btnEdit.Click += BtnEdit_Click;
            btnSave.Click += BtnSave_Click;
            btnSearch.Click += BtnSearch_Click;
            dgvList.DataError += DgvList_DataError;
            btnReload.Click += BtnReload_Click;
            dgvList.CellClick += DgvList_CellClick;

            LockControl();
            btnEdit.Enabled = false;
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            using (var row = dgvList.CurrentRow)
            {
                txtGoodsID.Text = row.Cells["mahh"].Value.ToString();
                txtGoodsName.Text = row.Cells["tenhh"].Value.ToString();
                txtEntryPrice.Text = row.Cells["gianhap"].Value.ToString();
                txtQuantity.Text = row.Cells["soluong"].Value.ToString();
                txtState.Text = row.Cells["tinhtrang"].Value.ToString();
                cmbStore.SelectedValue = row.Cells["makho"].Value;
                cmbSupplier.SelectedValue = row.Cells["mancc"].Value;
                dtpEntryDate.Value = (DateTime)row.Cells["ngaynhap"].Value;
                dtpManufactureDate.Value = (DateTime)row.Cells["ngaysx"].Value;
                dtpExpiredDate.Value = (DateTime)row.Cells["hansd"].Value;
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // DO NOTHING HERE !
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new MyContext())
            {
                try
                {
                    var res = db.Database.SqlQuery<ChiTietHangHoa>("sp_hh_timkiem @value",
                        new object[]
                        {
                            new SqlParameter("@value", txtSearchBox.Text)
                        }).ToList();
                    dgvList.DataSource = res;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtGoodsID.Text != string.Empty)
            {
                using(var db=new MyContext())
                {
                    try
                    {
                        var res = db.Database.ExecuteSqlCommand("sp_hh_sua @mahh, @tenhh, @gianhap," +
                            "@giaban,@ngaysx,@hansd,@tinhtrang,@soluong,@ngaynhap,@makho,@mancc",
                            new object[]
                            {
                            new SqlParameter("@mahh", txtGoodsID.Text),
                            new SqlParameter("@tenhh", txtGoodsName.Text),
                            new SqlParameter("@gianhap", txtEntryPrice.Text),
                            new SqlParameter("@giaban", txtSalePrice.Text),
                            new SqlParameter("@ngaysx", dtpManufactureDate.Value),
                            new SqlParameter("@hansd", dtpExpiredDate.Value),
                            new SqlParameter("@tinhtrang", txtState.Text),
                            new SqlParameter("@soluong", txtQuantity.Text),
                            new SqlParameter("@ngaynhap", dtpEntryDate.Value),
                            new SqlParameter("@makho", cmbStore.SelectedValue),
                            new SqlParameter("@mancc", cmbSupplier.SelectedValue)
                            });
                        if (res > 0) MessageBox.Show("Đã cập nhật!");
                        btnEdit.Enabled = false;
                        RefreshForm();
                        LockControl();
                        LoadData();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            UnlockControl();
        }

        private void LoadData()
        {
            using (MyContext db = new MyContext())
            {
                dgvList.DataSource = db.Database.SqlQuery<ChiTietHangHoa>("sp_hh_xem",
                    new object[] { }).ToList();

                dgvList.Columns[0].HeaderText = "Mã";
                dgvList.Columns[1].HeaderText = "Tên";
                dgvList.Columns[2].HeaderText = "Giá nhập";
                dgvList.Columns[3].HeaderText = "Giá bán";
                dgvList.Columns[4].HeaderText = "Ngày nhập";
                dgvList.Columns[5].HeaderText = "Số lượng";
                dgvList.Columns[6].HeaderText = "Ngày sản xuất";
                dgvList.Columns[7].HeaderText = "Hạn dùng";
                dgvList.Columns[8].HeaderText = "Tình trạng";
                dgvList.Columns[9].HeaderText = "Mã kho";
                dgvList.Columns[10].HeaderText = "Mã nhà cung cấp";

            }
        }

        private void UcHome_Load(object sender, EventArgs e)
        {
            LoadData();
            using (MyContext db=new MyContext())
            {
                cmbStore.DataSource = db.Khoes.ToList();
                cmbStore.DisplayMember = "tenkho";
                cmbStore.ValueMember = "makho";

                cmbSupplier.DataSource = db.NhaCungCaps.ToList();
                cmbSupplier.DisplayMember = "tenncc";
                cmbSupplier.ValueMember = "mancc";
            }
        }

        private void LockControl()
        {
            btnSave.Enabled = false;
        }

        private void UnlockControl()
        {
            btnSave.Enabled = true;
        }

        private void RefreshForm()
        {
            txtGoodsID.Text = string.Empty;
            txtEntryPrice.Text = string.Empty;
            txtGoodsName.Text = string.Empty;
            txtSalePrice.Text = string.Empty;
            txtState.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }
    }
}
